using EToolService.Model.Models;
using EToolService.Mobile.Services;
using EToolService.Model.Requests;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Order");
        public ObservableCollection<Order> Orders { get; set; } =
            new ObservableCollection<Order>();
        public OrderViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            var request = new OrderSearchRequest()
            {
                CustomerId = APIService.Client.Id
            };

            var result = await _service.Get<List<Order>>(request);
            result = result.OrderByDescending(x => x.OrderDate).ToList();
            Orders.Clear();
            result.ForEach((Order order) => Orders.Add(order));
            
        }
    }
}