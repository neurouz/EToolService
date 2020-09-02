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
    public partial class ProductDetails : UserControl
    {
        public ProductDetails(int quantity, EToolService.Model.Models.Product product)
        {
            InitializeComponent();
            valCijena.Text = product.Price.ToString("N") + "KM";
            valKolicina.Text = quantity.ToString();
            valNaziv.Text = product.ProductName;
            valUkupno.Text = ((product.Price * (1 - product.Discount)) * quantity).ToString("N") + "KM";
        }
    }
}
