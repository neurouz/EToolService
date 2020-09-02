using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Helpers;
using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;
using EToolService.Model.Requests;

namespace EToolService.Desktop.Forms.Order
{
    public partial class frmOrders : Form
    {
        private readonly APIService _service = new APIService("Order");
        private int Page = 1;
        private int Filter = 1;
        public frmOrders()
        {
            InitializeComponent();
            List<KeyValuePair<int, string>> items = new List<KeyValuePair<int, string>>();

            items.Add(new KeyValuePair<int, string>(1, "Sve narudžbe"));
            items.Add(new KeyValuePair<int, string>(2, "Samo aktivne"));
            items.Add(new KeyValuePair<int, string>(3, "Samo završene"));

            comboFilter.DataSource = items;
            comboFilter.ValueMember = "key";
            comboFilter.DisplayMember = "value";
        }

        private void ClearPanel()
        {
            pnlOrders.Controls.Clear();
        }

        private async void frmOrders_Load(object sender, EventArgs e)
        {
            loader1.Visible = true;
            var SearchRequest = new OrderSearchRequest()
            {
                Filter = Filter,
                Page = Page,
                ItemsPerPage = 6
            };

            var request = await _service.Get<List<EToolService.Model.Models.Order>>(SearchRequest);

            if(Page > 1 && request.Count == 0)
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

            for(int i = request.Count - 1; i >= 0; i--)
            {
                var card = new OrderCard(request[i]) { Parent = this };
                card.Dock = DockStyle.Top;
                card.Show();
                pnlOrders.Controls.Add(card);
            }

            loader1.Visible = false;
        }

        public void Reload()
        {
            frmOrders_Load(this, EventArgs.Empty);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Page == 1)
                return;
            Page--;
            frmOrders_Load(this, EventArgs.Empty);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            frmOrders_Load(this, EventArgs.Empty);
        }

        private void comboFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Page = 1;
            Filter = int.Parse(comboFilter.SelectedValue.ToString());
            frmOrders_Load(sender, e);
        }
    }
}
