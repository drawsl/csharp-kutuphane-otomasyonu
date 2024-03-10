using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Kutuphane_Otomasyonu.Resources.Classes;
using Kutuphane_Otomasyonu.Classes;
using MySql.Data.MySqlClient;

namespace Kutuphane_Otomasyonu.Forms
{
    public partial class Register_Panel : Form
    {
        public Register_Panel()
        {
            InitializeComponent();
        }
        dbConnection dbConnection = new dbConnection();

        private void button_Kayit_Click(object sender, EventArgs e)
        {
            // TextBox'lardan kullanıcı girdilerini al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string kullaniciAdi = txtKadi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            // Boş alan kontrolü yap
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcıyı kaydet
            bool isSuccess = AddUser(ad, soyad, kullaniciAdi, sifre);

            if (isSuccess)
            {
                MessageBox.Show("Kurulum tamamlandı, yönlendiriliyorsunuz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_Panel login_Panel = new Login_Panel();
                login_Panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı kaydedilirken bir hata oluştu, programı açıp kapatın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool AddUser(string ad, string soyad, string kullaniciAdi, string sifre)
        {
            try
            {
                dbConnection.OpenConnection();

                // Şifreyi MD5 hash'e dönüştür
                string hashedSifre = CalculateMD5Hash.CalculateMD5(sifre);

                // SQL sorgusunu hazırla
                string query = "INSERT INTO lib_yetkililer (Ad, Soyad, KullaniciAdi, Sifre, aktif) VALUES (@ad, @soyad, @kullaniciAdi, @sifre, 1)";
                MySqlCommand command = new MySqlCommand(query, dbConnection.connection);
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@soyad", soyad);
                command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@sifre", hashedSifre);

                // Komutu çalıştır
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

    }
}
