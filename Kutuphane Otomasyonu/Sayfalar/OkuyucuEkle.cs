using Guna.UI2.WinForms;
using Kutuphane_Otomasyonu.Classes;
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
    public partial class OkuyucuEkle : UserControl
    {
        public OkuyucuEkle()
        {
            InitializeComponent();
        }

        dbConnection dbConnection = new dbConnection();
        ToolTip toolTip = new ToolTip();
        int OkuyucuID = 0;
        string OkuyucuPicture = "";

        private void OkuyucuEkle_Load(object sender, EventArgs e)
        {
            OkuyucularLoad();
            toolTip.SetToolTip(pictProfile, "Okuyucu fotoğrafını değiştirmek için tıkla");
        }

        void okuyucuEkle()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO lib_okuyucular (Ad, Soyad, Cinsiyet, Sinifi, OkulNo, CepTel, Adres) VALUES (@Ad, @Soyad, @Cinsiyet, @Sinif, @OkulNo, @CepTel, @Adres); SELECT LAST_INSERT_ID();", dbConnection.connection);

                string cinsiyet = "";
                if (radioBtnErkek.Checked)
                {
                    cinsiyet = radioBtnErkek.Text;
                }
                else if (radioBtnKiz.Checked)
                {
                    cinsiyet = radioBtnKiz.Text;
                }

                // Parametreleri ekle
                command.Parameters.AddWithValue("@Ad", txtAdi.Text);
                command.Parameters.AddWithValue("@Soyad", txtSoyadi.Text);
                command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@Sinif", txtSinifi.Text);
                command.Parameters.AddWithValue("@OkulNo", txtOkulNo.Text);
                command.Parameters.AddWithValue("@CepTel", txtCepTel.Text);
                command.Parameters.AddWithValue("@Adres", txtAdres.Text);

                // Komutu çalıştır
                object value = command.ExecuteScalar();
                OkuyucuID = Convert.ToInt32(value);

                PictProfileSave();
                OkuyucularLoad();
                OkuyucuID = 0;
                MessageBox.Show($"{txtAdi.Text} {txtSoyadi.Text} adlı okuyucu başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void okuyucuDuzenle()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("UPDATE lib_Okuyucular SET Ad = @Ad, Soyad = @Soyad, Cinsiyet = @Cinsiyet, Sinifi = @Sinif, OkulNo = @OkulNo, CepTel = @CepTel, Adres = @Adres WHERE İD = @id", dbConnection.connection);

                string cinsiyet = "";
                if (radioBtnErkek.Checked)
                {
                    cinsiyet = radioBtnErkek.Text;
                }
                else if (radioBtnKiz.Checked)
                {
                    cinsiyet = radioBtnKiz.Text;
                }

                // Parametreleri ekle
                command.Parameters.AddWithValue("@Ad", txtAdi.Text);
                command.Parameters.AddWithValue("@Soyad", txtSoyadi.Text);
                command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                command.Parameters.AddWithValue("@Sinif", txtSinifi.Text);
                command.Parameters.AddWithValue("@OkulNo", txtOkulNo.Text);
                command.Parameters.AddWithValue("@CepTel", txtCepTel.Text);
                command.Parameters.AddWithValue("@Adres", txtAdres.Text);
                command.Parameters.AddWithValue("@id", OkuyucuID);

                // Komutu çalıştır
                command.ExecuteNonQuery();

                PictProfileSave();
                OkuyucularLoad();
                OkuyucuID = 0;
                MessageBox.Show($"Okuyucu başarıyla düzenlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void okuyucuSil()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("UPDATE lib_okuyucular SET aktif = 0 WHERE İD = @id", dbConnection.connection);


                // Parametreleri ekle
                command.Parameters.AddWithValue("@id", OkuyucuID);

                // Komutu çalıştır
                command.ExecuteNonQuery();

                OkuyucularLoad();
                MessageBox.Show($"{txtAdi.Text} {txtSoyadi.Text} adlı okuyucu başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void OkuyucularLoad()
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_okuyucular WHERE aktif = 1 and CONCAT(Ad, ' ', Soyad) LIKE @search", dbConnection.connection);

                command.Parameters.AddWithValue("@search", string.Format("%{0}%", txtAra.Text));


                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgOkuyucular.DataSource = dataTable;
                dgOkuyucular.Columns["aktif"].Visible = false;
                dgOkuyucular.Columns["İD"].Visible = false;
                dgOkuyucular.Columns["Ad"].HeaderText = "Adı";
                dgOkuyucular.Columns["Soyad"].HeaderText = "Soyadı";
                dgOkuyucular.Columns["Cinsiyet"].HeaderText = "Cinsiyeti";
                dgOkuyucular.Columns["Sinifi"].HeaderText = "Sınıfı";
                dgOkuyucular.Columns["OkulNo"].HeaderText = "Okul Numarası";
                dgOkuyucular.Columns["CepTel"].HeaderText = "Cep Telefonu Numarası";
                dgOkuyucular.Columns["Adres"].HeaderText = "Adresi";
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
            if (!string.IsNullOrEmpty(OkuyucuPicture))
            {
                File.Copy(OkuyucuPicture, Application.StartupPath + "/profiles/" + OkuyucuID + ".jpg", true);
            }
        }

        void Temizle()
        {
            OkuyucuID = 0;
            OkuyucuPicture = "";
            radioBtnErkek.Checked = false;
            radioBtnKiz.Checked = false;
            pictProfile.ImageLocation = Helper.OkuyucuProfilePath(-1);

            foreach (var item in tableBilgiler.Controls)
            {
                if (item is Guna2TextBox)
                {
                    ((Guna2TextBox)item).Text = "";
                }
                if (item is Guna2ComboBox)
                {
                    ((Guna2ComboBox)item).SelectedIndex = -1;
                }
            }
        }

        private void dgOkuyucular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                OkuyucuID = Convert.ToInt32(dgOkuyucular.Rows[e.RowIndex].Cells["İD"].Value);

                pictProfile.ImageLocation = Helper.OkuyucuProfilePath(OkuyucuID);

                radioBtnErkek.Checked = false;
                radioBtnKiz.Checked = false;
                try
                {
                    dbConnection.OpenConnection();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM lib_Okuyucular WHERE aktif = 1 and İD = @id", dbConnection.connection);

                    command.Parameters.AddWithValue("@id", OkuyucuID);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        txtAdi.Text = row["Ad"].ToString();
                        txtSoyadi.Text = row["Soyad"].ToString();
                        string cinsiyet = row["Cinsiyet"].ToString();
                        if (cinsiyet == radioBtnErkek.Text)
                        {
                            radioBtnErkek.Checked = true;
                        }
                        else if (cinsiyet == radioBtnKiz.Text)
                        {
                            radioBtnKiz.Checked = true;
                        }
                        txtSinifi.Text = row["Sinifi"].ToString();
                        txtOkulNo.Text = row["OkulNo"].ToString();
                        txtCepTel.Text = row["CepTel"].ToString();
                        txtAdres.Text = row["Adres"].ToString();
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
        }

        private void pictProfile_MouseEnter(object sender, EventArgs e)
        {
            pictProfile.ShadowDecoration.Enabled = true;
        }

        private void pictProfile_MouseLeave(object sender, EventArgs e)
        {
            pictProfile.ShadowDecoration.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtSoyadi.Text) || string.IsNullOrEmpty(txtSinifi.Text) || string.IsNullOrEmpty(txtOkulNo.Text) || string.IsNullOrEmpty(txtCepTel.Text))
            {
                MessageBox.Show("Lütfen doldurulması zorunlu olan alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (OkuyucuID > 0)
            {
                okuyucuDuzenle();
            }
            else
            {
                okuyucuEkle();
            }
            Emanetİslemleri emanetİslemleri = (Emanetİslemleri)Parent.Controls.Find("Emanetİslemleri", true).FirstOrDefault();
            if (emanetİslemleri != null)
            {
                emanetİslemleri.dgOkuyucularLoad();
            }
            Dashboard Dashboard = (Dashboard)Parent.Controls.Find("Dashboard", true).FirstOrDefault();
            if (Dashboard != null)
            {
                Dashboard.Yenilet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (OkuyucuID > 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Seçili okuyucuyu silmek istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    okuyucuSil();
                    Temizle();
                    Emanetİslemleri emanetİslemleri = (Emanetİslemleri)Parent.Controls.Find("Emanetİslemleri", true).FirstOrDefault();
                    if (emanetİslemleri != null)
                    {
                        emanetİslemleri.dgOkuyucularLoad();
                    }
                    Dashboard Dashboard = (Dashboard)Parent.Controls.Find("Dashboard", true).FirstOrDefault();
                    if (Dashboard != null)
                    {
                        Dashboard.Yenilet();
                    }
                }
            }
            else
            {
                MessageBox.Show($"Lütfen silmek istediğiniz kitabı tablodan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void pictProfile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Resim Dosyaları (*.jpg, *.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OkuyucuPicture = openFileDialog.FileName;
                pictProfile.ImageLocation = OkuyucuPicture;
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            OkuyucularLoad();
        }

        private void txtCepTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 24)
            {
                e.Handled = true;
            }
        }
        private void txtOkulNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
