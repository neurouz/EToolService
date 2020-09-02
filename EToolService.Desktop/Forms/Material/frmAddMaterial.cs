using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Helpers;
using EToolService.Desktop.Models;
using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;
using EToolService.Model.Enumerations;
using EToolService.Model.Requests;
using Flurl.Util;
using Newtonsoft.Json;

namespace EToolService.Desktop.Forms.Material
{
    public partial class frmAddMaterial : Form
    {
        private class Type
        {
            public int key { get; set; }
            public string value { get; set; }
            public Type(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private IDimensions _dimensions;
        private readonly APIService _service = new APIService("Material");
        public frmAddMaterial()
        {
            InitializeComponent();
            List<Type> typeList = new List<Type>();

            typeList.Add(new Type((int)MaterialTypes.BarMaterial, "Šipkasti materijal"));
            typeList.Add(new Type((int)MaterialTypes.Aluminum, "Aluminijum"));
            typeList.Add(new Type((int)MaterialTypes.Steel, "Čelik"));

            comboTipMaterijala.DataSource = typeList;
            comboTipMaterijala.ValueMember = "key";
            comboTipMaterijala.DisplayMember = "value";
        }

        private MaterialTypes GetCurrentType()
        {
            if (comboTipMaterijala.SelectedValue.ToString() == ((int) MaterialTypes.BarMaterial).ToString())
                return MaterialTypes.BarMaterial;
            if (comboTipMaterijala.SelectedValue.ToString() == ((int)MaterialTypes.Aluminum).ToString())
                return MaterialTypes.Aluminum;
            if (comboTipMaterijala.SelectedValue.ToString() == ((int)MaterialTypes.Steel).ToString())
                return MaterialTypes.Steel;

            return MaterialTypes.All;
        }

        private List<string> GetQualityData()
        {
            List<string> data = new List<string>();
            if (GetCurrentType() == MaterialTypes.Aluminum)
            {
                data.Add("AL");
            }

            if (GetCurrentType() == MaterialTypes.BarMaterial)
            {
                data.Add("HM");
                data.Add("HSS");
            }

            if (GetCurrentType() == MaterialTypes.Steel)
            {
                data.Add("Č.0371");
                data.Add("Č.0377");
                data.Add("Č.0773");
            }

            return data;
        }

        private void frmAddMaterial_Load(object sender, EventArgs e)
        {
            if (GetCurrentType() == MaterialTypes.BarMaterial)
            {
                var barDimensions = new BarDimensions(){ Dock = DockStyle.Fill };
                PanelHelper.SwapContent(pnlDimenzije, barDimensions);
                _dimensions = barDimensions;
            }
            else
            {
                var boxDimensions = new BoxDimensions() { Dock = DockStyle.Fill };
                PanelHelper.SwapContent(pnlDimenzije, boxDimensions);
                _dimensions = boxDimensions;
            }

            comboKvalitet.DataSource = GetQualityData();
        }
        private void comboTipMaterijala_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmAddMaterial_Load(this, EventArgs.Empty);
        }

        private bool ValidateData()
        {
            try
            {
                var tvrdoca = int.Parse(txtTvrdoca.Text);
                int.Parse(txtKolicina.Text);
                if (tvrdoca < 0 || tvrdoca > 100)
                    throw new Exception("Tvrdoca mora biti izmedju 0-100");
            }
            catch (Exception e)
            {
                MessageBox.Show("Podaci nisu validni: " + e.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        
        private async void btnDodajMaterijal_Click(object sender, EventArgs e)
        {
            var dimensions = _dimensions.GetDimensions();

            if (dimensions == null || !ValidateData()) 
                return;

            var request = new MaterialInsertRequest
            {
                Width = dimensions.Sirina,
                Thickness = dimensions.Debljina,
                Diameter = dimensions.Precnik,
                Length = dimensions.Duzina,
                Quality = comboKvalitet.SelectedValue.ToString(),
                Quantity = int.Parse(txtKolicina.Text),
                Hardness = int.Parse(txtTvrdoca.Text),
                MaterialTypeId = (int)comboTipMaterijala.SelectedValue
            };

            await _service.Insert<EToolService.Model.Models.Material>(request);
            MessageBox.Show("Materijal uspješno evidentiran", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
