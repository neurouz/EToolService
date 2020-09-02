using EToolService.Desktop.Forms.Machine;
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

namespace EToolService.Desktop.Forms.Employee
{
    public partial class frmEmployeeDetails : Form
    {
        private readonly int id;
        private readonly APIService _service = new APIService("Employee");
        public frmEmployeeDetails(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            var request = await _service.GetById<EToolService.Model.Models.Employee>(id);

            valID.Text = request.Id.ToString();
            valActive.Text = (bool)request.Active ? "DA" : "NE";
            valName.Text = request.FirstName;
            valSurname.Text = request.LastName;
            valSalary.Text = (Math.Round(request.Salary, 2)).ToString() + "KM";
            valRequestNumber.Text = request.Requests.Count.ToString();
            valPosition.Text = request.Position;
            valContractDate.Text = request.ContractSigned.ToString("dd/MM/yyyy");
            if(request.Machines.Count == 0)
            {
                lstMachines.Nodes.Add("Nema zaduženih mašina");
                lstMachines.ForeColor = Color.Crimson;
                btnMachineDetails.Visible = false;
            }
            foreach(var machine in request.Machines)
            {
                lstMachines.Nodes.Add(machine.MachineName);
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            var mainPanel = Parent.Parent.Controls.Find("mainPanel", false).First();
            mainPanel.Controls.Clear();
            var employeeListForm = new frmEmployeeList
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            employeeListForm.Show();
            mainPanel.Controls.Add(employeeListForm);
        }

        private async void btnMachineDetails_Click(object sender, EventArgs e)
        {
            var request = await _service.GetById<EToolService.Model.Models.Employee>(id);
            var machinePanel = new frmMachineDetails(
                request.Machines, $"{request.FirstName} {request.LastName}");
            machinePanel.Show();
        }
    }
}
