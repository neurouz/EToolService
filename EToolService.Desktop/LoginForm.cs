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
using EToolService.Model.Requests;
using System.Diagnostics;

namespace EToolService.Desktop
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service;
        public frmLogin()
        {
            InitializeComponent();
            _service = new APIService("Account");
            loader1.Visible = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            loader1.Visible = true;

            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var request = new AuthenticateRequest()
                {
                    Username = APIService.Username,
                    Password = APIService.Password
                };

                var response = await _service.Authenticate(request);
                if (response == null)
                    throw new Exception();

                frmIndex frm = new frmIndex();
                frm.Show();
                loader1.Visible = false;
                frm.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                Hide();
            }
            catch (Exception)
            {
                loader1.Visible = false;
                MessageBox.Show("Podaci nisu ispravni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private async void btnLogin_Enter(object sender, EventArgs e)
        {
            await Task.Run(() => btnLogin_Click(sender, e));
        }
    }
}
