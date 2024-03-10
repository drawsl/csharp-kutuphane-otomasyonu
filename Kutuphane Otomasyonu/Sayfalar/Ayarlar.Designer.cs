namespace Kutuphane_Otomasyonu.Sayfalar
{
    partial class Ayarlar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pictProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.lblMevcutSifre = new System.Windows.Forms.Label();
            this.txtMevcutSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSifreKontrolEt = new Guna.UI2.WinForms.Guna2Button();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSifreDegistir = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.AutoSize = true;
            this.lbl_Title2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title2.Location = new System.Drawing.Point(261, 20);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(98, 20);
            this.lbl_Title2.TabIndex = 7;
            this.lbl_Title2.Text = "Yetkili Ayarları";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title.Location = new System.Drawing.Point(10, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(247, 30);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Kütüphane Otomasyonu";
            // 
            // pictProfile
            // 
            this.pictProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictProfile.Image")));
            this.pictProfile.ImageRotate = 0F;
            this.pictProfile.Location = new System.Drawing.Point(27, 87);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.ShadowDecoration.Depth = 20;
            this.pictProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProfile.Size = new System.Drawing.Size(101, 97);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictProfile.TabIndex = 8;
            this.pictProfile.TabStop = false;
            this.pictProfile.Click += new System.EventHandler(this.pictProfile_Click);
            this.pictProfile.MouseEnter += new System.EventHandler(this.pictProfile_MouseEnter);
            this.pictProfile.MouseLeave += new System.EventHandler(this.pictProfile_MouseLeave);
            // 
            // txtAd
            // 
            this.txtAd.Animated = true;
            this.txtAd.BorderThickness = 2;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.DefaultText = "";
            this.txtAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAd.Location = new System.Drawing.Point(141, 87);
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAd.PlaceholderText = "";
            this.txtAd.SelectedText = "";
            this.txtAd.Size = new System.Drawing.Size(160, 34);
            this.txtAd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAd.TabIndex = 0;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.Color.Black;
            this.lblAdi.Location = new System.Drawing.Point(137, 64);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(52, 20);
            this.lblAdi.TabIndex = 15;
            this.lblAdi.Text = "Adı (*)";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblSoyadi.Location = new System.Drawing.Point(303, 64);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(74, 20);
            this.lblSoyadi.TabIndex = 15;
            this.lblSoyadi.Text = "Soyadı (*)";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Animated = true;
            this.txtSoyad.BorderThickness = 2;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.DefaultText = "";
            this.txtSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyad.Location = new System.Drawing.Point(307, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSoyad.PlaceholderText = "";
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.Size = new System.Drawing.Size(160, 34);
            this.txtSoyad.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoyad.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(137, 140);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(112, 20);
            this.lblKullaniciAdi.TabIndex = 15;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı (*)";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Animated = true;
            this.txtKullaniciAdi.BorderThickness = 2;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.DefaultText = "";
            this.txtKullaniciAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKullaniciAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKullaniciAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKullaniciAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(141, 163);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.PlaceholderText = "";
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(160, 34);
            this.txtKullaniciAdi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Animated = true;
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BorderRadius = 6;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.Green;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(27)))));
            this.btnKaydet.Location = new System.Drawing.Point(835, 562);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 49);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblMevcutSifre
            // 
            this.lblMevcutSifre.AutoSize = true;
            this.lblMevcutSifre.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblMevcutSifre.Location = new System.Drawing.Point(137, 215);
            this.lblMevcutSifre.Name = "lblMevcutSifre";
            this.lblMevcutSifre.Size = new System.Drawing.Size(130, 20);
            this.lblMevcutSifre.TabIndex = 15;
            this.lblMevcutSifre.Text = "Mevcut Şifreniz (*)";
            // 
            // txtMevcutSifre
            // 
            this.txtMevcutSifre.Animated = true;
            this.txtMevcutSifre.BorderThickness = 2;
            this.txtMevcutSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMevcutSifre.DefaultText = "";
            this.txtMevcutSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMevcutSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMevcutSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMevcutSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMevcutSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMevcutSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMevcutSifre.ForeColor = System.Drawing.Color.Black;
            this.txtMevcutSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMevcutSifre.Location = new System.Drawing.Point(141, 238);
            this.txtMevcutSifre.Name = "txtMevcutSifre";
            this.txtMevcutSifre.PasswordChar = '●';
            this.txtMevcutSifre.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMevcutSifre.PlaceholderText = "";
            this.txtMevcutSifre.SelectedText = "";
            this.txtMevcutSifre.Size = new System.Drawing.Size(160, 34);
            this.txtMevcutSifre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMevcutSifre.TabIndex = 3;
            // 
            // btnSifreKontrolEt
            // 
            this.btnSifreKontrolEt.Animated = true;
            this.btnSifreKontrolEt.BackColor = System.Drawing.Color.Transparent;
            this.btnSifreKontrolEt.BorderRadius = 6;
            this.btnSifreKontrolEt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreKontrolEt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreKontrolEt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSifreKontrolEt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSifreKontrolEt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(191)))));
            this.btnSifreKontrolEt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSifreKontrolEt.ForeColor = System.Drawing.Color.White;
            this.btnSifreKontrolEt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(134)))));
            this.btnSifreKontrolEt.Location = new System.Drawing.Point(307, 238);
            this.btnSifreKontrolEt.Name = "btnSifreKontrolEt";
            this.btnSifreKontrolEt.Size = new System.Drawing.Size(116, 34);
            this.btnSifreKontrolEt.TabIndex = 4;
            this.btnSifreKontrolEt.Text = "Kontrol Et";
            this.btnSifreKontrolEt.Click += new System.EventHandler(this.btnSifreKontrol_Click);
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblYeniSifre.Location = new System.Drawing.Point(137, 293);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(70, 20);
            this.lblYeniSifre.TabIndex = 15;
            this.lblYeniSifre.Text = "Yeni Şifre";
            this.lblYeniSifre.Visible = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Animated = true;
            this.txtSifre.BorderThickness = 2;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultText = "";
            this.txtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.Location = new System.Drawing.Point(141, 316);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSifre.PlaceholderText = "";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(160, 34);
            this.txtSifre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSifre.TabIndex = 5;
            this.txtSifre.Visible = false;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Animated = true;
            this.btnSifreDegistir.BackColor = System.Drawing.Color.Transparent;
            this.btnSifreDegistir.BorderRadius = 6;
            this.btnSifreDegistir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreDegistir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSifreDegistir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSifreDegistir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSifreDegistir.FillColor = System.Drawing.Color.Green;
            this.btnSifreDegistir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSifreDegistir.ForeColor = System.Drawing.Color.White;
            this.btnSifreDegistir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(27)))));
            this.btnSifreDegistir.Location = new System.Drawing.Point(163, 356);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(116, 34);
            this.btnSifreDegistir.TabIndex = 16;
            this.btnSifreDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreDegistir.Visible = false;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnSifreKontrolEt);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtMevcutSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblMevcutSifre);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.pictProfile);
            this.Controls.Add(this.lbl_Title2);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Ayarlar";
            this.Size = new System.Drawing.Size(962, 625);
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProfile;
        private Guna.UI2.WinForms.Guna2TextBox txtAd;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyad;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdi;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private System.Windows.Forms.Label lblMevcutSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtMevcutSifre;
        private Guna.UI2.WinForms.Guna2Button btnSifreKontrolEt;
        private System.Windows.Forms.Label lblYeniSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2Button btnSifreDegistir;
    }
}
