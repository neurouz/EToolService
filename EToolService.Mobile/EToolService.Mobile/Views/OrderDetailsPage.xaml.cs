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
    public partial class OrderDetailsPage : ContentPage
    {
        private readonly OrderDetailsViewModel model = null;
        public OrderDetailsPage(Order order)
        {
            InitializeComponent();
            BindingContext = model = new OrderDetailsViewModel()
            {
                Order = order
            };
        }
    }
}