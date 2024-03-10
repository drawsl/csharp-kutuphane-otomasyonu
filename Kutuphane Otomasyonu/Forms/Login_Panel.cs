using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kutuphane_Otomasyonu.Resources.Classes;
using Kutuphane_Otomasyonu.Classes;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kutuphane_Otomasyonu.Forms
{
    public partial class Login_Panel : Form
    {
        public Login_Panel()
        {
            InitializeComponent();
        }
        dbConnection dbConnection = new dbConnection();

        private void Login_Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Panel_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                checkBeniHatirla.Checked = true;
                txtKullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;
                txtSifre.Text = Properties.Settings.Default.sifre;
            }
            else
            {
                checkBeniHatirla.Checked = false;
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
            }
        }

        private void btnGirisYap_click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtKullaniciAdi.Text;
            string Sifre = txtSifre.Text;

            if (!string.IsNullOrEmpty(KullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                string md5Sifre = CalculateMD5Hash.MD5Hash(Sifre);

                if (GirisKontrol(KullaniciAdi, md5Sifre))
                {
                    int kullaniciID = GetUserID(KullaniciAdi);

                    UserInfo.userID = kullaniciID;

                    if (checkBeniHatirla.Checked)
                    {
                        Properties.Settings.Default.kullaniciAdi = KullaniciAdi;
                        Properties.Settings.Default.sifre = Sifre;
                        Properties.Settings.Default.BeniHatirla = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.kullaniciAdi = "";
                        Properties.Settings.Default.sifre = "";
                        Properties.Settings.Default.BeniHatirla = false;
                        Properties.Settings.Default.Save();
                    }

                    AnaSayfa anaSayfaForm = new AnaSayfa();
                    anaSayfaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int GetUserID(string kullaniciAdi)
        {
            int kullaniciID = -1; // Varsayılan değer
            try
            {
                using (MySqlConnection conn = dbConnection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT İD FROM lib_Yetkililer WHERE KullaniciAdi = @kullaniciAdi AND aktif = 1", conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            kullaniciID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı ID alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            return kullaniciID;
        }
        bool GirisKontrol(string kullaniciAdi, string sifre)
        {
            try
            {
                using (MySqlConnection conn = dbConnection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM lib_Yetkililer WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre AND aktif = 1", conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        int kullaniciSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                        return kullaniciSayisi > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void checkBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BeniHatirla = checkBeniHatirla.Checked;
        }
    }
}