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
    public partial class ProductDetailPage : ContentPage
    {
        private ProductDetailModel model = null;
        public ProductDetailPage(KeyValuePair<Product, decimal> product)
        {
            InitializeComponent();
            BindingContext = model = new ProductDetailModel()
            {
                Proizvod = product.Key,
                Cijena = product.Value
            };
        }
    }
}