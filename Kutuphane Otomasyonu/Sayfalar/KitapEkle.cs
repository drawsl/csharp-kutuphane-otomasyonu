using Guna.UI2.WinForms;
using Kutuphane_Otomasyonu.Resources.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu.Sayfalar
{
    public partial class KitapEkle : UserControl
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        dbConnection dbConnection = new dbConnection();

        int KitapID = 0;
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            dgKitaplarLoad();
        }

        public void FillComboBoxes()
        {
            //ComboBoxların içeriğini yenile
            cbbDolap.Items.Clear();
            cbbTur.Items.Clear();
            cbbYayinEvi.Items.Clear();
            cbbYazar.Items.Clear();
            try
            {
                dbConnection.OpenConnection();

                foreach (DataRow row in dbConnection.ExecuteQuery("SELECT Adi FROM lib_Dolaplar").Rows)
                {
                    cbbDolap.Items.Add(row["Adi"].ToString());
                }

                foreach (DataRow row in dbConnection.ExecuteQuery("SELECT Adi FROM lib_Turler").Rows)
                {
                    cbbTur.Items.Add(row["Adi"].ToString());
                }

                foreach (DataRow row in dbConnection.ExecuteQuery("SELECT Adi FROM lib_Yazarlar").Rows)
                {
                    cbbYazar.Items.Add(row["Adi"].ToString());
                }

                foreach (DataRow row in dbConnection.ExecuteQuery("SELECT Adi FROM lib_Yayinevleri").Rows)
                {
                    cbbYayinEvi.Items.Add(row["Adi"].ToString());
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

        void dgKitaplarLoad()
        {
            try
            {
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_Kitaplar WHERE CONCAT(YazarAdi, ' ', KitapAdi) LIKE @search", dbConnection.connection);
                command.Parameters.AddWithValue("@search", string.Format("%{0}%", txtAra.Text));

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgKitaplar.DataSource = dataTable;
                dgKitaplar.Columns["İD"].Visible = false;
                dgKitaplar.Columns["KayitNo"].HeaderText = "Kayıt Numarası";
                dgKitaplar.Columns["KitapAdi"].HeaderText = "Kitap Adı";
                dgKitaplar.Columns["YazarAdi"].HeaderText = "Yazar Adı";
                dgKitaplar.Columns["YayinEvi"].HeaderText = "Yayınevi Adı";
                dgKitaplar.Columns["BasimYili"].HeaderText = "Basım Yılı";
                dgKitaplar.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
                dgKitaplar.Columns["Turu"].HeaderText = "Türü";
                dgKitaplar.Columns["Aciklama"].HeaderText = "Açıklama";
                dgKitaplar.Columns["Dolap"].HeaderText = "Dolap";
                dgKitaplar.Columns["Raf"].HeaderText = "Raf";
                dgKitaplar.Columns["Sira"].HeaderText = "Sıra";
                dgKitaplar.Columns["durum"].HeaderText = "Durumu (Emanet Mi?)";
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

        int getKayitNo()
        {
            try
            {
                dbConnection.OpenConnection();

                foreach (DataRow row in dbConnection.ExecuteQuery("SELECT IFNULL(MAX(KayitNo), 0) + 1 AS MaxKayitNo FROM lib_Kitaplar").Rows)
                {
                    return Convert.ToInt32(row[0]);
                }
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return 1;
        }

        void kitapEkle()
        {
            int KayitNo = getKayitNo();

            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO lib_Kitaplar (KayitNo, KitapAdi, YazarAdi, YayinEvi, BasimYili, SayfaSayisi, Turu, Aciklama, Dolap, Raf, Sira) " +
                                                        "VALUES (@KayitNo, @KitapAdi, @YazarAdi, @YayinEvi, @BasimYili, @SayfaSayisi, @Turu, @Aciklama, @Dolap, @Raf, @Sira)", dbConnection.connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@KayitNo", KayitNo);
                command.Parameters.AddWithValue("@KitapAdi", txtKitapAd.Text);
                command.Parameters.AddWithValue("@YazarAdi", cbbYazar.Text.ToString());
                command.Parameters.AddWithValue("@YayinEvi", cbbYayinEvi.Text.ToString());
                command.Parameters.AddWithValue("@BasimYili", txtBasimYili.Text);
                command.Parameters.AddWithValue("@SayfaSayisi", txtSayfaSayi.Text);
                command.Parameters.AddWithValue("@Turu", cbbTur.Text.ToString());
                command.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                command.Parameters.AddWithValue("@Dolap", cbbDolap.Text.ToString());
                command.Parameters.AddWithValue("@Raf", txtRaf.Text);
                command.Parameters.AddWithValue("@Sira", txtSira.Text);

                // Komutu çalıştır
                command.ExecuteNonQuery();
                txtKayitNo.Text = KayitNo.ToString();
                dgKitaplarLoad();
                MessageBox.Show($"{txtKitapAd.Text} adlı kitap başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        void kitapDuzenle()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("UPDATE lib_Kitaplar SET KitapAdi = @KitapAdi, YazarAdi = @YazarAdi, YayinEvi = @YayinEvi, BasimYili = @BasimYili, SayfaSayisi = @SayfaSayisi, Turu = @Turu, Aciklama = @Aciklama, Dolap = @Dolap, Raf = @Raf, Sira = @Sira WHERE İD = @id", dbConnection.connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@KitapAdi", txtKitapAd.Text);
                command.Parameters.AddWithValue("@YazarAdi", cbbYazar.SelectedItem.ToString());
                command.Parameters.AddWithValue("@YayinEvi", cbbYayinEvi.SelectedItem.ToString());
                command.Parameters.AddWithValue("@BasimYili", txtBasimYili.Text);
                command.Parameters.AddWithValue("@SayfaSayisi", txtSayfaSayi.Text);
                command.Parameters.AddWithValue("@Turu", cbbTur.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                command.Parameters.AddWithValue("@Dolap", cbbDolap.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Raf", txtRaf.Text);
                command.Parameters.AddWithValue("@Sira", txtSira.Text);
                command.Parameters.AddWithValue("@İD", KitapID);


                // Komutu çalıştır
                command.ExecuteNonQuery();
                dgKitaplarLoad();
                KitapID = 0;
                MessageBox.Show($"Kitap başarıyla düzenlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void kitapSil()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("DELETE FROM lib_kitaplar WHERE İD = @İD", dbConnection.connection);

                command.Parameters.AddWithValue("@İD", KitapID);

                // Komutu çalıştır
                command.ExecuteNonQuery();
                dgKitaplarLoad();
                MessageBox.Show($"{txtKitapAd.Text} adlı kitap başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        void Temizle()
        {
            KitapID = 0;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKitapAd.Text) || string.IsNullOrEmpty(cbbYazar.Text) || string.IsNullOrEmpty(cbbTur.Text) || string.IsNullOrEmpty(cbbDolap.Text) || string.IsNullOrEmpty(txtRaf.Text) || string.IsNullOrEmpty(txtSira.Text))
            {
                MessageBox.Show("Lütfen doldurulması zorunlu olan alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (KitapID > 0)
            {
                kitapDuzenle();
            }
            else
            {
                kitapEkle();
            }
            Emanetİslemleri emanetİslemleri = (Emanetİslemleri)Parent.Controls.Find("Emanetİslemleri", true).FirstOrDefault();
            if (emanetİslemleri != null)
            {
                emanetİslemleri.dgKitaplarLoad();
            }
            Dashboard Dashboard = (Dashboard)Parent.Controls.Find("Dashboard", true).FirstOrDefault();
            if (Dashboard != null)
            {
                Dashboard.Yenilet();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (KitapID > 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Seçili kitabı silmek istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    kitapSil();
                    Temizle();
                    Emanetİslemleri emanetİslemleri = (Emanetİslemleri)Parent.Controls.Find("Emanetİslemleri", true).FirstOrDefault();
                    if (emanetİslemleri != null)
                    {
                        emanetİslemleri.dgKitaplarLoad();
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

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 24)
            {
                e.Handled = true;
            }
        }

        private void dgKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                KitapID = Convert.ToInt32(dgKitaplar.Rows[e.RowIndex].Cells["İD"].Value);

                try
                {
                    dbConnection.OpenConnection();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM lib_Kitaplar WHERE İD = @id", dbConnection.connection);
                    command.Parameters.AddWithValue("@id", KitapID);

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        txtKayitNo.Text = row["KayitNo"].ToString();
                        txtKitapAd.Text = row["KitapAdi"].ToString();
                        cbbYazar.Text = row["YazarAdi"].ToString();
                        cbbYayinEvi.Text = row["YayinEvi"].ToString();
                        txtBasimYili.Text = row["BasimYili"].ToString();
                        txtSayfaSayi.Text = row["SayfaSayisi"].ToString();
                        cbbTur.Text = row["Turu"].ToString();
                        txtAciklama.Text = row["Aciklama"].ToString();
                        cbbDolap.Text = row["Dolap"].ToString();
                        txtRaf.Text = row["Raf"].ToString();
                        txtSira.Text = row["Sira"].ToString();
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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgKitaplarLoad();
        }
    }
}
