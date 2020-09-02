using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;

namespace EToolService.Desktop.Forms.Customer
{
    public partial class frmCustomers : Form
    {
        private readonly APIService _service = new APIService("Customer");
        public frmCustomers()
        {
            InitializeComponent();
        }

        private async void frmCustomers_Load(object sender, EventArgs e)
        {
            var customers = await _service.Get<List<EToolService.Model.Models.Customer>>(null);
            for (int i = customers.Count - 1; i >= 0; i--)
            {
                var card = new ClientCard(customers[i]);
                card.Dock = DockStyle.Top;
                card.Show();
                panel1.Controls.Add(card);
            }
        }
    }
}
