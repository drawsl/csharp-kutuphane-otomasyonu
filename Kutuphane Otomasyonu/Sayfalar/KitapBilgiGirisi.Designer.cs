namespace Kutuphane_Otomasyonu.Sayfalar
{
    partial class KitapBilgiGirisi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tableGirdi = new System.Windows.Forms.TableLayoutPanel();
            this.lblGirdiAdi = new System.Windows.Forms.Label();
            this.cbbGirdiTablo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGirdiTablo = new System.Windows.Forms.Label();
            this.txtGirdiAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableButonlar = new System.Windows.Forms.TableLayoutPanel();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.dgGirdi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureAra = new FontAwesome.Sharp.IconPictureBox();
            this.txtAra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.tableGirdi.SuspendLayout();
            this.tableButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGirdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAra)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.AutoSize = true;
            this.lbl_Title2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title2.Location = new System.Drawing.Point(261, 20);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(136, 20);
            this.lbl_Title2.TabIndex = 5;
            this.lbl_Title2.Text = "Kitap Bilgi Girişi Ekle";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Title.Location = new System.Drawing.Point(10, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(247, 30);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Kütüphane Otomasyonu";
            // 
            // tableGirdi
            // 
            this.tableGirdi.ColumnCount = 2;
            this.tableGirdi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.29F));
            this.tableGirdi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.71F));
            this.tableGirdi.Controls.Add(this.lblGirdiAdi, 0, 1);
            this.tableGirdi.Controls.Add(this.cbbGirdiTablo, 1, 0);
            this.tableGirdi.Controls.Add(this.lblGirdiTablo, 0, 0);
            this.tableGirdi.Controls.Add(this.txtGirdiAdi, 1, 1);
            this.tableGirdi.Location = new System.Drawing.Point(5, 57);
            this.tableGirdi.Name = "tableGirdi";
            this.tableGirdi.RowCount = 2;
            this.tableGirdi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGirdi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGirdi.Size = new System.Drawing.Size(261, 83);
            this.tableGirdi.TabIndex = 6;
            // 
            // lblGirdiAdi
            // 
            this.lblGirdiAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGirdiAdi.AutoSize = true;
            this.lblGirdiAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblGirdiAdi.Location = new System.Drawing.Point(5, 52);
            this.lblGirdiAdi.Name = "lblGirdiAdi";
            this.lblGirdiAdi.Size = new System.Drawing.Size(91, 20);
            this.lblGirdiAdi.TabIndex = 14;
            this.lblGirdiAdi.Text = "Girdi Adı (*):";
            // 
            // cbbGirdiTablo
            // 
            this.cbbGirdiTablo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbGirdiTablo.BackColor = System.Drawing.Color.Transparent;
            this.cbbGirdiTablo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGirdiTablo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGirdiTablo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbGirdiTablo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbGirdiTablo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbbGirdiTablo.ForeColor = System.Drawing.Color.Black;
            this.cbbGirdiTablo.ItemHeight = 30;
            this.cbbGirdiTablo.Items.AddRange(new object[] {
            "Yazarlar",
            "Yayinevleri",
            "Kitap Türleri",
            "Dolaplar"});
            this.cbbGirdiTablo.Location = new System.Drawing.Point(105, 3);
            this.cbbGirdiTablo.Name = "cbbGirdiTablo";
            this.cbbGirdiTablo.Size = new System.Drawing.Size(153, 36);
            this.cbbGirdiTablo.StartIndex = 0;
            this.cbbGirdiTablo.TabIndex = 2;
            this.cbbGirdiTablo.SelectedIndexChanged += new System.EventHandler(this.cbbGirdiTablo_SelectedIndexChanged);
            // 
            // lblGirdiTablo
            // 
            this.lblGirdiTablo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGirdiTablo.AutoSize = true;
            this.lblGirdiTablo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblGirdiTablo.Location = new System.Drawing.Point(4, 11);
            this.lblGirdiTablo.Name = "lblGirdiTablo";
            this.lblGirdiTablo.Size = new System.Drawing.Size(94, 19);
            this.lblGirdiTablo.TabIndex = 13;
            this.lblGirdiTablo.Text = "Girdi Tablo (*):";
            // 
            // txtGirdiAdi
            // 
            this.txtGirdiAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGirdiAdi.Animated = true;
            this.txtGirdiAdi.BorderThickness = 2;
            this.txtGirdiAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGirdiAdi.DefaultText = "";
            this.txtGirdiAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGirdiAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGirdiAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGirdiAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGirdiAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGirdiAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGirdiAdi.ForeColor = System.Drawing.Color.Black;
            this.txtGirdiAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGirdiAdi.Location = new System.Drawing.Point(105, 44);
            this.txtGirdiAdi.Name = "txtGirdiAdi";
            this.txtGirdiAdi.PasswordChar = '\0';
            this.txtGirdiAdi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtGirdiAdi.PlaceholderText = "";
            this.txtGirdiAdi.SelectedText = "";
            this.txtGirdiAdi.Size = new System.Drawing.Size(153, 36);
            this.txtGirdiAdi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGirdiAdi.TabIndex = 15;
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
            this.tableButonlar.Location = new System.Drawing.Point(5, 146);
            this.tableButonlar.Name = "tableButonlar";
            this.tableButonlar.RowCount = 1;
            this.tableButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButonlar.Size = new System.Drawing.Size(261, 40);
            this.tableButonlar.TabIndex = 17;
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
            this.btnKaydet.Size = new System.Drawing.Size(80, 34);
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
            this.btnSil.Location = new System.Drawing.Point(89, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 34);
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
            this.btnTemizle.Location = new System.Drawing.Point(175, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(83, 34);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgGirdi
            // 
            this.dgGirdi.AllowUserToAddRows = false;
            this.dgGirdi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.dgGirdi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgGirdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGirdi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgGirdi.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGirdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgGirdi.ColumnHeadersHeight = 15;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGirdi.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgGirdi.GridColor = System.Drawing.Color.DimGray;
            this.dgGirdi.Location = new System.Drawing.Point(272, 57);
            this.dgGirdi.MultiSelect = false;
            this.dgGirdi.Name = "dgGirdi";
            this.dgGirdi.ReadOnly = true;
            this.dgGirdi.RowHeadersVisible = false;
            this.dgGirdi.Size = new System.Drawing.Size(678, 511);
            this.dgGirdi.StandardTab = true;
            this.dgGirdi.TabIndex = 18;
            this.dgGirdi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgGirdi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgGirdi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgGirdi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgGirdi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgGirdi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgGirdi.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgGirdi.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.dgGirdi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgGirdi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgGirdi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgGirdi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgGirdi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgGirdi.ThemeStyle.HeaderStyle.Height = 15;
            this.dgGirdi.ThemeStyle.ReadOnly = true;
            this.dgGirdi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgGirdi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgGirdi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgGirdi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgGirdi.ThemeStyle.RowsStyle.Height = 22;
            this.dgGirdi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgGirdi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgGirdi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGirdi_CellClick);
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
            this.pictureAra.TabIndex = 23;
            this.pictureAra.TabStop = false;
            this.pictureAra.UseGdi = true;
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
            this.txtAra.TabIndex = 21;
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
            this.lblAra.TabIndex = 22;
            this.lblAra.Text = "Ara:";
            // 
            // KitapBilgiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pictureAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.dgGirdi);
            this.Controls.Add(this.tableButonlar);
            this.Controls.Add(this.tableGirdi);
            this.Controls.Add(this.lbl_Title2);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "KitapBilgiGirisi";
            this.Size = new System.Drawing.Size(962, 625);
            this.Load += new System.EventHandler(this.KitapBilgiGirisi_Load);
            this.tableGirdi.ResumeLayout(false);
            this.tableGirdi.PerformLayout();
            this.tableButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGirdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TableLayoutPanel tableGirdi;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGirdiTablo;
        private System.Windows.Forms.Label lblGirdiTablo;
        private System.Windows.Forms.Label lblGirdiAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtGirdiAdi;
        private System.Windows.Forms.TableLayoutPanel tableButonlar;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
        private Guna.UI2.WinForms.Guna2DataGridView dgGirdi;
        private FontAwesome.Sharp.IconPictureBox pictureAra;
        private Guna.UI2.WinForms.Guna2TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
    }
}
