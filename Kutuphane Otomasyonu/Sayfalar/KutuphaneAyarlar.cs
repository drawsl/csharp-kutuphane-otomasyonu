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
    public partial class KutuphaneAyarlar : UserControl
    {
        public KutuphaneAyarlar()
        {
            InitializeComponent();
        }
        dbConnection dbConnection = new dbConnection();

        private void KutuphaneAyarlar_Load(object sender, EventArgs e)
        {
            getKutuphaneİnformation();
        }

        void getKutuphaneİnformation()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM lib_ayarlar", dbConnection.connection);

                //command.Parameters.AddWithValue("@id", yetkiliID);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    txtKurumAd.Text = row["KurumAd"].ToString();
                    txtKurumAdres.Text = row["KurumAdres"].ToString();
                    txtEmanetSure.Text = row["EmanetSure"].ToString();
                    txtSureUzat.Text = row["EmanetSureUzat"].ToString();
                    txtGecikmeBedel.Text = row["EmanetGecikmeBedel"].ToString();
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

        void KutuphaneİnformationKaydet()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand("UPDATE lib_ayarlar SET KurumAd = @KurumAd, KurumAdres = @KurumAdres, EmanetSure = @EmanetSure, EmanetSureUzat = @EmanetSureUzat, EmanetGecikmeBedel = @EmanetGecikmeBedel", dbConnection.connection);


                // Parametreleri ekle
                command.Parameters.AddWithValue("@KurumAd", txtKurumAd.Text);
                command.Parameters.AddWithValue("@KurumAdres", txtKurumAdres.Text);
                command.Parameters.AddWithValue("@EmanetSure", txtEmanetSure.Text);
                command.Parameters.AddWithValue("@EmanetSureUzat", txtSureUzat.Text);
                command.Parameters.AddWithValue("@EmanetGecikmeBedel", txtGecikmeBedel.Text);

                // Komutu çalıştır
                command.ExecuteNonQuery();

                getKutuphaneİnformation();
                MessageBox.Show($"Kurum bilgileri başarıyla düzenlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKurumAd.Text) || string.IsNullOrEmpty(txtKurumAdres.Text) || string.IsNullOrEmpty(txtEmanetSure.Text) || string.IsNullOrEmpty(txtSureUzat.Text) || string.IsNullOrEmpty(txtGecikmeBedel.Text))
            {
                MessageBox.Show("Boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtEmanetSure.Text, out int emanetSure) || !int.TryParse(txtSureUzat.Text, out int sureUzat) || !int.TryParse(txtGecikmeBedel.Text, out int gecikmeBedel))
            {
                MessageBox.Show("Lütfen sayı girdiğinizden emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Kurum bilgilerini ve emanet işlem ayarlarını değiştirmek istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                KutuphaneİnformationKaydet();
            }
        }

        private void txtEmanetSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 3 && e.KeyChar != 22 && e.KeyChar != 24)
            {
                e.Handled = true;
            }
        }
    }
}
