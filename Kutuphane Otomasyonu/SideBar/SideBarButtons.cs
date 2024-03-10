using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu.SideBar
{
    public class SideBarButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color selectedColor;

        public SideBarButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = defaultColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach (Button button in buttons)
            {
                if (button == selectedButton)
                {
                    selectedButton.BackColor = selectedColor;
                }
                else
                {
                    button.BackColor = defaultColor;
                }
            }
        }

        public void ToggleExpand(Button button)
        {
            if (button.Text.Contains('˃'))
            {
                button.Text = button.Text.Replace('˃', '˅');
            }
            else if (button.Text.Contains('˅'))
            {
                button.Text = button.Text.Replace('˅', '˃');
            }
        }
    }
}
