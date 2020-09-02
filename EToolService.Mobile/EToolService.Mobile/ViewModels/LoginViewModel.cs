using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EToolService.Mobile.Models;
using EToolService.Mobile.Services;
using EToolService.Mobile.Views;
using EToolService.Model.Models;
using EToolService.Model.Requests;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Account");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegisterCommand = new Command(() => Application.Current.MainPage = new RegisterPage());
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        private string _username = "mobile";

        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _password = "test";

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                var request = new AuthenticateRequest()
                {
                    Username = APIService.Username,
                    Password = APIService.Password
                };

                var result = await _service.Authenticate(request);
                if (result != null)
                {
                    var customer = await new APIService("Customer/GetByAccountId").GetById<Customer>(result.Id);
                    APIService.Client = customer;
                    IsBusy = false;
                    var mainPage = new MainPage();
                    await mainPage.NavigateFromMenu((int)MenuItemType.Pocetak);
                    Application.Current.MainPage = mainPage;
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
               await Application.Current.MainPage.DisplayAlert("Greška", "Podaci nisu ispravni", "OK");
            }

            IsBusy = false;
        }
    }
}
