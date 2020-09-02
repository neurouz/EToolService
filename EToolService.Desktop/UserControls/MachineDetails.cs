using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EToolService.Desktop.UserControls
{
    public partial class MachineDetails : UserControl
    {
        public MachineDetails(EToolService.Model.Models.Machine machine, int current)
        {
            InitializeComponent();
            lblMachineName.Text = $"{current.ToString()}. {machine.MachineName}";
            lblDescription.Text = $"Opis: {machine.MachineDescription}";
            lblPurpose.Text = $"Namjena: {machine.Purpose}";
            lblType.Text = $"Tip mašine: {machine.Type}";
        }
    }
}
