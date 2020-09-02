using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Models;

namespace EToolService.Desktop.UserControls
{
    public partial class BoxDimensions : UserControl, IDimensions
    {
        public BoxDimensions()
        {
            InitializeComponent();
        }
        public decimal GetLength()
        {
            try
            {
                return decimal.Parse(txtDuzina.Text);
            }
            catch (Exception)
            {
                throw new Exception("Dužina nije validna");
            }
        }
        public decimal GetWidth()
        {
            try
            {
                return decimal.Parse(txtSirina.Text);
            }
            catch (Exception)
            {
                throw new Exception("Širina nije validna");
            }
        }
        public decimal GetThickness()
        {
            try
            {
                return decimal.Parse(txtDebljina.Text);
            }
            catch (Exception)
            {
                throw new Exception("Debljina nije validna");
            }
        }
        public Dimension GetDimensions()
        {
            try
            {
                return new Dimension()
                {
                    Debljina = GetThickness(),
                    Sirina = GetWidth(),
                    Duzina = GetLength()
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
