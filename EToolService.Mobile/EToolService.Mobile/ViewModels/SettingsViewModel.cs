using EToolService.Mobile.Services;
using EToolService.Mobile.Validators;
using EToolService.Model.Models;
using EToolService.Model.Requests;
using FluentValidation;
using Flurl.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Area");
        private readonly APIService _customerService = new APIService("Customer");

        public ObservableCollection<Area> AreasList { get; set; } = new ObservableCollection<Area>();
        private readonly IValidator _validator = new SettingsValidator();

        public ICommand InitCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        public SettingsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UpdateCommand = new Command(async () => await UpdateUser());
        }

        public async Task<bool> Validate(CustomerUpdateRequest request)
        {
            var result = (_validator as SettingsValidator).Validate(request);

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
                if (area.AreaName == APIService.Client.AreaName)
                    SelectedArea = area;
            }
        }

        private async Task UpdateUser()
        {
            try
            {
                var request = new CustomerUpdateRequest()
                {
                    Address = _address,
                    AreaId = _selectedArea.Id,
                    CompanyName = _companyName,
                    Email = _email,
                    Password = _password,
                    PasswordConfirm = _passwordConfirm,
                    PhoneNumber = _phoneNumber,
                    Username = _username
                };

                var isValid = await Validate(request);
                if (!isValid)
                    return;

                var result = await _customerService.Update<Customer>(APIService.Client.Id, request);
                if(result != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Info", "Uspješno ste promijenili podatke", "OK");
                    APIService.Username = request.Username;
                    APIService.Password = request.Password;
                    APIService.Client = result;
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
        }

        private string _address = APIService.Client.Address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        private Area _selectedArea = new Area();
        public Area SelectedArea
        {
            get { return _selectedArea; }
            set { SetProperty(ref _selectedArea, value); }
        }

        private string _companyName = APIService.Client.CompanyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { SetProperty(ref _companyName, value); }
        }

        private string _email = APIService.Client.Account.Email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _username = APIService.Username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _phoneNumber = APIService.Client.Account.PhoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        private string _passwordConfirm = APIService.Password;
        public string PasswordConfirm
        {
            get { return _passwordConfirm; }
            set { SetProperty(ref _passwordConfirm, value); }
        }

        private string _password = APIService.Password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
    }
}
