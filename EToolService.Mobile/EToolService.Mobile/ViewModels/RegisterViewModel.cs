using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using EToolService.Mobile.Services;
using Xamarin.Forms;
using System.Threading.Tasks;
using Exception = System.Exception;
using EToolService.Mobile.Validators;
using FluentValidation;
using EToolService.Mobile.Views;
using EToolService.Model.Models;
using EToolService.Model.Requests;

namespace EToolService.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Area");
        private readonly APIService _customerService = new APIService("Customer");
        private readonly IValidator _validator = new RegisterValidator();
        public ObservableCollection<Area> AreasList { get; set; } = new ObservableCollection<Area>();
        public ICommand InitCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public RegisterViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RegisterCommand = new Command(async () => await RegisterUser());
        }

        private async Task RegisterUser()
        {
            try
            {
                var isValid = await Validate();
                if (!isValid)
                    return;

                _request.AreaId = SelectedArea.Id;
                var result = await _customerService.Insert<EToolService.Model.Models.Customer>(_request);
                await Application.Current.MainPage.DisplayAlert("Info", "Uspješno ste registrovani. Sada se možete prijaviti na aplikaciju", "OK");
                Application.Current.MainPage = new LoginPage();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
        }

        public async Task<bool> Validate()
        {
            var result = (_validator as RegisterValidator).Validate(CustomerRequest);
            
            if (!result.IsValid)
            {                
                foreach (var error in result.Errors)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", error.ErrorMessage, "OK");
                }
                return false;
            }
            return true;
        }

        public async Task Init()
        { 
            var request = await _service.Get<List<EToolService.Model.Models.Area>>(null);
            foreach (var area in request)
            {
                AreasList.Add(area);
                if (area.Id == 4)
                    SelectedArea = area;
            }
        }

        private CustomerInsertRequest _request = new CustomerInsertRequest();

        public CustomerInsertRequest CustomerRequest
        {
            get { return _request; }
            set { SetProperty(ref _request, value); }
        }

        private Area _selectedArea = new Area();

        public Area SelectedArea
        {
            get { return _selectedArea; }
            set { SetProperty(ref _selectedArea, value); }
        }
    }
}
