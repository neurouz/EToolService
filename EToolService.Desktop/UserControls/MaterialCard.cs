using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Forms.Material;
using EToolService.Desktop.Services;

namespace EToolService.Desktop.UserControls
{
    public partial class MaterialCard : UserControl
    {
        private readonly APIService _service = new APIService("Material");
        private int _materialId;
        private frmMaterialShow _parentForm;
        public MaterialCard(EToolService.Model.Models.Material material, frmMaterialShow parent)
        {
            InitializeComponent();
            _materialId = material.Id;
            _parentForm = parent;

            lblDimenzije.Text = material.GetDimensions();
            lblHardness.Text = material.Hardness.ToString() + "HRC";
            lblQuality.Text = material.Quality;
            lblQuantity.Text = material.Quantity.ToString();

            if (material.MaterialTypeId == 1)
                lblMaterialType.Text = "Čelik";
            if (material.MaterialTypeId == 2)
                lblMaterialType.Text = "Aluminijum";
            if (material.MaterialTypeId == 3)
                lblMaterialType.Text = "Šipkasti materijal";

            if (material.Available)
            {
                picAvailable.Visible = true;
                tooltip.SetToolTip(picAvailable, "Materijal je dostupan");
            }
            else
            {
                picNotAvailable.Visible = true;
                pictureBox1.Visible = false;
                tooltip.SetToolTip(picNotAvailable, "Materijal je potrošen");
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = await _service.Patch<EToolService.Model.Models.Material>(_materialId, null);
            if (result != null)
            {
                MessageBox.Show("Uspješno evidentirano", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm.ReloadForm();
            }
        }

    }
}
