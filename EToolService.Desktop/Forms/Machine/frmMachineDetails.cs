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

namespace EToolService.Desktop.Forms.Machine
{
    public partial class frmMachineDetails : Form
    {
        private ICollection<EToolService.Model.Models.Machine> _machines;
        private string _employeeName;
        public frmMachineDetails(ICollection<EToolService.Model.Models.Machine> machines
            , string employeeName)
        {
            InitializeComponent();
            _machines = machines;
            _employeeName = employeeName;
        }

        private void frmMachineDetails_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Prikaz mašina za radnika {_employeeName}";
            int count = _machines.Count;
            foreach(var machine in _machines)
            {
                var control = new MachineDetails(machine, count--);
                control.Dock = DockStyle.Top;
                pnlMachines.Controls.Add(control);
                control.Show();
            }
            pnlMachines.Show();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
