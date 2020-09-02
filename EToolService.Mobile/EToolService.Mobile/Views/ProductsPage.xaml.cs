using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EToolService.Mobile.ViewModels;
using EToolService.Model.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EToolService.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        private readonly ProductsViewModel model = null;
        public ProductsPage()
        {
            InitializeComponent();
            BindingContext = model = new ProductsViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (KeyValuePair<Product, decimal>)e.SelectedItem;
            await Navigation.PushAsync(new ProductDetailPage(item));
        }
    }
}