using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kutuphane_Otomasyonu.Resources.Classes;
using LiveCharts.WinForms;
using LiveCharts.Definitions.Charts;
using Kutuphane_Otomasyonu.Classes;

namespace Kutuphane_Otomasyonu.Sayfalar
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ToplamStatistics();
            chartOkuyucularLoad();
            chartKitaplarLoad();
            pieChartYazarlarLoad();
            pieChartKitapTurlerLoad();
            loadSonGiris();
            dgLoad();
        }
        dbConnection dbConnection = new dbConnection();

        void loadSonGiris()
        {
            try
            {
                dbConnection.OpenConnection();

                Dictionary<int, string> yetkiliListesi = new Dictionary<int, string>();
                MySqlCommand yetkiliCommand = new MySqlCommand($"SELECT İD, KullaniciAdi FROM lib_Yetkililer", dbConnection.connection);
                MySqlDataReader yetkiliReader = yetkiliCommand.ExecuteReader();
                while (yetkiliReader.Read())
                {
                    yetkiliListesi.Add(yetkiliReader.GetInt32(0), yetkiliReader.GetString(1));
                }
                yetkiliReader.Close();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM lib_songiris ORDER BY İD DESC", dbConnection.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns.Add("YetkiliAdi", typeof(string));
                foreach (DataRow row in dataTable.Rows)
                {
                    int yetkiliID = Convert.ToInt32(row["YetkiliID"]);
                    if (yetkiliListesi.ContainsKey(yetkiliID))
                    {
                        row["YetkiliAdi"] = yetkiliListesi[yetkiliID];
                    }
                }

                dataTable.Columns["YetkiliAdi"].SetOrdinal(0);
                dgSonGiris.DataSource = dataTable;
                dgSonGiris.Columns["İD"].Visible = false;
                dgSonGiris.Columns["YetkiliID"].Visible = false;
                dgSonGiris.Columns["YetkiliAdi"].HeaderText = "Yetkili Adı";
            }
            catch (Exception ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        public void ToplamStatistics()
        {
            try
            {
                dbConnection.OpenConnection();

                int okuyucuCount = Convert.ToInt32(dbConnection.ExecuteQuery("SELECT COUNT(*) FROM lib_okuyucular WHERE aktif = 1").Rows[0][0]);
                int kitapCount = Convert.ToInt32(dbConnection.ExecuteQuery("SELECT COUNT(*) FROM lib_kitaplar").Rows[0][0]);
                int emanetCount = Convert.ToInt32(dbConnection.ExecuteQuery("SELECT COUNT(*) FROM lib_emanetler WHERE durum = 0 AND aktif = 1").Rows[0][0]);

                lblToplamOkuyucular.Text = okuyucuCount.ToString();
                lblToplamKitaplar.Text = kitapCount.ToString();
                lblMevcutEmanetler.Text = emanetCount.ToString();
                lblMevcutGecikmeler.Text = mevcutGecikmelerCount().ToString();
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
        int mevcutGecikmelerCount()
        {
            try
            {
                return Convert.ToInt32(dbConnection.ExecuteQuery("SELECT COUNT(*) FROM lib_emanetler WHERE durum = 0 AND aktif = 1 AND emanetGeriAlmaTarih < CURDATE() - INTERVAL 1 MONTH").Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
                return 0;
            }
        }

        void chartOkuyucularLoad()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand(@"SELECT CONCAT(lib_okuyucular.Ad, ' ', lib_okuyucular.Soyad) AS AdSoyad, COUNT(*) AS OkunanKitapSayisi
                                        FROM lib_emanetler
                                        INNER JOIN lib_okuyucular ON lib_okuyucular.İD = lib_emanetler.OkuyucuID
                                        WHERE lib_okuyucular.aktif = 1 AND lib_emanetler.aktif = 1
                                        GROUP BY AdSoyad
                                        ORDER BY OkunanKitapSayisi DESC;", dbConnection.connection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Grafik veri serisini oluştur
                SeriesCollection series = new SeriesCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    string fullName = row["AdSoyad"].ToString();
                    int bookCount = Convert.ToInt32(row["OkunanKitapSayisi"]);

                    // Sıfır değerini kontrol et ve sıfır olmayanlar için veri serisi oluştur
                    if (bookCount != 0)
                    {
                        // Veri serisi oluştur ve adını ve kitap sayısını ekle
                        var columnSeries = new ColumnSeries
                        {
                            Title = fullName,
                            Values = new ChartValues<int> { bookCount }
                        };
                        series.Add(columnSeries);
                    }
                }

                // Grafik için eksenleri ayarla
                Axis xAxis = new Axis
                {
                    Title = "Okuyucular",
                    Foreground = System.Windows.Media.Brushes.White,
                    FontWeight = System.Windows.FontWeights.SemiBold,
                    FontSize = 11,
                    Labels = series.Select(s => "").ToList()
                };

                Axis yAxis = new Axis
                {
                    Title = "Okunan Kitap Sayısı",
                    LabelFormatter = value => value.ToString("N"),
                    Foreground = System.Windows.Media.Brushes.White,
                    FontWeight = System.Windows.FontWeights.Normal,
                    FontSize = 11
                };

                // Grafik nesnesini oluştur
                chartTopOkuyucular.Series = series;
                chartTopOkuyucular.AxisX.Add(xAxis);
                chartTopOkuyucular.AxisY.Add(yAxis);

                chartTopOkuyucular.AxisX[0].Separator = new Separator { Step = 1, IsEnabled = false };
                chartTopOkuyucular.AxisY[0].Separator = new Separator { Step = 1, IsEnabled = false };
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
        void chartKitaplarLoad()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand(@"SELECT KitapAdi, COUNT(*) AS OkunanSayi
                                                FROM lib_emanetler
                                                INNER JOIN lib_kitaplar ON lib_kitaplar.İD = lib_emanetler.KitapID
                                                GROUP BY KitapAdi
                                                ORDER BY OkunanSayi DESC", dbConnection.connection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Grafik veri serisini oluştur
                SeriesCollection series = new SeriesCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    string kitapAdi = row["KitapAdi"].ToString();
                    int okunanSayi = Convert.ToInt32(row["OkunanSayi"]);

                    // Veri serisi oluştur ve kitap adını ve okunan sayıyı ekle
                    series.Add(new ColumnSeries
                    {
                        Title = kitapAdi,
                        Values = new ChartValues<int> { okunanSayi }
                    });
                }

                // Grafik için eksenleri ayarla
                Axis xAxis = new Axis
                {
                    Title = "Kitaplar",
                    Foreground = System.Windows.Media.Brushes.White,
                    FontWeight = System.Windows.FontWeights.SemiBold,
                    FontSize = 11,
                    Labels = series.Select(s => "").ToList() // Seri başlıklarını eksen etiketleri olarak ayarla
                };

                Axis yAxis = new Axis
                {
                    Title = "Okunma Sayısı",
                    LabelFormatter = value => value.ToString("N"),
                    Foreground = System.Windows.Media.Brushes.White, // Yazı rengini beyaz yap
                    FontWeight = System.Windows.FontWeights.Normal,
                    FontSize = 11 // Yazının boyutunu ayarla
                };

                // Grafik nesnesini oluştur
                chartTopKitaplar.Series = series;
                chartTopKitaplar.AxisX.Add(xAxis);
                chartTopKitaplar.AxisY.Add(yAxis);

                chartTopKitaplar.AxisX[0].Separator = new Separator { Step = 1, IsEnabled = false };
                chartTopKitaplar.AxisY[0].Separator = new Separator { Step = 1, IsEnabled = false };
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
        void pieChartYazarlarLoad()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand(@"SELECT YazarAdi, COUNT(*) AS KitapSayisi
                                                FROM lib_emanetler
                                                INNER JOIN lib_kitaplar ON lib_kitaplar.İD = lib_emanetler.KitapID
                                                GROUP BY YazarAdi
                                                ORDER BY COUNT(*) DESC
                                                LIMIT 5", dbConnection.connection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // PieChart veri serisini oluştur
                SeriesCollection series = new SeriesCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    string yazarAdi = row["YazarAdi"].ToString();
                    int kitapSayisi = Convert.ToInt32(row["KitapSayisi"]);

                    // Veri serisi oluştur ve yazar adını ve kitap sayısını ekle
                    series.Add(new PieSeries
                    {
                        Title = yazarAdi,
                        Values = new ChartValues<int> { kitapSayisi }
                    });
                }

                // Grafik nesnesini oluştur
                pieChartYazarlar.Series = series;
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
        void pieChartKitapTurlerLoad()
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand command = new MySqlCommand(@"SELECT Turu, COUNT(*) AS KitapSayisi
                                                FROM lib_emanetler
                                                INNER JOIN lib_kitaplar ON lib_kitaplar.İD = lib_emanetler.KitapID
                                                GROUP BY Turu
                                                ORDER BY COUNT(*) DESC
                                                LIMIT 5", dbConnection.connection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // PieChart veri serisini oluştur
                SeriesCollection series = new SeriesCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    string kitapTuru = row["Turu"].ToString();
                    int kitapSayisi = Convert.ToInt32(row["KitapSayisi"]);

                    // Veri serisi oluştur ve kitap türünü ve kitap sayısını ekle
                    var pieSeries = new PieSeries
                    {
                        Title = kitapTuru,
                        Values = new ChartValues<int> { kitapSayisi },
                    };

                    series.Add(pieSeries);
                }

                // Grafik nesnesini oluştur
                pieChartKitapTurleri.Series = series;
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
        public void Yenilet() //Diğer user kontrollerde yeniletme işlemini sağlar.
        {
            ToplamStatistics();


            //Verileri siliyoruz
            chartTopKitaplar.AxisX.Clear();
            chartTopKitaplar.AxisY.Clear();
            chartTopKitaplar.Series.Clear();

            chartTopOkuyucular.AxisX.Clear();
            chartTopOkuyucular.AxisY.Clear();
            chartTopOkuyucular.Series.Clear();

            pieChartYazarlar.Series.Clear();
            pieChartKitapTurleri.Series.Clear();

            //Tekrardan grafik verilerini dolduran metodları çağırıyoruz
            chartOkuyucularLoad();
            chartKitaplarLoad();
            pieChartYazarlarLoad();
            pieChartKitapTurlerLoad();

            //Ayrıca DataGridView'leri de yenile
            dgLoad();
        }
        void dgLoad() //dataGridView'leri doldurur.
        {
            try
            {
                dbConnection.OpenConnection();

                MySqlCommand mevcutKitaplarCommand = new MySqlCommand($"SELECT * FROM lib_kitaplar WHERE durum = 1", dbConnection.connection);

                MySqlDataAdapter mevcutKitaplarAdapter = new MySqlDataAdapter(mevcutKitaplarCommand);
                DataTable mevcutKitaplarTable = new DataTable();
                mevcutKitaplarAdapter.Fill(mevcutKitaplarTable);

                dgMevcutKitaplar.DataSource = mevcutKitaplarTable;
                dgMevcutKitaplar.Columns["İD"].Visible = false;
                dgMevcutKitaplar.Columns["KayitNo"].HeaderText = "Kayıt Numarası";
                dgMevcutKitaplar.Columns["KitapAdi"].HeaderText = "Kitap Adı";
                dgMevcutKitaplar.Columns[2].Width = 150;
                dgMevcutKitaplar.Columns[3].Width = 100;
                dgMevcutKitaplar.Columns["YazarAdi"].HeaderText = "Yazar Adı";
                dgMevcutKitaplar.Columns["YayinEvi"].HeaderText = "Yayınevi Adı";
                dgMevcutKitaplar.Columns["BasimYili"].HeaderText = "Basım Yılı";
                dgMevcutKitaplar.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
                dgMevcutKitaplar.Columns["Turu"].HeaderText = "Türü";
                dgMevcutKitaplar.Columns["Aciklama"].HeaderText = "Açıklama";
                dgMevcutKitaplar.Columns["Dolap"].HeaderText = "Dolap";
                dgMevcutKitaplar.Columns["Raf"].HeaderText = "Raf";
                dgMevcutKitaplar.Columns["Sira"].HeaderText = "Sıra";
                dgMevcutKitaplar.Columns["durum"].Visible = false;
                MySqlCommand emanetKitaplarCommand = new MySqlCommand($"SELECT * FROM lib_kitaplar WHERE durum = 0", dbConnection.connection);

                MySqlDataAdapter emanetKitaplarAdapter = new MySqlDataAdapter(emanetKitaplarCommand);
                DataTable emanetKitaplarTable = new DataTable();
                emanetKitaplarAdapter.Fill(emanetKitaplarTable);

                dgEmanetKitaplar.DataSource = emanetKitaplarTable;
                dgEmanetKitaplar.Columns["İD"].Visible = false;
                dgEmanetKitaplar.Columns["KayitNo"].HeaderText = "Kayıt Numarası";
                dgEmanetKitaplar.Columns["KitapAdi"].HeaderText = "Kitap Adı";
                dgEmanetKitaplar.Columns[2].Width = 150;
                dgEmanetKitaplar.Columns[3].Width = 100;
                dgEmanetKitaplar.Columns["YazarAdi"].HeaderText = "Yazar Adı";
                dgEmanetKitaplar.Columns["YayinEvi"].HeaderText = "Yayınevi Adı";
                dgEmanetKitaplar.Columns["BasimYili"].HeaderText = "Basım Yılı";
                dgEmanetKitaplar.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
                dgEmanetKitaplar.Columns["Turu"].HeaderText = "Türü";
                dgEmanetKitaplar.Columns["Aciklama"].HeaderText = "Açıklama";
                dgEmanetKitaplar.Columns["Dolap"].HeaderText = "Dolap";
                dgEmanetKitaplar.Columns["Raf"].HeaderText = "Raf";
                dgEmanetKitaplar.Columns["Sira"].HeaderText = "Sıra";
                dgEmanetKitaplar.Columns["durum"].Visible = false;
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
}