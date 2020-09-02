using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EToolService.Mobile.Services;
using EToolService.Mobile.Validators;
using EToolService.Model.Requests;
using FluentValidation;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class RequestFormViewModel : BaseViewModel
    {
        public ToolServiceInsertRequest Request { get; set; } = new ToolServiceInsertRequest();
        private readonly APIService _service = new APIService("ToolService/InsertService");
        private readonly IValidator _validator = new ServiceRequestValidator();

        public ObservableCollection<string> ServiceTypes { get; set; } = new ObservableCollection<string>();
        public ICommand SubmitCommand { get; set; }

        public RequestFormViewModel()
        {
            SubmitCommand = new Command(async () => await Submit());
            ServiceTypes.Add("Oštrenje");
            ServiceTypes.Add("Reparacija");
        }

        public async Task<bool> Validate()
        {
            var result = (_validator as ServiceRequestValidator).Validate(Request);

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

        private async Task Submit()
        {
            var isValid = await Validate();
            if (!isValid)
                return;

            try
            {
                Request.CustomerId = APIService.Client.Id;
                var result = await _service.Insert<EToolService.Model.Models.Services>(Request);
                if (result != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Info", "Zahtjev poslan", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Dogodila se greška", "OK");
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", $"Dogodila se greška: {e.Message}", "OK");
            }
        }
    }
}
