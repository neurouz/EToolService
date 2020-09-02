using EToolService.Model.Requests;
using EToolService.Desktop.Services;
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

namespace EToolService.Desktop.Forms.Request
{
    public partial class frmRequestsDetail : Form
    {
        private APIService _service = new APIService("Requests");
        private int _page = 1;
        public frmRequestsDetail()
        {
            InitializeComponent();
        }

        private void ClearPanel()
        {
            pnlRequests.Controls.Clear();
        }

        public void LoadForm()
        {
            frmRequestsDetail_Load(this, null);
        }

        private async void frmRequestsDetail_Load(object sender, EventArgs e)
        {
            var searchRequest = new RequestSearchRequest()
            {
                Page = _page,
                ItemsPerPage = 4
            };

            var request = await _service.Get<List<EToolService.Model.Models.Request>>(searchRequest);

            if (request == null)
                return;

            if (request.Count == 0)
            {
                _page--;
                return;
            }

            ClearPanel();

            for (int i = 0; i < request.Count; i++)
            {
                var employeeId = request[i].EmployeeId;
                var employee = await new APIService("Employee").GetById<EToolService.Model.Models.Employee>(employeeId);
                var control = new RequestDetail(request[i], $"{employee.FirstName} {employee.LastName}") { ParentForm = this };
                control.Dock = DockStyle.Top;
                control.Show();
                pnlRequests.Controls.Add(control);
            }

            lblPageCounter.Text = _page.ToString();
            pnlRequests.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page == 1)
                return;
            --_page;
            frmRequestsDetail_Load(sender,e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++_page;
            frmRequestsDetail_Load(sender, e);
        }
    }
}
