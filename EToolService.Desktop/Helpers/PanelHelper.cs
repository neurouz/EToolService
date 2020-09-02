using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EToolService.Desktop.Helpers
{
    public class PanelHelper
    {
        // Insert new control into panel
        public static void SwapContent(Panel panel, Control newControl)
        {
            panel.Controls.Clear();
            newControl.Show();
            panel.Controls.Add(newControl);
            panel.Show();
        }

        // Insert new form into control
        public static void SwapPanel(Control panel, Form form, DockStyle dockStyle = DockStyle.Fill)
        {
            form.TopLevel = false;
            form.Dock = dockStyle;
            panel.Controls.Clear();
            form.Show();
            panel.Controls.Add(form);
        }

        public static void ShowHidePanels(bool isVisible, params Panel[] panels)
        {
            foreach (var panel in panels)
            {
                panel.Visible = isVisible;
            }
        }
    }
}
