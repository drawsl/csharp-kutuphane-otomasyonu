namespace Kutuphane_Otomasyonu.Forms
{
    partial class AnaSayfa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.separator_1 = new Guna.UI2.WinForms.Guna2Separator();
            this.sideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_KutuphaneAyarlar = new FontAwesome.Sharp.IconButton();
            this.panelYetkili = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_YetkiliAyarlar = new FontAwesome.Sharp.IconButton();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.pictProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_Emanetİslemleri = new FontAwesome.Sharp.IconButton();
            this.panel_Okuyucuİslemleri = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_OkuyucuEkle = new FontAwesome.Sharp.IconButton();
            this.btn_Okuyucuİslemleri = new FontAwesome.Sharp.IconButton();
            this.panel_Kitapİslemleri = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_KitapBilgi = new FontAwesome.Sharp.IconButton();
            this.btn_KitapEkle = new FontAwesome.Sharp.IconButton();
            this.btn_Kitapİslemleri = new FontAwesome.Sharp.IconButton();
            this.btnAnaSayfa = new FontAwesome.Sharp.IconButton();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.sideBar_logo = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.sideBar_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAyarlarElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sideBar.SuspendLayout();
            this.panelYetkili.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.panel_Okuyucuİslemleri.SuspendLayout();
            this.panel_Kitapİslemleri.SuspendLayout();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Title.Location = new System.Drawing.Point(77, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(152, 20);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Kütüphane Yönetimi";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // separator_1
            // 
            this.separator_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separator_1.Location = new System.Drawing.Point(17, 56);
            this.separator_1.Name = "separator_1";
            this.separator_1.Size = new System.Drawing.Size(221, 10);
            this.separator_1.TabIndex = 4;
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideBar.Controls.Add(this.btn_KutuphaneAyarlar);
            this.sideBar.Controls.Add(this.panelYetkili);
            this.sideBar.Controls.Add(this.btn_Emanetİslemleri);
            this.sideBar.Controls.Add(this.panel_Okuyucuİslemleri);
            this.sideBar.Controls.Add(this.btn_Okuyucuİslemleri);
            this.sideBar.Controls.Add(this.panel_Kitapİslemleri);
            this.sideBar.Controls.Add(this.btn_Kitapİslemleri);
            this.sideBar.Controls.Add(this.btnAnaSayfa);
            this.sideBar.Controls.Add(this.panel_Title);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(254, 625);
            this.sideBar.TabIndex = 4;
            // 
            // btn_KutuphaneAyarlar
            // 
            this.btn_KutuphaneAyarlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_KutuphaneAyarlar.FlatAppearance.BorderSize = 0;
            this.btn_KutuphaneAyarlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_KutuphaneAyarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_KutuphaneAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KutuphaneAyarlar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KutuphaneAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_KutuphaneAyarlar.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btn_KutuphaneAyarlar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_KutuphaneAyarlar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_KutuphaneAyarlar.IconSize = 30;
            this.btn_KutuphaneAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KutuphaneAyarlar.Location = new System.Drawing.Point(0, 529);
            this.btn_KutuphaneAyarlar.Name = "btn_KutuphaneAyarlar";
            this.btn_KutuphaneAyarlar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_KutuphaneAyarlar.Size = new System.Drawing.Size(254, 42);
            this.btn_KutuphaneAyarlar.TabIndex = 14;
            this.btn_KutuphaneAyarlar.Text = "Kütüphane Ayarları";
            this.btn_KutuphaneAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KutuphaneAyarlar.UseVisualStyleBackColor = true;
            this.btn_KutuphaneAyarlar.Click += new System.EventHandler(this.btn_KutuphaneAyarlar_Click);
            // 
            // panelYetkili
            // 
            this.panelYetkili.Controls.Add(this.btn_YetkiliAyarlar);
            this.panelYetkili.Controls.Add(this.lblAdSoyad);
            this.panelYetkili.Controls.Add(this.lblNickName);
            this.panelYetkili.Controls.Add(this.pictProfile);
            this.panelYetkili.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelYetkili.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelYetkili.Location = new System.Drawing.Point(0, 571);
            this.panelYetkili.Name = "panelYetkili";
            this.panelYetkili.Size = new System.Drawing.Size(254, 54);
            this.panelYetkili.TabIndex = 7;
            // 
            // btn_YetkiliAyarlar
            // 
            this.btn_YetkiliAyarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_YetkiliAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_YetkiliAyarlar.FlatAppearance.BorderSize = 0;
            this.btn_YetkiliAyarlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_YetkiliAyarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_YetkiliAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YetkiliAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_YetkiliAyarlar.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btn_YetkiliAyarlar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_YetkiliAyarlar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_YetkiliAyarlar.IconSize = 25;
            this.btn_YetkiliAyarlar.Location = new System.Drawing.Point(215, 12);
            this.btn_YetkiliAyarlar.Name = "btn_YetkiliAyarlar";
            this.btn_YetkiliAyarlar.Size = new System.Drawing.Size(30, 30);
            this.btn_YetkiliAyarlar.TabIndex = 4;
            this.btn_YetkiliAyarlar.UseVisualStyleBackColor = false;
            this.btn_YetkiliAyarlar.Click += new System.EventHandler(this.btn_Ayarlar_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(62, 7);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(85, 20);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad - Soyad";
            this.lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNickName
            // 
            this.lblNickName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNickName.AutoSize = true;
            this.lblNickName.BackColor = System.Drawing.Color.Transparent;
            this.lblNickName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNickName.ForeColor = System.Drawing.Color.LightGray;
            this.lblNickName.Location = new System.Drawing.Point(62, 32);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(71, 17);
            this.lblNickName.TabIndex = 2;
            this.lblNickName.Text = "KullanıcıAdı";
            this.lblNickName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictProfile
            // 
            this.pictProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictProfile.FillColor = System.Drawing.Color.Transparent;
            this.pictProfile.Image = global::Kutuphane_Otomasyonu.Properties.Resources.user;
            this.pictProfile.ImageRotate = 0F;
            this.pictProfile.Location = new System.Drawing.Point(17, 6);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProfile.Size = new System.Drawing.Size(40, 40);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProfile.TabIndex = 3;
            this.pictProfile.TabStop = false;
            this.pictProfile.UseTransparentBackground = true;
            // 
            // btn_Emanetİslemleri
            // 
            this.btn_Emanetİslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Emanetİslemleri.FlatAppearance.BorderSize = 0;
            this.btn_Emanetİslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_Emanetİslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_Emanetİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Emanetİslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Emanetİslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Emanetİslemleri.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btn_Emanetİslemleri.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Emanetİslemleri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Emanetİslemleri.IconSize = 30;
            this.btn_Emanetİslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Emanetİslemleri.Location = new System.Drawing.Point(0, 287);
            this.btn_Emanetİslemleri.Name = "btn_Emanetİslemleri";
            this.btn_Emanetİslemleri.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Emanetİslemleri.Size = new System.Drawing.Size(254, 42);
            this.btn_Emanetİslemleri.TabIndex = 13;
            this.btn_Emanetİslemleri.Text = "Emanet İşlemleri";
            this.btn_Emanetİslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Emanetİslemleri.UseVisualStyleBackColor = true;
            this.btn_Emanetİslemleri.Click += new System.EventHandler(this.btn_Emanetİslemleri_Click);
            // 
            // panel_Okuyucuİslemleri
            // 
            this.panel_Okuyucuİslemleri.BackColor = System.Drawing.Color.Transparent;
            this.panel_Okuyucuİslemleri.Controls.Add(this.btn_OkuyucuEkle);
            this.panel_Okuyucuİslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Okuyucuİslemleri.Location = new System.Drawing.Point(0, 257);
            this.panel_Okuyucuİslemleri.Name = "panel_Okuyucuİslemleri";
            this.panel_Okuyucuİslemleri.Size = new System.Drawing.Size(254, 30);
            this.panel_Okuyucuİslemleri.TabIndex = 12;
            this.panel_Okuyucuİslemleri.TabStop = true;
            // 
            // btn_OkuyucuEkle
            // 
            this.btn_OkuyucuEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_OkuyucuEkle.FlatAppearance.BorderSize = 0;
            this.btn_OkuyucuEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_OkuyucuEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_OkuyucuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OkuyucuEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OkuyucuEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.btn_OkuyucuEkle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_OkuyucuEkle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.btn_OkuyucuEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_OkuyucuEkle.IconSize = 30;
            this.btn_OkuyucuEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OkuyucuEkle.Location = new System.Drawing.Point(0, 0);
            this.btn_OkuyucuEkle.Name = "btn_OkuyucuEkle";
            this.btn_OkuyucuEkle.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_OkuyucuEkle.Size = new System.Drawing.Size(254, 30);
            this.btn_OkuyucuEkle.TabIndex = 12;
            this.btn_OkuyucuEkle.TabStop = false;
            this.btn_OkuyucuEkle.Text = "• Okuyucu Ekle";
            this.btn_OkuyucuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_OkuyucuEkle.UseVisualStyleBackColor = true;
            this.btn_OkuyucuEkle.Click += new System.EventHandler(this.btn_OkuyucuEkle_Click);
            // 
            // btn_Okuyucuİslemleri
            // 
            this.btn_Okuyucuİslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Okuyucuİslemleri.FlatAppearance.BorderSize = 0;
            this.btn_Okuyucuİslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_Okuyucuİslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_Okuyucuİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Okuyucuİslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Okuyucuİslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Okuyucuİslemleri.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_Okuyucuİslemleri.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Okuyucuİslemleri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Okuyucuİslemleri.IconSize = 30;
            this.btn_Okuyucuİslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Okuyucuİslemleri.Location = new System.Drawing.Point(0, 215);
            this.btn_Okuyucuİslemleri.Name = "btn_Okuyucuİslemleri";
            this.btn_Okuyucuİslemleri.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Okuyucuİslemleri.Size = new System.Drawing.Size(254, 42);
            this.btn_Okuyucuİslemleri.TabIndex = 11;
            this.btn_Okuyucuİslemleri.Text = "Okuyucu İşlemleri   ˃";
            this.btn_Okuyucuİslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Okuyucuİslemleri.UseVisualStyleBackColor = true;
            this.btn_Okuyucuİslemleri.Click += new System.EventHandler(this.btn_Okuyucuİslemleri_Click);
            // 
            // panel_Kitapİslemleri
            // 
            this.panel_Kitapİslemleri.BackColor = System.Drawing.Color.Transparent;
            this.panel_Kitapİslemleri.Controls.Add(this.btn_KitapBilgi);
            this.panel_Kitapİslemleri.Controls.Add(this.btn_KitapEkle);
            this.panel_Kitapİslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Kitapİslemleri.Location = new System.Drawing.Point(0, 153);
            this.panel_Kitapİslemleri.Name = "panel_Kitapİslemleri";
            this.panel_Kitapİslemleri.Size = new System.Drawing.Size(254, 62);
            this.panel_Kitapİslemleri.TabIndex = 10;
            this.panel_Kitapİslemleri.TabStop = true;
            // 
            // btn_KitapBilgi
            // 
            this.btn_KitapBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KitapBilgi.FlatAppearance.BorderSize = 0;
            this.btn_KitapBilgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_KitapBilgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_KitapBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapBilgi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.btn_KitapBilgi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_KitapBilgi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.btn_KitapBilgi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_KitapBilgi.IconSize = 30;
            this.btn_KitapBilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KitapBilgi.Location = new System.Drawing.Point(0, 30);
            this.btn_KitapBilgi.Name = "btn_KitapBilgi";
            this.btn_KitapBilgi.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_KitapBilgi.Size = new System.Drawing.Size(254, 30);
            this.btn_KitapBilgi.TabIndex = 16;
            this.btn_KitapBilgi.TabStop = false;
            this.btn_KitapBilgi.Text = "• Kitap Bilgi Girişi Ekle";
            this.btn_KitapBilgi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KitapBilgi.UseVisualStyleBackColor = true;
            this.btn_KitapBilgi.Click += new System.EventHandler(this.btn_KitapBilgi_Click);
            // 
            // btn_KitapEkle
            // 
            this.btn_KitapEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_KitapEkle.FlatAppearance.BorderSize = 0;
            this.btn_KitapEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_KitapEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_KitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.btn_KitapEkle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_KitapEkle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(155)))));
            this.btn_KitapEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_KitapEkle.IconSize = 30;
            this.btn_KitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KitapEkle.Location = new System.Drawing.Point(0, 0);
            this.btn_KitapEkle.Name = "btn_KitapEkle";
            this.btn_KitapEkle.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_KitapEkle.Size = new System.Drawing.Size(254, 30);
            this.btn_KitapEkle.TabIndex = 15;
            this.btn_KitapEkle.TabStop = false;
            this.btn_KitapEkle.Text = "• Kitap Ekle";
            this.btn_KitapEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KitapEkle.UseVisualStyleBackColor = true;
            this.btn_KitapEkle.Click += new System.EventHandler(this.btn_KitapEkle_Click);
            // 
            // btn_Kitapİslemleri
            // 
            this.btn_Kitapİslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Kitapİslemleri.FlatAppearance.BorderSize = 0;
            this.btn_Kitapİslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_Kitapİslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btn_Kitapİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kitapİslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kitapİslemleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Kitapİslemleri.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_Kitapİslemleri.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Kitapİslemleri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Kitapİslemleri.IconSize = 30;
            this.btn_Kitapİslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kitapİslemleri.Location = new System.Drawing.Point(0, 111);
            this.btn_Kitapİslemleri.Name = "btn_Kitapİslemleri";
            this.btn_Kitapİslemleri.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Kitapİslemleri.Size = new System.Drawing.Size(254, 42);
            this.btn_Kitapİslemleri.TabIndex = 9;
            this.btn_Kitapİslemleri.Text = "Kitap İşlemleri         ˃";
            this.btn_Kitapİslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Kitapİslemleri.UseVisualStyleBackColor = true;
            this.btn_Kitapİslemleri.Click += new System.EventHandler(this.btn_Kitapİslemleri_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnAnaSayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnaSayfa.IconChar = FontAwesome.Sharp.IconChar.Grip;
            this.btnAnaSayfa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnaSayfa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnaSayfa.IconSize = 30;
            this.btnAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaSayfa.Location = new System.Drawing.Point(0, 69);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAnaSayfa.Size = new System.Drawing.Size(254, 42);
            this.btnAnaSayfa.TabIndex = 5;
            this.btnAnaSayfa.Text = "Gösterge Paneli";
            this.btnAnaSayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.sideBar_logo);
            this.panel_Title.Controls.Add(this.lbl_Title);
            this.panel_Title.Controls.Add(this.lbl_Version);
            this.panel_Title.Controls.Add(this.separator_1);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(254, 69);
            this.panel_Title.TabIndex = 6;
            // 
            // sideBar_logo
            // 
            this.sideBar_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideBar_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideBar_logo.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.sideBar_logo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sideBar_logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sideBar_logo.IconSize = 38;
            this.sideBar_logo.Location = new System.Drawing.Point(27, 13);
            this.sideBar_logo.Name = "sideBar_logo";
            this.sideBar_logo.Size = new System.Drawing.Size(43, 38);
            this.sideBar_logo.TabIndex = 5;
            this.sideBar_logo.TabStop = false;
            // 
            // lbl_Version
            // 
            this.lbl_Version.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Version.Location = new System.Drawing.Point(76, 33);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(155, 15);
            this.lbl_Version.TabIndex = 2;
            this.lbl_Version.Text = "Contributed by Enes Yasin v0.1";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sideBar_Panel
            // 
            this.sideBar_Panel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.sideBar_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar_Panel.ForeColor = System.Drawing.Color.Black;
            this.sideBar_Panel.Location = new System.Drawing.Point(254, 0);
            this.sideBar_Panel.Name = "sideBar_Panel";
            this.sideBar_Panel.Size = new System.Drawing.Size(962, 625);
            this.sideBar_Panel.TabIndex = 6;
            // 
            // btnAyarlarElipse
            // 
            this.btnAyarlarElipse.BorderRadius = 10;
            this.btnAyarlarElipse.TargetControl = this.btn_YetkiliAyarlar;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1216, 625);
            this.Controls.Add(this.sideBar_Panel);
            this.Controls.Add(this.sideBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.sideBar.ResumeLayout(false);
            this.panelYetkili.ResumeLayout(false);
            this.panelYetkili.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.panel_Okuyucuİslemleri.ResumeLayout(false);
            this.panel_Kitapİslemleri.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideBar_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel sideBar;
        private Guna.UI2.WinForms.Guna2Separator separator_1;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2Panel sideBar_Panel;
        private System.Windows.Forms.Label lbl_Version;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private FontAwesome.Sharp.IconPictureBox sideBar_logo;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblNickName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProfile;
        private Guna.UI2.WinForms.Guna2Panel panelYetkili;
        private FontAwesome.Sharp.IconButton btn_Emanetİslemleri;
        private Guna.UI2.WinForms.Guna2Panel panel_Okuyucuİslemleri;
        private FontAwesome.Sharp.IconButton btn_OkuyucuEkle;
        private FontAwesome.Sharp.IconButton btn_Okuyucuİslemleri;
        private Guna.UI2.WinForms.Guna2Panel panel_Kitapİslemleri;
        private FontAwesome.Sharp.IconButton btn_KitapBilgi;
        private FontAwesome.Sharp.IconButton btn_KitapEkle;
        private FontAwesome.Sharp.IconButton btn_Kitapİslemleri;
        private FontAwesome.Sharp.IconButton btnAnaSayfa;
        private FontAwesome.Sharp.IconButton btn_YetkiliAyarlar;
        private Guna.UI2.WinForms.Guna2Elipse btnAyarlarElipse;
        private FontAwesome.Sharp.IconButton btn_KutuphaneAyarlar;
    }
}