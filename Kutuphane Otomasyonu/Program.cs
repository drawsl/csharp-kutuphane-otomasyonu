using Kutuphane_Otomasyonu.Forms;
using Kutuphane_Otomasyonu.Resources.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dbConnection connection = new dbConnection();

            //Application.Run(new AnaSayfa());

            if (connection.ExecuteQuery("SELECT * FROM lib_yetkililer WHERE aktif = 1").Rows.Count > 0)
            {
                Application.Run(new SplashScreen());
            }
            else
            {
                Application.Run(new Register_Panel());
            }
        }
    }
}

