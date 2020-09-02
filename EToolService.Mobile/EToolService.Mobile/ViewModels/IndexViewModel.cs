using EToolService.Model.Models;
using EToolService.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Product/Recommend");
        public ObservableCollection<KeyValuePair<Product, decimal>> Products { get; set; }
            = new ObservableCollection<KeyValuePair<Product, decimal>>();
        public ICommand SelectedProduct { get; set; }
        public IndexViewModel()
        {
            SelectedProduct = new Command(async () => await OpenDetails());
        }
        public async Task OpenDetails()
        {
            if (Products.Count > 0) return;
            try
            {
                // Getting recommended products
                var request = await _service.GetById<List<EToolService.Model.Models.Product>>
                    (APIService.Client.Id);
                Products.Clear();
                request.ForEach((Product product) => Products.Add(new KeyValuePair<Product, decimal>(product, product.Price * (1 - product.Discount))));
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
        }

    }
}
