using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EToolService.Mobile.Services;
using EToolService.Mobile.ViewModels;
using EToolService.Model.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EToolService.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCartPage : ContentPage
    {
        private readonly CartViewModel model = null;

        public MyCartPage()
        {
            InitializeComponent();
            BindingContext = model = new CartViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
            if (OrderService.Cart.Count() == 0)
            {
                title.Text = "Trenutno nemate proizvoda u korpi";
                BtnConfirm.IsEnabled = false;
            }
            else
            {
                title.Text = "Vaša korpa";
                BtnConfirm.IsEnabled = true;
            }
        }
    }
}