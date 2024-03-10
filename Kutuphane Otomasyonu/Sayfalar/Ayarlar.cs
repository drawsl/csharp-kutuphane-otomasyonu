using Kutuphane_Otomasyonu.Classes;
using Kutuphane_Otomasyonu.Forms;
using Kutuphane_Otomasyonu.Resources.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu.Sayfalar
{
    public partial class Ayarlar : UserControl
    {

        public Ayarlar()
        {
            InitializeComponent();
        }

        dbConnection dbConnection = new dbConnection();
        ToolTip toolTip = new ToolTip();

        int yetkiliID = UserInfo.userID;
        string YetkiliPicture = "";
        string md5MevcutSifre = "";
        bool btnSifreKontrolChecked = false;

        private void pictProfile_MouseEnter(object sender, EventArgs e)
        {
            pictProfile.ShadowDecoration.Enabled = true;
        }
        private void pictProfile_MouseLeave(object sender, EventArgs e)
        {
            pictProfile.ShadowDecoration.Enabled = false;
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictProfile, "Profil fotoğrafını değiştirmek için tıkla");
            getYetkiliProfile();

        }

        void YetkiliProfileKaydet()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("UPDATE lib_Yetkililer SET Ad = @Ad, Soyad = @Soyad, KullaniciAdi = @KullaniciAdi WHERE İD = @id", dbConnection.connection);


                // Parametreleri ekle
                command.Parameters.AddWithValue("@id", yetkiliID);
                command.Parameters.AddWithValue("@Ad", txtAd.Text);
                command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                command.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);

                // Komutu çalıştır
                command.ExecuteNonQuery();

                PictProfileSave();
                getYetkiliProfile();
                MessageBox.Show($"Yetkili bilgileri başarıyla düzenlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void YetkiliSifreKaydet()
        {
            string yeniSifre = txtSifre.Text.Trim();

            try
            {
                dbConnection.OpenConnection();

                string md5YeniSifre = CalculateMD5Hash.MD5Hash(yeniSifre);

                MySqlCommand command = new MySqlCommand("UPDATE lib_yetkililer SET Sifre = @md5YeniSifre WHERE Sifre = @md5MevcutSifre", dbConnection.connection);
                command.Parameters.AddWithValue("@md5YeniSifre", md5YeniSifre);
                command.Parameters.AddWithValue("@md5MevcutSifre", md5MevcutSifre);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    txtSifre.Text = "";
                    MessageBox.Show("Şifre başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Şifre güncelleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        void getYetkiliProfile()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_yetkililer WHERE aktif = 1 and İD = @id", dbConnection.connection);

                command.Parameters.AddWithValue("@id", yetkiliID);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    txtAd.Text = row["Ad"].ToString();
                    txtSoyad.Text = row["Soyad"].ToString();
                    txtKullaniciAdi.Text = row["KullaniciAdi"].ToString();
                    pictProfile.ImageLocation = Helper.YetkiliProfilePath(yetkiliID);

                }
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
        void PictProfileSave()
        {
            if (!string.IsNullOrEmpty(YetkiliPicture))
            {
                File.Copy(YetkiliPicture, Application.StartupPath + "/profile_yetkili/" + yetkiliID + ".jpg", true);
            }
        }

        private void pictProfile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Resim Dosyaları (*.jpg, *.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                YetkiliPicture = openFileDialog.FileName;
                pictProfile.ImageLocation = YetkiliPicture;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtKullaniciAdi.Text) || btnSifreKontrolChecked == false)
            {
                MessageBox.Show("Boş bırakılan alanları doldurunuz yada şifrenizi kontrol edin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (yetkiliID > 0)
            {
                YetkiliProfileKaydet();

                AnaSayfa anaSayfa = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                if (anaSayfa != null)
                {

                    anaSayfa.BilgileriGoster();
                }
            }
        }

        private void btnSifreKontrol_Click(object sender, EventArgs e)
        {
            string mevcutSifre = txtMevcutSifre.Text.Trim();

            if (string.IsNullOrEmpty(mevcutSifre))
            {
                MessageBox.Show("Lütfen mevcut şifreyi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            md5MevcutSifre = CalculateMD5Hash.MD5Hash(mevcutSifre);

            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM lib_yetkililer WHERE Sifre = @md5MevcutSifre", dbConnection.connection);
                command.Parameters.AddWithValue("@md5MevcutSifre", md5MevcutSifre);

                int result = Convert.ToInt32(command.ExecuteScalar());

                if (result > 0)
                {
                    btnSifreKontrolChecked = true;
                    btnSifreKontrolEt.Enabled = false;
                    lblYeniSifre.Visible = true;
                    txtSifre.Visible = true;
                    btnSifreDegistir.Visible = true;
                }
                else
                {
                    MessageBox.Show("Mevcut şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen yeni şifreyi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Mevcut şifrenizi değiştirmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                YetkiliSifreKaydet();
            }
        }
    }
}
