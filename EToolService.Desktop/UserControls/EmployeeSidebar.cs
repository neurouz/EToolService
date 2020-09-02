using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EToolService.Desktop.Forms.Employee;
using EToolService.Desktop.Forms.Request;
using EToolService.Desktop.Helpers;

namespace EToolService.Desktop.UserControls
{
    public partial class EmployeeSidebar : UserControl
    {
        public EmployeeSidebar()
        {
            InitializeComponent();
        }

        private Control GetPanel()
        {
            return Parent.Parent.Controls.Find("mainPanel", false).First();
        }
        private void RevertButtonColors()
        {
            ButtonHelper.RevertColors(btnListaUposlenika, btnNoviUposlenik, btnNoviZahtjev, btnPregledZahtjeva);
        }

        private void SetClickedColor(XanderUI.XUIButton button)
        {
            button.BackgroundColor = Color.GhostWhite;
        }

        private void btnListaUposlenika_Click(object sender, EventArgs e)
        {
            RevertButtonColors();
            ButtonHelper.SetClickedBackground(btnListaUposlenika, Color.GhostWhite);

            var panel = GetPanel();
            PanelHelper.SwapPanel(panel, new frmEmployeeList());
        }

        private void btnNoviUposlenik_Click(object sender, EventArgs e)
        {
            RevertButtonColors();
            ButtonHelper.SetClickedBackground(btnNoviUposlenik, Color.GhostWhite);

            var panel = GetPanel();
            PanelHelper.SwapPanel(panel, new frmEmployeeAdd());
        }

        private void btnPregledZahtjeva_Click(object sender, EventArgs e)
        {
            RevertButtonColors();
            ButtonHelper.SetClickedBackground(btnPregledZahtjeva, Color.GhostWhite);

            var panel = GetPanel();
            PanelHelper.SwapPanel(panel, new frmRequestsDetail());
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            RevertButtonColors();
            ButtonHelper.SetClickedBackground(btnNoviZahtjev, Color.GhostWhite);

            var panel = GetPanel();
            PanelHelper.SwapPanel(panel, new frmAddRequest());
        }
    }
}
