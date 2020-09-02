using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EToolService.Mobile.Services;
using EToolService.Model.Models;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Product");
        public ObservableCollection<KeyValuePair<EToolService.Model.Models.Product, decimal>> ProductList { get; set; } = 
            new ObservableCollection<KeyValuePair<Product, decimal>>();

        public ProductsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (ProductList.Count == 0)
            {
                var products = await _service.Get<List<EToolService.Model.Models.Product>>(null);
                products.ForEach((Product product) => ProductList.Add(new KeyValuePair<Product, decimal>(product, product.Price * (1 - product.Discount))));
            }
        }
    }
}
