using Kutuphane_Otomasyonu.Forms;
using Kutuphane_Otomasyonu.Resources.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        Login_Panel login_page = new Login_Panel();
        private void TimeRunning_Tick(object sender, EventArgs e)
        {
            PanelLoadRunning.Width += 2;
            if (PanelLoadRunning.Width >= 700)
            {
                login_page.Show();
                this.Hide();
                TimeRunning.Stop();
            }
        }
    }
}
