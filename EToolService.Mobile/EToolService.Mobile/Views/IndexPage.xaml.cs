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
    public partial class IndexPage : ContentPage
    {
        private readonly IndexViewModel model = null;
        public IndexPage()
        {
            InitializeComponent();
            BindingContext = model = new IndexViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.OpenDetails();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (KeyValuePair<Product, decimal>)e.SelectedItem;
            await Navigation.PushAsync(new ProductDetailPage(item));
        }
    }
}