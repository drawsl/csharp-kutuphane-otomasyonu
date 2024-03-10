namespace Kutuphane_Otomasyonu.Sayfalar
{
    partial class OkuyucuEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkuyucuEkle));
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSinifi = new System.Windows.Forms.Label();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.tableBilgiler = new System.Windows.Forms.TableLayoutPanel();
            this.txtAdres = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoyadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableCinsiyet = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnKiz = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioBtnErkek = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtSinifi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOkulNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCepTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableUst = new System.Windows.Forms.TableLayoutPanel();
            this.lblFotograf = new System.Windows.Forms.Label();
            this.tableButonlar = new System.Windows.Forms.TableLayoutPanel();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.dgOkuyucular = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtAra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureAra = new FontAwesome.Sharp.IconPictureBox();
            this.pictProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tableBilgiler.SuspendLayout();
            this.tableCinsiyet.SuspendLayout();
            this.tableUst.SuspendLayout();
            this.tableButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.AutoSize = true;
            this.lbl_Title2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title2.Location = new System.Drawing.Point(261, 20);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(95, 20);
            this.lbl_Title2.TabIndex = 3;
            this.lbl_Title2.Text = "Okuyucu Ekle";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title.Location = new System.Drawing.Point(10, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(247, 30);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Kütüphane Otomasyonu";
            // 
            // lblAdi
            // 
            this.lblAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblAdi.Location = new System.Drawing.Point(16, 10);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(55, 20);
            this.lblAdi.TabIndex = 13;
            this.lblAdi.Text = "Adı (*):";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblSoyadi.Location = new System.Drawing.Point(5, 50);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(77, 20);
            this.lblSoyadi.TabIndex = 13;
            this.lblSoyadi.Text = "Soyadı (*):";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblCinsiyet.Location = new System.Drawing.Point(10, 90);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(67, 20);
            this.lblCinsiyet.TabIndex = 13;
            this.lblCinsiyet.Text = "Cinsiyeti:";
            // 
            // lblSinifi
            // 
            this.lblSinifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSinifi.AutoSize = true;
            this.lblSinifi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblSinifi.Location = new System.Drawing.Point(11, 130);
            this.lblSinifi.Name = "lblSinifi";
            this.lblSinifi.Size = new System.Drawing.Size(65, 20);
            this.lblSinifi.TabIndex = 13;
            this.lblSinifi.Text = "Sınıfı (*):";
            // 
            // lblOkulNo
            // 
            this.lblOkulNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOkulNo.AutoSize = true;
            this.lblOkulNo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblOkulNo.Location = new System.Drawing.Point(3, 170);
            this.lblOkulNo.Name = "lblOkulNo";
            this.lblOkulNo.Size = new System.Drawing.Size(81, 19);
            this.lblOkulNo.TabIndex = 13;
            this.lblOkulNo.Text = "Okul No (*):";
            // 
            // lblCepTel
            // 
            this.lblCepTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblCepTel.Location = new System.Drawing.Point(3, 210);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(81, 20);
            this.lblCepTel.TabIndex = 13;
            this.lblCepTel.Text = "Cep Tel (*):";
            // 
            // lblAdres
            // 
            this.lblAdres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblAdres.Location = new System.Drawing.Point(19, 270);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(50, 20);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "Adres:";
            // 
            // tableBilgiler
            // 
            this.tableBilgiler.ColumnCount = 2;
            this.tableBilgiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableBilgiler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableBilgiler.Controls.Add(this.txtAdres, 1, 6);
            this.tableBilgiler.Controls.Add(this.txtAdi, 1, 0);
            this.tableBilgiler.Controls.Add(this.lblAdi, 0, 0);
            this.tableBilgiler.Controls.Add(this.lblAdres, 0, 6);
            this.tableBilgiler.Controls.Add(this.lblSoyadi, 0, 1);
            this.tableBilgiler.Controls.Add(this.lblCepTel, 0, 5);
            this.tableBilgiler.Controls.Add(this.lblCinsiyet, 0, 2);
            this.tableBilgiler.Controls.Add(this.lblOkulNo, 0, 4);
            this.tableBilgiler.Controls.Add(this.txtSoyadi, 1, 1);
            this.tableBilgiler.Controls.Add(this.tableCinsiyet, 1, 2);
            this.tableBilgiler.Controls.Add(this.txtSinifi, 1, 3);
            this.tableBilgiler.Controls.Add(this.txtOkulNo, 1, 4);
            this.tableBilgiler.Controls.Add(this.txtCepTel, 1, 5);
            this.tableBilgiler.Controls.Add(this.lblSinifi, 0, 3);
            this.tableBilgiler.Location = new System.Drawing.Point(5, 163);
            this.tableBilgiler.Name = "tableBilgiler";
            this.tableBilgiler.RowCount = 7;
            this.tableBilgiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBilgiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBilgiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBilgiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBilgiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBilgiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBilgiler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableBilgiler.Size = new System.Drawing.Size(252, 320);
            this.tableBilgiler.TabIndex = 14;
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdres.Animated = true;
            this.txtAdres.BorderThickness = 2;
            this.txtAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdres.DefaultText = "";
            this.txtAdres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdres.ForeColor = System.Drawing.Color.Black;
            this.txtAdres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdres.Location = new System.Drawing.Point(91, 243);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAdres.PlaceholderText = "";
            this.txtAdres.SelectedText = "";
            this.txtAdres.Size = new System.Drawing.Size(158, 74);
            this.txtAdres.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAdres.TabIndex = 6;
            // 
            // txtAdi
            // 
            this.txtAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdi.Animated = true;
            this.txtAdi.BorderThickness = 2;
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.DefaultText = "";
            this.txtAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdi.ForeColor = System.Drawing.Color.Black;
            this.txtAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdi.Location = new System.Drawing.Point(91, 3);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.PasswordChar = '\0';
            this.txtAdi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAdi.PlaceholderText = "";
            this.txtAdi.SelectedText = "";
            this.txtAdi.Size = new System.Drawing.Size(158, 34);
            this.txtAdi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAdi.TabIndex = 0;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoyadi.Animated = true;
            this.txtSoyadi.BorderThickness = 2;
            this.txtSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyadi.DefaultText = "";
            this.txtSoyadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoyadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoyadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyadi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoyadi.ForeColor = System.Drawing.Color.Black;
            this.txtSoyadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyadi.Location = new System.Drawing.Point(91, 43);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.PasswordChar = '\0';
            this.txtSoyadi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSoyadi.PlaceholderText = "";
            this.txtSoyadi.SelectedText = "";
            this.txtSoyadi.Size = new System.Drawing.Size(158, 34);
            this.txtSoyadi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoyadi.TabIndex = 1;
            // 
            // tableCinsiyet
            // 
            this.tableCinsiyet.ColumnCount = 2;
            this.tableCinsiyet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCinsiyet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCinsiyet.Controls.Add(this.radioBtnKiz, 1, 0);
            this.tableCinsiyet.Controls.Add(this.radioBtnErkek, 0, 0);
            this.tableCinsiyet.Location = new System.Drawing.Point(91, 83);
            this.tableCinsiyet.Name = "tableCinsiyet";
            this.tableCinsiyet.RowCount = 1;
            this.tableCinsiyet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCinsiyet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableCinsiyet.Size = new System.Drawing.Size(158, 34);
            this.tableCinsiyet.TabIndex = 2;
            // 
            // radioBtnKiz
            // 
            this.radioBtnKiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnKiz.Animated = true;
            this.radioBtnKiz.AutoSize = true;
            this.radioBtnKiz.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnKiz.CheckedState.BorderThickness = 0;
            this.radioBtnKiz.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnKiz.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnKiz.CheckedState.InnerOffset = -4;
            this.radioBtnKiz.Location = new System.Drawing.Point(99, 8);
            this.radioBtnKiz.Name = "radioBtnKiz";
            this.radioBtnKiz.Size = new System.Drawing.Size(39, 17);
            this.radioBtnKiz.TabIndex = 1;
            this.radioBtnKiz.Text = "Kız";
            this.radioBtnKiz.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnKiz.UncheckedState.BorderThickness = 2;
            this.radioBtnKiz.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnKiz.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioBtnErkek
            // 
            this.radioBtnErkek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnErkek.Animated = true;
            this.radioBtnErkek.AutoSize = true;
            this.radioBtnErkek.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnErkek.CheckedState.BorderThickness = 0;
            this.radioBtnErkek.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnErkek.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnErkek.CheckedState.InnerOffset = -4;
            this.radioBtnErkek.Location = new System.Drawing.Point(13, 8);
            this.radioBtnErkek.Name = "radioBtnErkek";
            this.radioBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.radioBtnErkek.TabIndex = 0;
            this.radioBtnErkek.Text = "Erkek";
            this.radioBtnErkek.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnErkek.UncheckedState.BorderThickness = 2;
            this.radioBtnErkek.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnErkek.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtSinifi
            // 
            this.txtSinifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSinifi.Animated = true;
            this.txtSinifi.BorderThickness = 2;
            this.txtSinifi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSinifi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSinifi.DefaultText = "";
            this.txtSinifi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSinifi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSinifi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSinifi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSinifi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSinifi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSinifi.ForeColor = System.Drawing.Color.Black;
            this.txtSinifi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSinifi.Location = new System.Drawing.Point(91, 123);
            this.txtSinifi.Name = "txtSinifi";
            this.txtSinifi.PasswordChar = '\0';
            this.txtSinifi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSinifi.PlaceholderText = "10-V";
            this.txtSinifi.SelectedText = "";
            this.txtSinifi.Size = new System.Drawing.Size(158, 34);
            this.txtSinifi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSinifi.TabIndex = 3;
            // 
            // txtOkulNo
            // 
            this.txtOkulNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOkulNo.Animated = true;
            this.txtOkulNo.BorderThickness = 2;
            this.txtOkulNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOkulNo.DefaultText = "";
            this.txtOkulNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOkulNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOkulNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOkulNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOkulNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOkulNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOkulNo.ForeColor = System.Drawing.Color.Black;
            this.txtOkulNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOkulNo.Location = new System.Drawing.Point(91, 163);
            this.txtOkulNo.Name = "txtOkulNo";
            this.txtOkulNo.PasswordChar = '\0';
            this.txtOkulNo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtOkulNo.PlaceholderText = " ";
            this.txtOkulNo.SelectedText = "";
            this.txtOkulNo.Size = new System.Drawing.Size(158, 34);
            this.txtOkulNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtOkulNo.TabIndex = 4;
            // 
            // txtCepTel
            // 
            this.txtCepTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCepTel.Animated = true;
            this.txtCepTel.BorderThickness = 2;
            this.txtCepTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCepTel.DefaultText = "";
            this.txtCepTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCepTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCepTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCepTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCepTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCepTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCepTel.ForeColor = System.Drawing.Color.Black;
            this.txtCepTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCepTel.Location = new System.Drawing.Point(91, 203);
            this.txtCepTel.MaxLength = 10;
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.PasswordChar = '\0';
            this.txtCepTel.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCepTel.PlaceholderText = "(___) ___-____";
            this.txtCepTel.SelectedText = "";
            this.txtCepTel.Size = new System.Drawing.Size(158, 34);
            this.txtCepTel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCepTel.TabIndex = 5;
            this.txtCepTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCepTel_KeyPress);
            // 
            // tableUst
            // 
            this.tableUst.ColumnCount = 2;
            this.tableUst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableUst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableUst.Controls.Add(this.lblFotograf, 0, 0);
            this.tableUst.Controls.Add(this.pictProfile, 1, 0);
            this.tableUst.Location = new System.Drawing.Point(5, 57);
            this.tableUst.Name = "tableUst";
            this.tableUst.RowCount = 1;
            this.tableUst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableUst.Size = new System.Drawing.Size(252, 103);
            this.tableUst.TabIndex = 0;
            // 
            // lblFotograf
            // 
            this.lblFotograf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFotograf.AutoSize = true;
            this.lblFotograf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFotograf.Location = new System.Drawing.Point(9, 41);
            this.lblFotograf.Name = "lblFotograf";
            this.lblFotograf.Size = new System.Drawing.Size(69, 20);
            this.lblFotograf.TabIndex = 14;
            this.lblFotograf.Text = "Fotoğraf:";
            // 
            // tableButonlar
            // 
            this.tableButonlar.ColumnCount = 3;
            this.tableButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33222F));
            this.tableButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33222F));
            this.tableButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33556F));
            this.tableButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButonlar.Controls.Add(this.btnKaydet, 0, 0);
            this.tableButonlar.Controls.Add(this.btnSil, 1, 0);
            this.tableButonlar.Controls.Add(this.btnTemizle, 2, 0);
            this.tableButonlar.Location = new System.Drawing.Point(5, 489);
            this.tableButonlar.Name = "tableButonlar";
            this.tableButonlar.RowCount = 1;
            this.tableButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButonlar.Size = new System.Drawing.Size(252, 40);
            this.tableButonlar.TabIndex = 16;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Animated = true;
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BorderRadius = 6;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKaydet.FillColor = System.Drawing.Color.Green;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(27)))));
            this.btnKaydet.Location = new System.Drawing.Point(3, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(77, 34);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Animated = true;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BorderRadius = 6;
            this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.FillColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(21)))), ((int)(((byte)(27)))));
            this.btnSil.Location = new System.Drawing.Point(86, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 34);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Animated = true;
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BorderRadius = 6;
            this.btnTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemizle.FillColor = System.Drawing.Color.White;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.Location = new System.Drawing.Point(169, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 34);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.AllowUserToAddRows = false;
            this.dgOkuyucular.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dgOkuyucular.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgOkuyucular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOkuyucular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgOkuyucular.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOkuyucular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgOkuyucular.ColumnHeadersHeight = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOkuyucular.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgOkuyucular.GridColor = System.Drawing.Color.DimGray;
            this.dgOkuyucular.Location = new System.Drawing.Point(263, 57);
            this.dgOkuyucular.MultiSelect = false;
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.ReadOnly = true;
            this.dgOkuyucular.RowHeadersVisible = false;
            this.dgOkuyucular.Size = new System.Drawing.Size(687, 472);
            this.dgOkuyucular.StandardTab = true;
            this.dgOkuyucular.TabIndex = 17;
            this.dgOkuyucular.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgOkuyucular.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgOkuyucular.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgOkuyucular.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgOkuyucular.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgOkuyucular.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgOkuyucular.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgOkuyucular.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dgOkuyucular.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgOkuyucular.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOkuyucular.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgOkuyucular.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgOkuyucular.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOkuyucular.ThemeStyle.HeaderStyle.Height = 15;
            this.dgOkuyucular.ThemeStyle.ReadOnly = true;
            this.dgOkuyucular.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgOkuyucular.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgOkuyucular.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgOkuyucular.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgOkuyucular.ThemeStyle.RowsStyle.Height = 22;
            this.dgOkuyucular.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgOkuyucular.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgOkuyucular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOkuyucular_CellClick);
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Animated = true;
            this.txtAra.BorderThickness = 2;
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.DefaultText = "";
            this.txtAra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAra.Location = new System.Drawing.Point(804, 590);
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAra.PlaceholderText = "";
            this.txtAra.SelectedText = "";
            this.txtAra.Size = new System.Drawing.Size(146, 26);
            this.txtAra.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAra.TabIndex = 18;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lblAra
            // 
            this.lblAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblAra.Location = new System.Drawing.Point(763, 593);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(35, 20);
            this.lblAra.TabIndex = 19;
            this.lblAra.Text = "Ara:";
            // 
            // pictureAra
            // 
            this.pictureAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureAra.BackColor = System.Drawing.Color.LightGray;
            this.pictureAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pictureAra.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.pictureAra.IconColor = System.Drawing.SystemColors.ControlText;
            this.pictureAra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureAra.IconSize = 22;
            this.pictureAra.Location = new System.Drawing.Point(738, 592);
            this.pictureAra.Name = "pictureAra";
            this.pictureAra.Size = new System.Drawing.Size(22, 25);
            this.pictureAra.TabIndex = 20;
            this.pictureAra.TabStop = false;
            this.pictureAra.UseGdi = true;
            // 
            // pictProfile
            // 
            this.pictProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictProfile.Image")));
            this.pictProfile.ImageRotate = 0F;
            this.pictProfile.Location = new System.Drawing.Point(91, 3);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.ShadowDecoration.Depth = 20;
            this.pictProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictProfile.Size = new System.Drawing.Size(101, 97);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictProfile.TabIndex = 0;
            this.pictProfile.TabStop = false;
            this.pictProfile.Click += new System.EventHandler(this.pictProfile_Click);
            this.pictProfile.MouseEnter += new System.EventHandler(this.pictProfile_MouseEnter);
            this.pictProfile.MouseLeave += new System.EventHandler(this.pictProfile_MouseLeave);
            // 
            // OkuyucuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pictureAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.dgOkuyucular);
            this.Controls.Add(this.tableButonlar);
            this.Controls.Add(this.tableUst);
            this.Controls.Add(this.tableBilgiler);
            this.Controls.Add(this.lbl_Title2);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "OkuyucuEkle";
            this.Size = new System.Drawing.Size(962, 625);
            this.Load += new System.EventHandler(this.OkuyucuEkle_Load);
            this.tableBilgiler.ResumeLayout(false);
            this.tableBilgiler.PerformLayout();
            this.tableCinsiyet.ResumeLayout(false);
            this.tableCinsiyet.PerformLayout();
            this.tableUst.ResumeLayout(false);
            this.tableUst.PerformLayout();
            this.tableButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSinifi;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TableLayoutPanel tableBilgiler;
        private System.Windows.Forms.TableLayoutPanel tableUst;
        private Guna.UI2.WinForms.Guna2TextBox txtAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyadi;
        private System.Windows.Forms.TableLayoutPanel tableCinsiyet;
        private Guna.UI2.WinForms.Guna2RadioButton radioBtnErkek;
        private Guna.UI2.WinForms.Guna2RadioButton radioBtnKiz;
        private Guna.UI2.WinForms.Guna2TextBox txtSinifi;
        private Guna.UI2.WinForms.Guna2TextBox txtOkulNo;
        private Guna.UI2.WinForms.Guna2TextBox txtCepTel;
        private Guna.UI2.WinForms.Guna2TextBox txtAdres;
        private System.Windows.Forms.TableLayoutPanel tableButonlar;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
        private Guna.UI2.WinForms.Guna2DataGridView dgOkuyucular;
        private FontAwesome.Sharp.IconPictureBox pictureAra;
        private Guna.UI2.WinForms.Guna2TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictProfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblFotograf;
    }
}
