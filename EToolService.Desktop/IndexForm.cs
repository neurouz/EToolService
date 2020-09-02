using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EToolService.Desktop.Forms.Customer;
using EToolService.Desktop.Forms.Employee;
using EToolService.Desktop.Forms.Material;
using EToolService.Desktop.Forms.Order;
using EToolService.Desktop.Forms.Product;
using EToolService.Desktop.Forms.Report;
using EToolService.Desktop.Forms.ToolService;
using EToolService.Desktop.Helpers;
using EToolService.Desktop.Properties;
using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;
using EToolService.Model.Enumerations;

namespace EToolService.Desktop
{
    public partial class frmIndex : Form
    {

        private readonly Panel _singleLayoutPanel = new Panel();
        public static int PendingServices;

        public frmIndex()
        {
            InitializeComponent();

            _singleLayoutPanel.Size = new Size(829, 376);
            _singleLayoutPanel.Dock = DockStyle.None;
            _singleLayoutPanel.Location = new Point(20, 100);

            bannerService.Visible = false;
        }

        private void EmptyPanel()
        {
            mainPanel.Controls.Clear();
            _singleLayoutPanel.Controls.Clear();
        }

        private void SetSidebarLayout()
        {
            EmptyPanel();
            PanelHelper.ShowHidePanels(false, _singleLayoutPanel);
            PanelHelper.ShowHidePanels(true, sidebarPanel, mainPanel);
            separator.Visible = true;
        }

        private void SetSingleLayout()
        {
            EmptyPanel();
            PanelHelper.ShowHidePanels(false, sidebarPanel, mainPanel);
            PanelHelper.ShowHidePanels(true, _singleLayoutPanel);
            separator.Visible = false;
            Controls.Add(_singleLayoutPanel);
        }

        private void btnUposlenici_Click(object sender, EventArgs e)
        {
            SetSidebarLayout();
            PanelHelper.SwapContent(sidebarPanel, new EmployeeSidebar());
            PanelHelper.SwapPanel(mainPanel, new frmEmployeeList());
        }

        private void btnMaterijal_Click(object sender, EventArgs e)
        {
            SetSidebarLayout();
            PanelHelper.SwapContent(sidebarPanel, new MaterialSidebar());
            PanelHelper.SwapPanel(mainPanel, new frmMaterialShow(MaterialTypes.All, true));
        }

        private void frmIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            CausesValidation = false;
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            SetSingleLayout();
            PanelHelper.SwapPanel(_singleLayoutPanel, new frmReport());
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            SetSingleLayout();
            PanelHelper.SwapPanel(_singleLayoutPanel, new frmOrders());
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            SetSingleLayout();
            PanelHelper.SwapPanel(_singleLayoutPanel, new frmToolService());
        }

        private async void frmIndex_Load(object sender, EventArgs e)
        {
            var pendingServices = -1;
            try
            {
                pendingServices = await new APIService("ToolService").GetWithUrl<int>(null, "GetPendingServices");
            }
            catch (Exception)
            {
                Thread.Sleep(500);
                Console.WriteLine("API is not available yet");
                frmIndex_Load(sender, e);
            }

            PendingServices = pendingServices;

            if (pendingServices == 0)
                bannerService.Visible = false;
            else
            {
                bannerService.Visible = true;
                bannerService.ButtonText = pendingServices.ToString();
            }                
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            SetSingleLayout();
            PanelHelper.SwapPanel(_singleLayoutPanel, new frmCustomers());
        }

        private void btnProizvodi_Click(object sender, EventArgs e)
        {
            SetSingleLayout();
            PanelHelper.SwapPanel(_singleLayoutPanel, new frmProducts());
        }
    }
}
