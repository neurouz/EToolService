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
using EToolService.Model.Requests;

namespace EToolService.Desktop.Forms.Machine
{
    public partial class frmAssignMachine : Form
    {
        private APIService _employeeService = new APIService("Employee");
        private APIService _machineService = new APIService("Machine");
        private int _employeeId;
        public frmAssignMachine(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }

        private async void frmAssignMachine_Load(object sender, EventArgs e)
        {
            var data = await _machineService.Get<List<EToolService.Model.Models.Machine>>(null);
            var employee = await _employeeService.GetById<EToolService.Model.Models.Employee>(_employeeId);
            List<EToolService.Model.Models.Machine> availableMachines = new List<EToolService.Model.Models.Machine>();
            availableMachines.AddRange(data);
            // Avoid assigning same machines to one employee
            foreach (var machine in data)
            {
                foreach (var x in employee.Machines)
                {
                    if (machine.Id == x.Id)
                        availableMachines.Remove(machine);
                }
            }

            comboMachines.DataSource = availableMachines;
            comboMachines.ValueMember = "Id";
            comboMachines.DisplayMember = "MachineName";
        }

        private async void btnAddMachine_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboMachines.Text))
            {
                MessageBox.Show("Niste odabrali mašinu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var newMachineId = int.Parse(comboMachines.SelectedValue.ToString());
            var request = new MachineAssignRequest() { machineId = newMachineId };
            var response = await _employeeService.Patch<EToolService.Model.Models.Employee>(_employeeId, request);
            MessageBox.Show("Mašina dodana", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAssignMachine_Load(this, null);
        }
    }
}
