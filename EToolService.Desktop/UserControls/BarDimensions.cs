using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using EToolService.Desktop.Models;

namespace EToolService.Desktop.UserControls
{
    public partial class BarDimensions : UserControl, IDimensions
    {
        public BarDimensions()
        {
            InitializeComponent();
        }

        public decimal GetDiameter()
        {
            try
            {
                return decimal.Parse(txtPrecnik.Text);
            }
            catch (Exception)
            {
                throw new Exception("Prečnik nije validan");
            }
        }
        public decimal GetLength()
        {
            try
            {
                return decimal.Parse(txtDuzina.Text);
            }
            catch (Exception)
            {
                throw new Exception("Duzina nije validna");
            }
        }
        public Dimension GetDimensions()
        {
            try
            {
                return new Dimension()
                {
                    Precnik = GetDiameter(),
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
