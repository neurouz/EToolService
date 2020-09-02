using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Models;
using EToolService.Model.Models;
using Org.BouncyCastle.Asn1.Cms;
using EToolService.Desktop.Services;
using EToolService.Desktop.Forms.Order;

namespace EToolService.Desktop.UserControls
{
    public partial class OrderCard : UserControl
    {
        private readonly APIService _service = new APIService("Order");
        private EToolService.Model.Models.Order _order;
        public frmOrders Parent;
        public OrderCard(EToolService.Model.Models.Order order)
        {
            InitializeComponent();

            lblAdresa.Text = order.ShippingAddress;
            lblDatum.Text = order.OrderDate.ToString("yyyy MMMM dd");
            lblIznos.Text = order.Products.Sum(x => (x.Value.Price * (1 - x.Value.Discount)) * x.Key).ToString("N") + " KM";
            lblNarucioc.Text = order.CustomerName;
            _order = order;

            btnZavršeno.Visible = order.Active ? false : true;
            btnPotvrdi.Visible = order.Active ? true : false;
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            new frmOrderDetails(_order).Show();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            var result = _service.Patch<EToolService.Model.Models.Order>(_order.Id, null);
            MessageBox.Show("Uspješno evidentirano", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Parent.Reload();
        }
    }
}
