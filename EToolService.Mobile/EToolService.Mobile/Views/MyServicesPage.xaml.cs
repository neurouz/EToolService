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
    public partial class MyServicesPage : ContentPage
    {
        private ToolServiceViewModel Model = null;
        public MyServicesPage()
        {
            InitializeComponent();
            BindingContext = Model = new ToolServiceViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (EToolService.Model.Models.Services)e.SelectedItem;
            await Navigation.PushAsync(new ServiceDetailsPage(item));
        }
    }
}