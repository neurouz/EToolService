using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EToolService.Mobile.Services;
using EToolService.Model.Models;
using EToolService.Model.Requests;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Order");
        public ObservableCollection<Tuple<EToolService.Model.Models.Product, int, decimal>> ProductList { get; set; }
            = new ObservableCollection<Tuple<Product, int, decimal>>();

        public CartViewModel()
        {
            InitCommand = new Command(() => Init());
            ConfirmOrder = new Command(async () => await Confirm());
        }
        public ICommand InitCommand { get; set; }
        public ICommand ConfirmOrder { get; set; }

        public async Task Confirm()
        {
            if (OrderService.Cart.Count() == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Vaša korpa je prazna", "OK");
                return;
            }

            var request = new OrderInsertRequest()
            {
                ShippingAddress = APIService.Client.Address,
                ContactNumber = APIService.Client.Account.PhoneNumber,
                CustomerId = APIService.Client.Id
            };

            var x = new List<KeyValuePair<int, int>>();

            foreach (var item in OrderService.Cart)
            {
                // Product ID, Quantity
                request.Products.Add(item.Value.Id);
                request.Quantities.Add(item.Count);
            }

            try
            {
                var result = await _service.Insert<EToolService.Model.Models.Order>(request);
                if (result != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Info", "Uspješno ste ostvarili narudžbu", "OK");
                    OrderService.Cart.Clear();
                    Init();
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", e.Message, "OK");
            }
        }

        public void Init()
        {
            ProductList.Clear();
            var items = OrderService.Cart;
            foreach (var item in items)
            { 
                decimal priceWithDiscount = item.Value.Price * (1 - item.Value.Discount);
                ProductList.Add(new Tuple<Product, int, decimal>(item.Value, item.Count, Math.Round(item.Count * priceWithDiscount, 2)));
            }

            Total = ProductList.Sum(x => x.Item3);
        }

        private decimal _total = 0;
        public decimal Total
        {
            get { return _total; }
            set => SetProperty(ref _total, value); 
        }
    }
}
