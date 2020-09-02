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
using EToolService.Desktop.Forms.Machine;

#pragma warning disable CS0108
namespace EToolService.Desktop.Forms.Employee
{
    public partial class frmEmployeeEdit : Form
    {
        private APIService _service = new APIService("Employee");
        private int _id;
        public frmEmployeeList ParentForm;

        public frmEmployeeEdit(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmEmployeeEdit_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<EToolService.Model.Models.Employee>(_id);
            txtContractDate.Value = result.ContractSigned;
            txtName.Text = result.FirstName;
            txtPosition.Text = result.Position;
            txtSalary.Text = result.Salary.ToString();
            txtSurname.Text = result.LastName;
            if ((bool)result.Active)
                chkActive.Checked = true;
            else
                chkActive.Checked = false;
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Podaci nisu ispravni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chkActive.Checked)
                if (MessageBox.Show(
                        Messages.delete_warning, "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var request = new EmployeeUpdateRequest()
            {
                Active = chkActive.Checked,
                ContractSigned = txtContractDate.Value,
                LastName = txtSurname.Text,
                FirstName = txtName.Text,
                Position = txtPosition.Text,
                Salary = decimal.Parse(txtSalary.Text)
            };

            var result = await _service.Update<EToolService.Model.Models.Employee>(_id, request);
            MessageBox.Show("Uspješno ste promijenili podatke za uposlenika.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ParentForm.LoadForm();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text)
                || String.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                employeeEditErrorPovider.SetError(txtName, Messages.employee_name_empty);
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSurname.Text)
                || String.IsNullOrWhiteSpace(txtSurname.Text))
            {
                e.Cancel = true;
                employeeEditErrorPovider.SetError(txtSurname, Messages.employee_surname_empty);
            }
        }

        private void txtPosition_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPosition.Text)
                || String.IsNullOrWhiteSpace(txtPosition.Text))
            {
                e.Cancel = true;
                employeeEditErrorPovider.SetError(txtPosition, Messages.employee_position_empty);
            }
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSalary.Text)
                || String.IsNullOrWhiteSpace(txtSalary.Text))
            {
                e.Cancel = true;
                employeeEditErrorPovider.SetError(txtSalary, Messages.employee_salary_empty);
            }

            try
            {
                decimal salary = decimal.Parse(txtSalary.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                employeeEditErrorPovider.SetError(txtSalary, Messages.employee_salary_invalid);
            }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            var machineForm = new frmAssignMachine(_id);
            machineForm.Show();
        }
    }
}
