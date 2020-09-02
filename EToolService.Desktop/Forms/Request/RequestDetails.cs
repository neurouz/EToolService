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
    public partial class RequestDetails : Form
    {
        private EToolService.Model.Models.Request _request;
        private string _employeeName;
        public RequestDetails(EToolService.Model.Models.Request request, string employeeName) 
        {
            InitializeComponent();
            _request = request;
            _employeeName = employeeName;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestDetails_Load(object sender, EventArgs e)
        {
            valDate.Text = _request.DateCreated.ToString("dd/MM/yyyy");
            valDescription.Text = _request.Description;
            valEmployee.Text = _employeeName;
            valID.Text = _request.Id.ToString();
            valPurpose.Text = _request.Purpose;

            if(_request.Phase == 1)
            {
                valPhase.Text = "Odobren";
                valPhase.ForeColor = Color.DarkGreen;
            }
            else if (_request.Phase == 2)
            {
                valPhase.Text = "Odbijen";
                valPhase.ForeColor = Color.DarkRed;
            }
            else
            {
                valPhase.Text = "U razmatranju";
                valPhase.ForeColor = Color.DarkGray;
            }
            this.Show();
        }
    }
}
