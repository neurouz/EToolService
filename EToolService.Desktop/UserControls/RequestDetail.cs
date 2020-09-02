using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Model.Models;
using EToolService.Desktop.Services;
using EToolService.Desktop.Forms.Request;
using EToolService.Model.Enumerations;


namespace EToolService.Desktop.UserControls
{
    public partial class RequestDetail : UserControl
    {
        private APIService _service = new APIService("Requests");
        private Request _request;
        private string _employeeName;
        public frmRequestsDetail ParentForm;
        public RequestDetail(Request request, string employeeName)
        {
            InitializeComponent();
            _request = request;
            _employeeName = employeeName;
            lblEmployeeName.Text = employeeName;
            lblPurpose.Text = request.Purpose;
            if(_request.Phase == 1 || _request.Phase == 2)
            {
                btnOdbij.Enabled = false;
                btnOdobri.Enabled = false;
                btnDetails.FlatStyle = FlatStyle.Flat;
                btnOdobri.BackColor = btnOdbij.BackColor = Color.Gray;
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var newPanel = new RequestDetails(_request, _employeeName);
            newPanel.Show();
        }

        private async void btnOdobri_Click(object sender, EventArgs e)
        {
            var request = await _service.Patch<EToolService.Model.Models.Request>(_request.Id, RequestPhases.Approved);
            MessageBox.Show("Zahtjev odobren", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParentForm.LoadForm();
        }

        private async void btnOdbij_Click(object sender, EventArgs e)
        {
            var request = await _service.Patch<EToolService.Model.Models.Request>(_request.Id, RequestPhases.Denied);
            MessageBox.Show("Zahtjev odbijen", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParentForm.LoadForm();
        }
    }
}
