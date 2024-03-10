using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane_Otomasyonu.Resources.Classes;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Kutuphane_Otomasyonu.SideBar;
using Kutuphane_Otomasyonu.Sayfalar;
using Kutuphane_Otomasyonu.Classes;

namespace Kutuphane_Otomasyonu.Forms
{
    public partial class AnaSayfa : Form
    {

        SideBarControl navigationControl;
        SideBarButtons navigationButtons;

        Color btnDefaultColor = Color.FromArgb(255, 50, 50, 50);
        Color btnSelectedtColor = Color.FromArgb(255, 34, 36, 38);

        private bool showPanel_Kitapİslemleri = false;
        private bool showPanel_Okuyucuİslemleri = false;

        public AnaSayfa()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
            TogglePanel();
        }

        dbConnection dbConnection = new dbConnection();

        int YetkiliID = UserInfo.userID;

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

            if(YetkiliID <= 0)
            {
                MessageBox.Show("Kullanıcı İD'si alınamadı güvenlik nedeniyle program kapatılacak, lütfen bir yöneticiye başvurun.", "Giriş Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (YetkiliID > 0)
            {
                SonGiris();
            }

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(lbl_Version, "Enes Yasin Divrengi tarafından geliştirildi, geliştirmeye açık bir yazılımdır. İyi kullanımlar 😊");

            BilgileriGoster();
        }

        private void TogglePanel()
        {
            //Kitap işlemleri kategorisi
            if (showPanel_Kitapİslemleri == true)
            {
                panel_Kitapİslemleri.Visible = true;
            }
            else
            {
                panel_Kitapİslemleri.Visible = false;
            }

            //Üye işlemleri kategorisi
            if (showPanel_Okuyucuİslemleri == true)
            {
                panel_Okuyucuİslemleri.Visible = true;
            }
            else
            {
                panel_Okuyucuİslemleri.Visible = false;
            }
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            //Sayfalar
            {new Dashboard(), new KitapEkle(), new KitapBilgiGirisi(), new OkuyucuEkle(), new Emanetİslemleri(), new Ayarlar(), new KutuphaneAyarlar() };

            navigationControl = new SideBarControl(userControls, sideBar_Panel);
            navigationControl.Display(0);
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            {btnAnaSayfa, btn_KitapEkle, btn_KitapBilgi, btn_OkuyucuEkle, btn_Emanetİslemleri, btn_KutuphaneAyarlar};

            navigationButtons = new SideBarButtons(buttons, btnDefaultColor, btnSelectedtColor);
            navigationButtons.Highlight(btnAnaSayfa);
        }

        public void BilgileriGoster()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand($"SELECT Ad, Soyad, KullaniciAdi FROM lib_yetkililer WHERE İD = {UserInfo.userID}", dbConnection.connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string adSoyad = $"{reader.GetString("Ad")} {reader.GetString("Soyad")}";
                    string nickName = reader.GetString("KullaniciAdi");
                    lblAdSoyad.Text = adSoyad;
                    lblNickName.Text = nickName;
                    pictProfile.ImageLocation = Helper.YetkiliProfilePath(YetkiliID);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        void SonGiris()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand($"INSERT INTO lib_songiris (YetkiliID, Tarih) VALUES (@YetkiliID, @Tarih)", dbConnection.connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@YetkiliID", UserInfo.userID);
                command.Parameters.AddWithValue("@Tarih", DateTime.Now);

                // Komutu çalıştır
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

        }

        //Kategori Buton İşlemleri
        private void btn_Kitapİslemleri_Click(object sender, EventArgs e)
        {
            showPanel_Kitapİslemleri = !showPanel_Kitapİslemleri;
            TogglePanel();
            navigationButtons.ToggleExpand(btn_Kitapİslemleri);
        }

        private void btn_Okuyucuİslemleri_Click(object sender, EventArgs e)
        {
            showPanel_Okuyucuİslemleri = !showPanel_Okuyucuİslemleri;
            TogglePanel();
            navigationButtons.ToggleExpand(btn_Okuyucuİslemleri);
        }

        //Kategori Açılır Buton İşlemleri
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(btnAnaSayfa);
        }

        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(btn_KitapEkle);
        }

        private void btn_KitapBilgi_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(btn_KitapBilgi);

        }

        private void btn_OkuyucuEkle_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(btn_OkuyucuEkle);
        }

        private void btn_Emanetİslemleri_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButtons.Highlight(btn_Emanetİslemleri);
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
            navigationButtons.Highlight(btn_YetkiliAyarlar);
        }

        private void btn_KutuphaneAyarlar_Click(object sender, EventArgs e)
        {
            navigationControl.Display(6);
            navigationButtons.Highlight(btn_KutuphaneAyarlar);
        }
    }
}