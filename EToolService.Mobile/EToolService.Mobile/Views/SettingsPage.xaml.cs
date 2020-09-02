using EToolService.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EToolService.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private readonly SettingsViewModel Model = null;
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = Model = new SettingsViewModel();
        }
        protected override async void OnAppearing()
        {
            await Model.Init();
            base.OnAppearing();
        }
    }
}