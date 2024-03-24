<br/>
<p align="center">
  <h3 align="center">C# - Kütüphane Otomasyonu Sistemi</h3>

  <p align="center">
    Windows Form Application ile geliştirildi.
    <br/>
    <br/>
    <a href="https://github.com/drawsl/csharp-kutuphane-otomasyonu/issues">Hata Bildir</a>
    .
    <a href="https://github.com/drawsl/csharp-kutuphane-otomasyonu/issues">Özellik Talep Et</a>
  </p>
</p>

<p align="center">
  <img src="https://img.shields.io/github/contributors/drawsl/csharp-kutuphane-otomasyonu?color=dark-green">
  <img src="https://img.shields.io/github/forks/drawsl/csharp-kutuphane-otomasyonu?style=social">
  <img src="https://img.shields.io/github/issues/drawsl/csharp-kutuphane-otomasyonu">
  <img src="https://img.shields.io/github/license/drawsl/csharp-kutuphane-otomasyonu">
</p>

## Proje Hakkında
* Kutuphane Otomasyonu, kütüphane yönetimi için bir yazılım uygulamasıdır. Bu uygulama, kütüphanenin kaynaklarını yönetmek, kullanıcıların kayıtlarını tutmak, kitap ödünç alma ve iade işlemlerini izlemek ve kütüphane personeli için kullanışlı araçlar sağlamak amacıyla geliştirilmiştir.

* Bu proje, kütüphane yönetimi alanında verimliliği artırmak ve iş süreçlerini optimize etmek için kullanılabilir. Ayrıca, proje özelleştirilerek farklı kütüphane ihtiyaçlarına uygun hale getirilebilir veya yeni özellikler eklenerek genişletilebilir.

#### Teknolojiler:

* C# Programlama dili kullanılarak Windows Forms uygulaması geliştirilmiştir.

* MySQL veritabanı kullanılmıştır.

* MD5 (Message-Digest algorithm 5) şifreleme kullanılmıştır.

* Geliştirme ortamı olarak Visual Studio IDE kullanılmıştır.

#### Kullanılan NuGet Paketleri
* FontAwesome.Sharp
* Guna.UI2.WinForms (Deneme Sürümü)
* LiveCharts
* MySql.Data

#### Özellikleri
* Kullanıcı Yönetimi: Kütüphane kullanıcılarının (okuyucuların) kayıtlarını tutar.
* Kitap Yönetimi: Kütüphanedeki kitapların kayıtlarını içerir.
* Ödünç Alma ve İade İşlemleri: Kullanıcıların kitap ödünç alma ve iade işlemlerini izler.
* Yetkili Giriş Kayıtları: Yetkililerin (personel) oturum açma kayıtlarını saklar.
* İstatistikler: Kütüphane ile ilgili çeşitli istatistiklerin gösterildiği bir gösterge tablosu sağlar.
* Kullanıcı Arayüzü: Kullanıcı dostu bir arayüzle kütüphane personelinin uygulamayı kolayca kullanmasını sağlar.

### Resimler
##### Kayıt/Giriş İşlemleri
<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Kay%C4%B1t%20Ekran%C4%B1.png">

<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Giris%20Ekran%C4%B1.png">

##### Gösterge Paneli
<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Gosterge%20Paneli.png">

##### Kitap İşlemleri
<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Kitap%20Ekle.png">

<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Kitap%20Bilgi%20Girisi.png">

##### Okuyucu İşlemleri
<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Okuyucu%20Ekle.png">

##### Emanet İşlemleri
<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Emanet%20%C4%B0slemleri.png">

##### Kütüphane Ayarları
<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Kutuphane%20Ayarlari.png">

##### Yetkili Ayarları
<img src="https://raw.githubusercontent.com/drawsl/csharp-kutuphane-otomasyonu/master/images/Yetkili%20Ayarlari.png">

## Kurulum

1. **MySQL Sunucusu Kurulumu**:
   - Bilgisayarınıza XAMPP veya benzeri bir MySQL sunucusu kurun.
   - Kurulum tamamlandıktan sonra MySQL sunucusunu başlatın.

2. **Veritabanı Oluşturma**:
   - Proje dosyalarının içinde bulunan `library_data.sql` dosyasını kullanarak bir veritabanı oluşturun.
   - Veritabanı oluşturmak için phpMyAdmin arayüzünü kullanabilir veya komut satırını tercih edebilirsiniz.

1. **Bağlantı Ayarlarını Güncelleme**:
   - Projedeki bağlantı ayarlarını güncellemek için, Visual Studio'da Solution Explorer penceresini açın.
   - Solution Explorer'da `Classes` klasörünü ve ardından `connection.cs` dosyasını bulun.
   - Dosya içinde, bağlantı cümlesinin bulunduğu satırı bulun. Genellikle bu satır `string connectionString = "server=localhost;database=library_data;user=root;password=";` şeklinde olacaktır.
   - Bağlantı cümlesini, MySQL sunucunuzun kurulumuna ve kullanıcı bilgilerinize göre güncelleyin. Örneğin, eğer MySQL sunucunuzda farklı bir kullanıcı adı ve şifre kullanıyorsanız ve veritabanı adı `library_data` ise, bağlantı cümlenizi şu şekilde güncelleyebilirsiniz:
     ```
     string connectionString = "server=your_server;database=library_data;user=your_username;password=your_password;";
     ```
     Burada `your_server` kısmını MySQL sunucunuzun adresi veya IP'si ile değiştirmeniz gerekecek. `your_username` ve `your_password` kısımlarını MySQL sunucusuna erişmek için kullandığınız kullanıcı adı ve şifre ile değiştirmelisiniz.
   - Yeni bağlantı cümlesini belirledikten sonra, dosyayı kaydedin ve Visual Studio'da değişiklikleri uygulayın.

4. **Projeyi Başlatma**:
   - Proje dosyalarını Visual Studio veya tercih ettiğiniz bir IDE ile açın.
   - Projeyi derleyin ve başlatın.


## Lisans

* GPL-v3 Lisansı altında dağıtılmaktadır. Daha fazla bilgi için [LİSANS](https://github.com/drawsl/csharp-kutuphane-otomasyonu/blob/master/LICENSE) dosyasına bakınız..
## Yapımcılar

* **[drawsly](https://github.com/drawsl)** - *10. Sınıf Bilişim Teknolojileri* - [Enes Yasin Divrengi](https://enesyasin.com.tr) - *Mehmet Akif Ersoy Çok Programlı Anadolu Lisesi*
