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

namespace EToolService.Desktop.UserControls
{
    public partial class ClientCard : UserControl
    {
        public ClientCard(Customer customer)
        {
            InitializeComponent();
            valAdresa.Text = customer.Address;
            valClientID.Text = customer.Id.ToString();
            valCompanyName.Text = customer.CompanyName;
            valDjelatnost.Text = customer.AreaName;
            valEmail.Text = customer.Account.Email;
            valPhoneNumber.Text = customer.Account.PhoneNumber;
            valUsername.Text = customer.Account.Username;
            valDatumRegistracije.Text = customer.Account.DateCreated.ToString("dd/MM/yyyy");
        }
    }
}
