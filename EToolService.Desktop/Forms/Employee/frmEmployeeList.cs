using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Properties;
using EToolService.Desktop.Services;
using EToolService.Model.Models;
using Flurl.Util;
using Newtonsoft.Json;
using EToolService.Model.Requests;

namespace EToolService.Desktop.Forms.Employee
{
    public partial class frmEmployeeList : Form
    {
        private readonly APIService _service = new APIService("Employee");
        private int _page = 1;
        public frmEmployeeList()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            frmEmployeeList_Load(this, null);
        }
        private async void frmEmployeeList_Load(object sender, EventArgs e)
        {
            var ime = txtName.Text;
            var prezime = txtSurname.Text;

            EmployeeSearchRequest searchRequest = new EmployeeSearchRequest
            {
                FirstName = ime, 
                LastName = prezime,
                Page = _page,
                ItemsPerPage = 5
            };
            
            var request = await _service.Get<List<EToolService.Model.Models.Employee>>(searchRequest);
            
            if (request == null)
                return;

            if (request.Count == 0)
            {
                _page--;
                return;
            }
            var json = JsonConvert
                .DeserializeObject<List<EToolService.Model.Models.Employee>>(JsonConvert.SerializeObject(request));
            dgvEmployees.DataSource = json;
            dgvEmployees.Columns["FullName"].Visible = false;
            foreach (DataGridViewRow dgvEmployeesRow in dgvEmployees.Rows)
            {
                dgvEmployeesRow.Height = 30;
            }

            lblPageCounter.Text = _page.ToString();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("x", "y", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _page = 1;
            frmEmployeeList_Load(sender, e);
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            _page = 1;
            frmEmployeeList_Load(sender, e);
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var panel = Parent.Parent.Controls.Find("mainPanel", false).First();
            panel.Controls.Clear();
            int index = int.Parse(dgvEmployees["ID", e.RowIndex].Value.ToString());

            var detailsPanel = new frmEmployeeDetails(index)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };

            detailsPanel.Show();
            panel.Controls.Add(detailsPanel);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page == 1)
                return;
            --_page;
            frmEmployeeList_Load(sender,e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++_page;
            frmEmployeeList_Load(sender, e);
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployees.Columns["btnUredi"].Index && e.RowIndex >= 0)
            {
                int index = int.Parse(dgvEmployees["ID", e.RowIndex].Value.ToString());
                var editPanel = new frmEmployeeEdit(index)
                {
                    ParentForm = this
                };
                editPanel.Show();
            }
        }
    }
}
