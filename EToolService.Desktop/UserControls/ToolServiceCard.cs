using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Services;
using XanderUI;
using EToolService.Desktop.Forms.ToolService;
using System.Threading;

namespace EToolService.Desktop.UserControls
{
    public partial class ToolServiceCard : UserControl
    {
        private readonly APIService _service = new APIService("ToolService");
        private EToolService.Model.Models.Services _toolService;
        public frmToolService Parent { get; set; }
        public ToolServiceCard(EToolService.Model.Models.Services service, frmToolService parent)
        {
            InitializeComponent();
            _toolService = service;
            Parent = parent;
        }

        private XUIButton FindBannerButton(string name, Control control, int count = 0)
        {
            if (count >= 10) 
                return null;

            try
            {
                return (XUIButton)control.Controls.Find(name, false).First();
            }
            catch (Exception)
            {
                return FindBannerButton(name, control.Parent, count++);
            }
        }

        private async Task<bool> UpdateBanner(bool Patch = true)
        {
            if(Patch)
                await _service.Patch<EToolService.Model.Models.Services>(_toolService.Id, null);
            var button = FindBannerButton("bannerService", Parent);          

            var pendingServices = await _service.GetWithUrl<int>(null, "GetPendingServices");
            
            if (pendingServices == 0)
                button.Visible = false;

            else if (pendingServices == frmIndex.PendingServices)
                return false;

            else
            {
                button.Visible = true;
                button.ButtonText = pendingServices.ToString();
                button.Show();
                frmIndex.PendingServices = pendingServices;
            }
            return true;
        }

        private async void btnDetalji_Click(object sender, EventArgs e)
        {
            var serviceDetails = new frmToolDetails(_toolService.Id);
            serviceDetails.Show();

            var result = await UpdateBanner();
            if (result == true)
                lblPending.Visible = false;
        }

        private async void ToolServiceCard_Load(object sender, EventArgs e)
        {
            valCompanyName.Text = _toolService.CustomerName;

            if (_toolService.Note == null || string.IsNullOrEmpty(_toolService.Note))
                valDetails.Text = "Klijent nije unio detaljne informacije o servisu";
            else
                valDetails.Text = _toolService.Note;

            if ((bool)!_toolService?.Viewed)
                lblPending.Visible = true;

            var responsed = await _service.GetWithUrl<bool>(null, $"IsResponsed/{_toolService.Id}");
            if (responsed)
            {
                DisableButton();
            }
        }

        private async void btnUkloni_Click(object sender, EventArgs e)
        {
            if ((bool)!_toolService.Viewed)
            {
                if(MessageBox.Show("Niste još pogledali detalje za ovaj servis. Jeste li sigurni da ga želite ukloniti?", 
                    "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            var result = await _service.Delete(_toolService.Id);

            if (result.IsSuccessStatusCode)
            {
                MessageBox.Show("Servis uspješno uklonjen", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Parent.Reload();
            }
            else
            {
                MessageBox.Show(result.Content.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await UpdateBanner(false);
        }

        public async void DisableButton()
        {
            btnOdgovori.Enabled = false;
            btnOdgovori.Text = "Odgovoreno";
            btnOdgovori.BackColor = Color.DarkGray;

            var result = await UpdateBanner();
            if (result == true)
                lblPending.Visible = false;
        }

        private async void btnOdgovori_Click(object sender, EventArgs e)
        {
            var form = new frmServiceResponse(_toolService.Id) { Card = this };
            form.Show();
        }
    }
}