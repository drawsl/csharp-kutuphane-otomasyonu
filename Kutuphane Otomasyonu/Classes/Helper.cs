using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu.Classes
{
    class Helper
    {
        public static string OkuyucuProfilePath(int OkuyucuID)
        {
            string path = System.Windows.Forms.Application.StartupPath + "/profiles/" + OkuyucuID + ".jpg";

            if(File.Exists(path)) 
            { 
                return path;
            }

            return System.Windows.Forms.Application.StartupPath + "/profiles/user.png";
        }

        public static string YetkiliProfilePath(int YetkiliID)
        {
            string path = System.Windows.Forms.Application.StartupPath + "/profile_yetkili/" + YetkiliID + ".jpg";

            if (File.Exists(path))
            {
                return path;
            }

            return System.Windows.Forms.Application.StartupPath + "/profile_yetkili/admin.png";
        }
    }
}
