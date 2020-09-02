using EToolService.Desktop.Services;
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
using EToolService.Desktop.UserControls;
using XanderUI;

namespace EToolService.Desktop.Forms.ToolService
{
    public partial class frmServiceResponse : Form
    {
        private readonly APIService _service = new APIService("ToolService");
        private int _serviceID;
        public ToolServiceCard Card; 
        public frmServiceResponse(int serviceID)
        {
            InitializeComponent();
            _serviceID = serviceID;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateAll()
        {
            if (String.IsNullOrEmpty(txtPrice.Text)
                || String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                return false;
            }

            try
            {
                decimal salary = decimal.Parse(txtPrice.Text);
            }
            catch (Exception)
            {
                return false;
            }

            if(txtDateTime.Value < DateTime.Now)
            {
                MessageBox.Show("Datum ne može biti manji od današnjeg dana", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                                             
            return true;
        }

        private async void btnRespond_Click(object sender, EventArgs e)
        {
            if (ValidateAll())
            {
                var request = new ServiceResponseInsertRequest()
                {
                    Approved = chkApproved.Checked,
                    Explanation = txtExplanation.Text,
                    FinishDate = txtDateTime.Value.ToString("yyyy MMMM dd"),
                    Price = decimal.Parse(txtPrice.Text),
                    ServiceId = _serviceID
                };

                try
                {
                    var result = await _service.Insert<EToolService.Model.Models.ServiceResponse>(request);

                    MessageBox.Show("Odgovor poslan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Card.DisableButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dogodila se greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Podaci nisu ispravni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
