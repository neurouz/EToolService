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
using EToolService.Desktop.Services;

namespace EToolService.Desktop.Forms.Employee
{
    public partial class frmEmployeeAdd : Form
    {
        private readonly APIService _apiService = new APIService("Employee");
        public frmEmployeeAdd()
        {
            InitializeComponent();
        }

        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            EmployeeInsertRequest request = new EmployeeInsertRequest
            {
                ContractSigned = null,
                FirstName = txtName.Text,
                LastName = txtSurname.Text,
                Salary = decimal.Parse(txtSalary.Text),
                Position = txtPosition.Text
            };

            var response = await _apiService.Insert<EToolService.Model.Models.Employee>(request);
            if (response != null)
            {
                MessageBox.Show("Uposlenik dodan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text)
                || String.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                errProviderEmployeeAdd.SetError(txtName, Messages.employee_name_empty);
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtSurname.Text)
                || String.IsNullOrWhiteSpace(txtSurname.Text))
            {
                e.Cancel = true;
                errProviderEmployeeAdd.SetError(txtSurname, Messages.employee_surname_empty);
            }
        }

        private void txtPosition_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPosition.Text)
                || String.IsNullOrWhiteSpace(txtPosition.Text))
            {
                e.Cancel = true;
                errProviderEmployeeAdd.SetError(txtPosition, Messages.employee_position_empty);
            }
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtSalary.Text)
                || String.IsNullOrWhiteSpace(txtSalary.Text))
            {
                e.Cancel = true;
                errProviderEmployeeAdd.SetError(txtSalary, Messages.employee_salary_empty);
            }

            try
            {
                decimal salary = decimal.Parse(txtSalary.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                errProviderEmployeeAdd.SetError(txtSalary, Messages.employee_salary_invalid);
            }
        }
    }
}
