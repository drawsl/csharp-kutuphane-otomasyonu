using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu.SideBar
{
    public class SideBarControl
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel panel;

        public SideBarControl(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                userControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControlList[i]);

            }
        }

        public void Display(int index)
        {
            if (index < userControlList.Count())
            {
                userControlList[index].BringToFront();
            }
        }
    }
}
