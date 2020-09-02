using EToolService.Model.Models;
using EToolService.Mobile.Services;
using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EToolService.Mobile.ViewModels
{
    public class ToolServiceViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("ToolService");
        public ObservableCollection<EToolService.Model.Models.Services> Services { get; set; } =
            new ObservableCollection<EToolService.Model.Models.Services>();
        public ICommand InitCommand { get; set; }
        public ToolServiceViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            ActivityIndicator indicator = new ActivityIndicator() { IsRunning = true };
            var request = new ToolServiceSearchRequest()
            {
                CustomerId = APIService.Client.Id
            };

            var result = await _service.Get<List<EToolService.Model.Models.Services>>(request);

            Services.Clear();
            result.ForEach((EToolService.Model.Models.Services service) => Services.Add(service));

            indicator.IsRunning = false;
        }
    }
}
