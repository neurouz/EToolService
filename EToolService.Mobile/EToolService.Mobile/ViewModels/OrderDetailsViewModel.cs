using EToolService.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class OrderDetailsViewModel : BaseViewModel
    {
        public Order Order { get; set; }
        public OrderDetailsViewModel()
        {
        }
    }
}
