using EToolService.Model.Models;
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
    public partial class OrdersPage : ContentPage
    {
        private OrderViewModel model = null;
        public OrdersPage()
        {
            InitializeComponent();
            BindingContext = model = new OrderViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Order;
            await Navigation.PushAsync(new OrderDetailsPage(item));
        }
    }
}