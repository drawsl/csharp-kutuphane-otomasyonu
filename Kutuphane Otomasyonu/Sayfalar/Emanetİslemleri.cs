using Kutuphane_Otomasyonu.Classes;
using Kutuphane_Otomasyonu.Resources.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu.Sayfalar
{
    public partial class Emanetİslemleri : UserControl
    {
        public Emanetİslemleri()
        {
            InitializeComponent();
        }
        dbConnection dbConnection = new dbConnection();

        int OkuyucuID = 0;
        int KitapID = 0;
        int cezaBedel = 0;

        private void Emanetİslemleri_Load(object sender, EventArgs e)
        {
            dgOkuyucularLoad();
            dgKitaplarLoad();
        }

        void getOkuyucuProfile()
        {
            pictProfile.ImageLocation = Helper.OkuyucuProfilePath(0);
            lblAdSoyad.Text = "";
            lblSinif.Text = "";
            lblOkulNo.Text = "";
            lblGecikmeBedeli.Text = "";
            cezaBedel = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_Okuyucular WHERE aktif = 1 and İD = @id", dbConnection.connection);

                command.Parameters.AddWithValue("@id", OkuyucuID);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    pictProfile.ImageLocation = Helper.OkuyucuProfilePath(OkuyucuID);
                    lblAdSoyad.Text = $"{row["Ad"]} {row["Soyad"]}";
                    lblSinif.Text = row["Sinifi"].ToString();
                    lblOkulNo.Text = row["OkulNo"].ToString();

                    cezaBedel = getGecikmeBedeli();
                    if (cezaBedel > 0)
                    {
                        lblGecikmeBedeli.Text = $"{string.Format("{0:C}", cezaBedel)}";
                        lblGecikmeBedeli.ForeColor = Color.Red;
                    }
                    else if (getEmanetİD() == 0)
                    {
                        lblGecikmeBedeli.Text = "Kitap Emanet Almadı";
                        lblGecikmeBedeli.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblGecikmeBedeli.Text = "Gecikme Bedeli Yok";
                        lblGecikmeBedeli.ForeColor = Color.Green;
                    }
                    KitapID = getEmanetİD();
                    getKitapİnformation();
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
        void getKitapİnformation()
        {
            lblKayitNo.Text = "";
            lblKitapAdi.Text = "";
            lblYazarAdi.Text = "";
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_Kitaplar WHERE İD = @id", dbConnection.connection);

                command.Parameters.AddWithValue("@id", KitapID);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    lblKayitNo.Text = row["KayitNo"].ToString();
                    lblKitapAdi.Text = row["KitapAdi"].ToString();
                    lblYazarAdi.Text = row["YazarAdi"].ToString();
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

        public void dgOkuyucularLoad()
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_Okuyucular WHERE aktif = 1 and CONCAT(Ad, ' ', Soyad) LIKE @search", dbConnection.connection);

                command.Parameters.AddWithValue("@search", string.Format("%{0}%", txtOkuyucuAra.Text));

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
        public void dgKitaplarLoad()
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_Kitaplar WHERE durum = 1 and CONCAT(YazarAdi, ' ', KitapAdi) LIKE @search", dbConnection.connection);
                command.Parameters.AddWithValue("@search", string.Format("%{0}%", txtKitapAra.Text));

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgKitaplar.DataSource = dataTable;
                dgKitaplar.Columns["İD"].Visible = false;
                dgKitaplar.Columns["KayitNo"].HeaderText = "Kayıt Numarası";
                dgKitaplar.Columns["KitapAdi"].HeaderText = "Kitap Adı";
                dgKitaplar.Columns[2].Width = 150;
                dgKitaplar.Columns[3].Width = 100;
                dgKitaplar.Columns["YazarAdi"].HeaderText = "Yazar Adı";
                dgKitaplar.Columns["YayinEvi"].HeaderText = "Yayınevi Adı";
                dgKitaplar.Columns["BasimYili"].HeaderText = "Basım Yılı";
                dgKitaplar.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
                dgKitaplar.Columns["Turu"].HeaderText = "Türü";
                dgKitaplar.Columns["Aciklama"].HeaderText = "Açıklama";
                dgKitaplar.Columns["Dolap"].HeaderText = "Dolap";
                dgKitaplar.Columns["Raf"].HeaderText = "Raf";
                dgKitaplar.Columns["Sira"].HeaderText = "Sıra";
                dgKitaplar.Columns["durum"].Visible = false;
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

        void EmanetEt()
        {
            if (KitapID == 0 || OkuyucuID == 0)
            {
                MessageBox.Show("Kitap veya okuyucu seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (getEmanetİD() > 0)
            {
                MessageBox.Show("Seçili okuyucunun mevcut emaneti var!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                dbConnection.OpenConnection();

                MySqlCommand ayarlarCommand = new MySqlCommand("SELECT EmanetSure FROM lib_ayarlar", dbConnection.connection);
                int emanetSure = Convert.ToInt32(ayarlarCommand.ExecuteScalar());

                DateTime emanetGeriAlmaTarih = DateTime.Now.AddDays(emanetSure);

                MySqlCommand command = new MySqlCommand("UPDATE lib_kitaplar SET durum = 0 WHERE İD = @KitapID; INSERT INTO lib_emanetler (KitapID, OkuyucuID, emanetVerilisTarih, emanetGeriAlmaTarih) VALUES (@KitapID, @OkuyucuID, @emanetVerilisTarih, @emanetGeriAlmaTarih)", dbConnection.connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@KitapID", KitapID);
                command.Parameters.AddWithValue("@OkuyucuID", OkuyucuID);
                command.Parameters.AddWithValue("@emanetVerilisTarih", DateTime.Now);
                command.Parameters.AddWithValue("@emanetGeriAlmaTarih", emanetGeriAlmaTarih);

                // Komutu çalıştır
                command.ExecuteNonQuery();
                dgKitaplarLoad();
                MessageBox.Show($"{lblAdSoyad.Text} isimli kişiye {lblKitapAdi.Text} adlı kitabı {emanetSure} gün emanet ettin Emanet Veriliş Tarihi: {DateTime.Now.ToString("dd MMMM")}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void SureUzat()
        {
            if (OkuyucuID == 0)
            {
                MessageBox.Show("Okuyucu seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (getEmanetİD() == 0)
            {
                MessageBox.Show("Seçili okuyucunun mevcut emaneti yok!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                dbConnection.OpenConnection();

                MySqlCommand ayarlarCommand = new MySqlCommand("SELECT EmanetSureUzat FROM lib_ayarlar", dbConnection.connection);
                int EmanetSureUzat = Convert.ToInt32(ayarlarCommand.ExecuteScalar());

                DateTime emanetGeriAlmaTarih = DateTime.Now.AddDays(EmanetSureUzat);


                MySqlCommand command = new MySqlCommand("UPDATE lib_emanetler SET emanetVerilisTarih = @emanetVerilisTarih, emanetGeriAlmaTarih = @emanetGeriAlmaTarih WHERE KitapID = @KitapID", dbConnection.connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@KitapID", KitapID);
                command.Parameters.AddWithValue("@emanetVerilisTarih", DateTime.Now);
                command.Parameters.AddWithValue("@emanetGeriAlmaTarih", emanetGeriAlmaTarih);

                // Komutu çalıştır
                command.ExecuteNonQuery();
                getOkuyucuProfile();
                dgKitaplarLoad();
                MessageBox.Show($"{lblAdSoyad.Text} isimli kişiye emanet edilen {lblKitapAdi.Text} kitabının süresi {EmanetSureUzat} gün uzatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void DusumYap()
        {
            if (OkuyucuID == 0)
            {
                MessageBox.Show("Okuyucu seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (getEmanetİD() == 0)
            {
                MessageBox.Show("Seçili okuyucunun mevcut emaneti yok!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("UPDATE lib_kitaplar SET durum = 1 WHERE İD = @KitapID; UPDATE lib_emanetler SET emanetİslemTarih = @emanetİslemTarih, durum = 1 WHERE KitapID = @KitapID", dbConnection.connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@KitapID", KitapID);
                command.Parameters.AddWithValue("@emanetİslemTarih", DateTime.Now);

                // Komutu çalıştır
                command.ExecuteNonQuery();
                MessageBox.Show($"{lblAdSoyad.Text} isimli kişiye emanet edilen {lblKitapAdi.Text} adlı kitaba düşüm yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getOkuyucuProfile();
                dgKitaplarLoad();
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

        int getEmanetİD()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_emanetler WHERE OkuyucuID = @id AND durum = 0 AND aktif = 1", dbConnection.connection);

                command.Parameters.AddWithValue("@id", OkuyucuID);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    return Convert.ToInt32(row["KitapID"]);
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
            return 0;
        }
        int getGecikmeBedeli()
        {
            try
            {


                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_emanetler WHERE OkuyucuID = @id AND durum = 0 AND aktif = 1", dbConnection.connection);

                command.Parameters.AddWithValue("@id", OkuyucuID);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                int cezaBedeli = 0;

                dbConnection.OpenConnection();

                MySqlCommand ayarlarCommand = new MySqlCommand("SELECT EmanetGecikmeBedel FROM lib_ayarlar", dbConnection.connection);
                cezaBedeli = Convert.ToInt32(ayarlarCommand.ExecuteScalar());

                int gunFark = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    TimeSpan timeSpan = DateTime.Now - Convert.ToDateTime(row["emanetGeriAlmaTarih"]);
                    gunFark = timeSpan.Days;
                }

                if (gunFark > 0)
                {
                    return (gunFark * cezaBedeli);
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
            return 0;
        }

        private void txtOkuyucuAra_TextChanged(object sender, EventArgs e)
        {
            dgOkuyucularLoad();
        }
        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            dgKitaplarLoad();
        }

        private void dgOkuyucular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                OkuyucuID = Convert.ToInt32(dgOkuyucular.Rows[e.RowIndex].Cells["İD"].Value);
                getOkuyucuProfile();
            }
        }
        private void dgKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (OkuyucuID == 0)
                {
                    MessageBox.Show("Okuyucu seçimi yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (getEmanetİD() > 0)
                {
                    MessageBox.Show("Kitap seçme işlemi yapılamadı, okuyucunun mevcut emaneti var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                KitapID = Convert.ToInt32(dgKitaplar.Rows[e.RowIndex].Cells["İD"].Value);
                getKitapİnformation();
            }
        }

        private void btnEmanetEt_Click(object sender, EventArgs e)
        {
            EmanetEt();
            Dashboard dashboard = (Dashboard)Parent.Controls.Find("Dashboard", true).FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Yenilet();
            }
        }
        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            if (cezaBedel > 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Okuyucunun {string.Format("{0:C}", cezaBedel)} gecikme cezası var, ücret tahsil edildi mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    SureUzat();
                }
            }
            else
            {
                SureUzat();
            }
        }
        private void btnDusumYap_Click(object sender, EventArgs e)
        {
            if (cezaBedel > 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Okuyucunun {string.Format("{0:C}", cezaBedel)} gecikme cezası var, ücret tahsil edildi mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    DusumYap();
                }
            }
            else
            {
                DusumYap();
            }
            Dashboard dashboard = (Dashboard)Parent.Controls.Find("Dashboard", true).FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Yenilet();
            }
        }
    }
}
