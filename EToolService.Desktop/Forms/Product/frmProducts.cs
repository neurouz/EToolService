using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;
using EToolService.Model.Models;
using EToolService.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EToolService.Desktop.Forms.Product
{
    public partial class frmProducts : Form
    {
        private readonly APIService _service = new APIService("Product");
        private int Page = 1;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void ClearPanel()
        {
            this.flowProductsPanel.Controls.Clear();
        }

        private async void frmProducts_Load(object sender, EventArgs e)
        {
            var request = new ProductSearchRequest()
            {
                Page = Page,
                ItemsPerPage = 4
            };

            var productList = await _service.Get<List<EToolService.Model.Models.Product>>(request);

            if (Page > 1 && productList.Count == 0)
            {
                Page--;
                return;
            }

            if (Page < 1)
            {
                Page = 1;
                return;
            }

            ClearPanel();

            for (int i = productList.Count() - 1; i >= 0; i--)
            {
                var card = new ProductCard(productList[i]);
                card.Show();
                flowProductsPanel.Controls.Add(card);
            }
            flowProductsPanel.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Page == 1)
                return;
            Page--;
            frmProducts_Load(sender, EventArgs.Empty);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            frmProducts_Load(sender, EventArgs.Empty);
        }
    }
}
