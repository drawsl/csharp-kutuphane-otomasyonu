using Guna.UI2.WinForms;
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
    public partial class KitapBilgiGirisi : UserControl
    {
        public KitapBilgiGirisi()
        {
            InitializeComponent();
        }
        dbConnection dbConnection = new dbConnection();

        int RowID = 0;

        string getTableName()
        {
            switch (cbbGirdiTablo.SelectedIndex)
            {
                case 0:
                    return "lib_Yazarlar";
                case 1:
                    return "lib_Yayinevleri";
                case 2:
                    return "lib_Turler";
                case 3:
                    return "lib_Dolaplar";
            }
            return "";
        }

        void TableLoad()
        {
            if (!string.IsNullOrEmpty(getTableName()))
            {
                try
                {
                    dbConnection.OpenConnection();

                    MySqlCommand command = new MySqlCommand($"SELECT * FROM {getTableName()} WHERE Adi LIKE @search", dbConnection.connection);

                    command.Parameters.AddWithValue("@search", string.Format("%{0}%", txtAra.Text));

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgGirdi.DataSource = dataTable;
                    dgGirdi.Columns["İD"].Visible = false;
                    dgGirdi.Columns["Adi"].HeaderText = cbbGirdiTablo.Text;
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

        void GirdiEkle()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand($"INSERT INTO {getTableName()} (Adi) VALUES (@Adi)", dbConnection.connection);

                // Parametreleri ekle
                command.Parameters.AddWithValue("@Adi", txtGirdiAdi.Text);

                // Komutu çalıştır
                command.ExecuteNonQuery();
                TableLoad();
                MessageBox.Show($"{txtGirdiAdi.Text} adlı girdi {cbbGirdiTablo.Text} tablosuna başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        void GirdiDuzenle()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand($"UPDATE {getTableName()} SET Adi = @Adi WHERE İD = @id", dbConnection.connection);

                command.Parameters.AddWithValue("@Adi", txtGirdiAdi.Text);
                command.Parameters.AddWithValue("@id", RowID);

                // Komutu çalıştır
                command.ExecuteNonQuery();

                TableLoad();
                RowID = 0;
                MessageBox.Show($"{txtGirdiAdi.Text} adlı girdi {cbbGirdiTablo.Text} tablosunda başarıyla düzenlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void GirdiSil()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand($"DELETE FROM {getTableName()} WHERE İD = @id", dbConnection.connection);


                // Parametreleri ekle
                command.Parameters.AddWithValue("@id", RowID);

                // Komutu çalıştır
                command.ExecuteNonQuery();

                TableLoad();
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
            RowID = 0;
            txtGirdiAdi.Text = "";
        }

        private void cbbGirdiTablo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableLoad();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGirdiAdi.Text) || string.IsNullOrEmpty(getTableName()))
            {
                MessageBox.Show("Lütfen doldurulması veya seçilmesi zorunlu olan alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (RowID > 0)
                {
                    GirdiDuzenle();
                }
                else
                {
                    GirdiEkle();
                }
            }
            KitapEkle kitapEkle = (KitapEkle)Parent.Controls.Find("KitapEkle", true).FirstOrDefault();
            if (kitapEkle != null)
            {
                kitapEkle.FillComboBoxes();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (RowID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kitap girdisini silmek istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    GirdiSil();
                    Temizle();
                    KitapEkle kitapEkle = (KitapEkle)Parent.Controls.Find("KitapEkle", true).FirstOrDefault();
                    if (kitapEkle != null)
                    {
                        kitapEkle.FillComboBoxes();
                    }
                }
            }
            else
            {
                MessageBox.Show($"Lütfen {cbbGirdiTablo.Text} tablosundan silmek istediğiniz girişi tablodan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgGirdi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                RowID = Convert.ToInt32(dgGirdi.Rows[e.RowIndex].Cells["İD"].Value);
                txtGirdiAdi.Text = dgGirdi.Rows[e.RowIndex].Cells["Adi"].Value.ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            TableLoad();
        }

        private void KitapBilgiGirisi_Load(object sender, EventArgs e)
        {
            TableLoad();
        }
    }
}
