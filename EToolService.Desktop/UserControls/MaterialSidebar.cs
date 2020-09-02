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
using EToolService.Desktop.Helpers;
using EToolService.Model.Enumerations;

namespace EToolService.Desktop.UserControls
{
    public partial class MaterialSidebar : UserControl
    {
        public MaterialSidebar()
        {
            InitializeComponent();
        }

        private Control GetPanel()
        {
            return Parent.Parent.Controls.Find("mainPanel", false).First();
        }

        private void RevertColors()
        {
            ButtonHelper.RevertColors(btnDostupniMaterijal, btnPotroseniMaterijal, btnNoviMaterijal);
        }

        private void btnDostupniMaterijal_Click(object sender, EventArgs e)
        {
            var panel = GetPanel();
            RevertColors();
            ButtonHelper.SetClickedBackground(btnDostupniMaterijal, Color.GhostWhite);
            PanelHelper.SwapPanel(panel, new frmMaterialShow(MaterialTypes.All, true));
        }

        private void btnSipkastiMaterijal_Click(object sender, EventArgs e)
        {
            var panel = GetPanel();
            PanelHelper.SwapPanel(panel, new frmMaterialShow(MaterialTypes.BarMaterial, true));
        }

        private void btnAluminijum_Click(object sender, EventArgs e)
        {
            var panel = GetPanel();
            PanelHelper.SwapPanel(panel, new frmMaterialShow(MaterialTypes.Aluminum, true));
        }

        private void btnCelik_Click(object sender, EventArgs e)
        {
            var panel = GetPanel();
            PanelHelper.SwapPanel(panel, new frmMaterialShow(MaterialTypes.Steel, true));
        }

        private void btnPotroseniMaterijal_Click(object sender, EventArgs e)
        {
            var panel = GetPanel();
            RevertColors();
            ButtonHelper.SetClickedBackground(btnPotroseniMaterijal, Color.GhostWhite);
            PanelHelper.SwapPanel(panel, new frmMaterialShow(MaterialTypes.All, false));
        }

        private void btnNoviMaterijal_Click(object sender, EventArgs e)
        {
            var panel = GetPanel();
            RevertColors();
            ButtonHelper.SetClickedBackground(btnNoviMaterijal, Color.GhostWhite);
            PanelHelper.SwapPanel(panel, new frmAddMaterial());
        }
    }
}