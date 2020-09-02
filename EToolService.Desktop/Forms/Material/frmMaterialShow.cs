using EToolService.Desktop.Services;
using EToolService.Desktop.UserControls;
using EToolService.Model.Enumerations;
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

namespace EToolService.Desktop.Forms.Material
{
    public partial class frmMaterialShow : Form
    {
        private MaterialTypes _type;
        private bool _isAvailable;
        private APIService _service = new APIService("Material");
        public frmMaterialShow(MaterialTypes type, bool available)
        {
            InitializeComponent();
            _type = type;
            _isAvailable = available;
        }

        private async void frmMaterialShow_Load(object sender, EventArgs e)
        {
            var searchRequest = new MaterialSearchRequest() { type = _type, isAvailable = _isAvailable };
            var materials = await _service.Get<List<EToolService.Model.Models.Material>>(searchRequest);
            foreach(var material in materials)
            {
                var detailsPanel = new MaterialCard(material, this);
                detailsPanel.Dock = DockStyle.Top;
                detailsPanel.Show();
                pnlMaterials.Controls.Add(detailsPanel);
            }
            pnlMaterials.Show();
        }

        public void ReloadForm()
        {
            pnlMaterials.Controls.Clear();
            frmMaterialShow_Load(this, EventArgs.Empty);
        }
    }
}
