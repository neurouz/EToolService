using EToolService.Mobile.Converters;
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
    public partial class ServiceDetailsPage : ContentPage
    {
        public ServiceDetailsViewModel model = null;
        public ServiceDetailsPage(EToolService.Model.Models.Services service)
        {
            InitializeComponent();
            BindingContext = model = new ServiceDetailsViewModel()
            {
                Service = service,
                ServiceConverted = new CustomServiceConverter(service).Convert()
            };
        }
    }
}