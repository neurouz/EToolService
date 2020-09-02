using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XanderUI;

namespace EToolService.Desktop.Helpers
{
    public class ButtonHelper
    {
        public static void RevertColors(params XUIButton[] buttons)
        {
            foreach (var button in buttons)
            {
                button.BackgroundColor = Color.Transparent;
                button.TextColor = Color.DarkSlateGray;
            }
        }

        public static void SetClickedBackground(XUIButton button, Color color)
        {
            button.BackgroundColor = color;
        }
    }
}
