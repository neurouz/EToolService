using EToolService.Desktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EToolService.Desktop.Forms.Order
{
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails(EToolService.Model.Models.Order order)
        {
            InitializeComponent();

            valAdresa.Text = order.ShippingAddress;
            valAktivna.Text = order.Active ? "Aktivna" : "Završena";
            valID.Text = order.Id.ToString();
            valKontakt.Text = order.ContactNumber;
            valKupac.Text = order.CustomerName;
            // Suma od: Cijena * kolicina
            valUkupno.Text = order.Products.Sum(x => (x.Value.Price * (1 - x.Value.Discount)) * x.Key).ToString("N") + " KM";
            valDatum.Text = order.OrderDate.ToString("dd/MM/yyyy");

            foreach(var product in order.Products)
            {
                var productInfoControl = new ProductDetails(product.Key, product.Value);
                productInfoControl.Dock = DockStyle.Top;
                productInfoControl.Show();
                panel1.Controls.Add(productInfoControl);
            }

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
