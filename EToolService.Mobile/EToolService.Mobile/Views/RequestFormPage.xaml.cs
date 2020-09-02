using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EToolService.Mobile.ViewModels;
using Plugin.FilePicker;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EToolService.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestFormPage : ContentPage
    {
        private readonly RequestFormViewModel Model = null;
        public RequestFormPage()
        {
            InitializeComponent();
            BindingContext = Model = new RequestFormViewModel();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                TxtFilename.Text = file.FileName;
                Model.Request.Attachment = file.DataArray;
                Model.Request.FileName = file.FileName;
            }
        }
    }
}