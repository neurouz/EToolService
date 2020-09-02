using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;
using EToolService.Model.Requests;
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

namespace EToolService.Desktop.Forms.ToolService
{
    public partial class frmToolService : Form
    {
        private readonly APIService _service = new APIService("ToolService");
        private int _page = 1;
        public frmToolService()
        {
            InitializeComponent();
        }

        private void ClearPanel()
        {
            panel1.Controls.Clear();
        }

        public void Reload()
        {
            frmToolService_Load(this, EventArgs.Empty);
        }

        private async void frmToolService_Load(object sender, EventArgs e)
        {
            // loader1.Visible = true;
            

            var searchRequest = new ToolServiceSearchRequest()
            {
                Page = _page,
                ItemsPerPage = 3
            };

            var request = await _service.Get<List<EToolService.Model.Models.Services>>(searchRequest);

            if (_page > 1 && request.Count == 0)
            {
                _page--;
                return;
            }

            if (_page < 1)
            {
                _page = 1;
                return;
            }

            ClearPanel();

            for (int i = request.Count - 1; i >= 0; i--)
            {
                var card = new ToolServiceCard(request[i], this);
                card.Dock = DockStyle.Top;
                card.Show();
                panel1.Controls.Add(card);
            }

            lblPage.Text = _page.ToString();
           // loader1.Visible = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page == 1)
                return;
            _page--;
            frmToolService_Load(this, EventArgs.Empty);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _page++;
            frmToolService_Load(this, EventArgs.Empty);
        }
    }
}
