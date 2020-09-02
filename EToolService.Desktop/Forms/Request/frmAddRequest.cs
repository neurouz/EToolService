using EToolService.Model.Requests;
using EToolService.Desktop.Services;
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
    public partial class frmAddRequest : Form
    {
        private APIService _requestService = new APIService("Requests");
        private APIService _employeeService = new APIService("Employee");
        public frmAddRequest()
        {
            InitializeComponent();
        }

        private async void frmAddRequest_Load(object sender, EventArgs e)
        {
            var employees = await _employeeService.Get<List<EToolService.Model.Models.Employee>>(null);
            comboEmployee.DataSource = employees;
            comboEmployee.ValueMember = "Id";
            comboEmployee.DisplayMember = "FullName";
        }

        private void comboEmployee_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(comboEmployee.Text))
            {
                e.Cancel = true;
                errProviderRequestAdd.SetError(comboEmployee, Messages.employee_not_chosen);
            }
            try
            {
                var id = int.Parse(comboEmployee.SelectedValue.ToString());
            }
            catch(Exception)
            {
                e.Cancel = true;
                errProviderRequestAdd.SetError(comboEmployee, Messages.invalid_value);
            }
        }

        private void txtPurpose_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPurpose.Text))
            {
                e.Cancel = true;
                errProviderRequestAdd.SetError(txtPurpose, Messages.entry_is_required);
            }
        }

        private async void btnAddRequest_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var request = new RequestInsertRequest
            {
                EmployeeId = int.Parse(comboEmployee.SelectedValue.ToString()),
                Description = txtDescription.Text,
                Purpose = txtPurpose.Text
            };

            var response = await _requestService.Insert<EToolService.Model.Models.Request>(request);
            MessageBox.Show("Zahtjev uspješno evidentiran", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
