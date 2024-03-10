namespace Kutuphane_Otomasyonu.Forms
{
    partial class Login_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Panel));
            this.closeForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.form_control = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconSifre = new FontAwesome.Sharp.IconPictureBox();
            this.iconLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGirisYap = new Guna.UI2.WinForms.Guna2Button();
            this.checkBeniHatirla = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeForm.Animated = true;
            this.closeForm.BackColor = System.Drawing.Color.LightGray;
            this.closeForm.FillColor = System.Drawing.Color.LightGray;
            this.closeForm.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeForm.HoverState.IconColor = System.Drawing.Color.White;
            this.closeForm.IconColor = System.Drawing.Color.Black;
            this.closeForm.Location = new System.Drawing.Point(329, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(45, 29);
            this.closeForm.TabIndex = 7;
            // 
            // form_control
            // 
            this.form_control.AnimateWindow = true;
            this.form_control.AnimationInterval = 100;
            this.form_control.BorderRadius = 10;
            this.form_control.ContainerControl = this;
            this.form_control.DockForm = false;
            this.form_control.DockIndicatorTransparencyValue = 0.6D;
            this.form_control.DragStartTransparencyValue = 1D;
            this.form_control.ResizeForm = false;
            this.form_control.TransparentWhileDrag = true;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.Transparent;
            this.iconUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 25;
            this.iconUser.Location = new System.Drawing.Point(28, 246);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(25, 26);
            this.iconUser.TabIndex = 5;
            this.iconUser.TabStop = false;
            // 
            // iconSifre
            // 
            this.iconSifre.BackColor = System.Drawing.Color.Transparent;
            this.iconSifre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSifre.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconSifre.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSifre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSifre.IconSize = 25;
            this.iconSifre.Location = new System.Drawing.Point(30, 311);
            this.iconSifre.Name = "iconSifre";
            this.iconSifre.Size = new System.Drawing.Size(25, 28);
            this.iconSifre.TabIndex = 5;
            this.iconSifre.TabStop = false;
            // 
            // iconLogo
            // 
            this.iconLogo.BackColor = System.Drawing.Color.Transparent;
            this.iconLogo.Enabled = false;
            this.iconLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.iconLogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogo.IconSize = 134;
            this.iconLogo.Location = new System.Drawing.Point(119, 12);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(136, 134);
            this.iconLogo.TabIndex = 0;
            this.iconLogo.TabStop = false;
            this.iconLogo.UseGdi = true;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle1.Location = new System.Drawing.Point(73, 153);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(229, 29);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "Kütüphane Yönetimi";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle2.Location = new System.Drawing.Point(145, 182);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(85, 24);
            this.lblTitle2.TabIndex = 4;
            this.lblTitle2.Text = "Giriş Yap";
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
            this.txtKullaniciAdi.Location = new System.Drawing.Point(147, 241);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.PlaceholderText = "";
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 33);
            this.txtKullaniciAdi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Animated = true;
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
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
            this.txtSifre.Location = new System.Drawing.Point(147, 304);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PlaceholderText = "";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(200, 33);
            this.txtSifre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(53, 249);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(88, 17);
            this.lblKullaniciAdi.TabIndex = 5;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(56, 313);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(85, 15);
            this.lblSifre.TabIndex = 6;
            this.lblSifre.Text = "Kullanıcı Şifre:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Animated = true;
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.BorderRadius = 10;
            this.btnGirisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGirisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGirisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGirisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGirisYap.FillColor = System.Drawing.Color.White;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGirisYap.ForeColor = System.Drawing.Color.Black;
            this.btnGirisYap.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnGirisYap.Location = new System.Drawing.Point(116, 368);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(142, 35);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_click);
            // 
            // checkBeniHatirla
            // 
            this.checkBeniHatirla.Animated = true;
            this.checkBeniHatirla.AutoSize = true;
            this.checkBeniHatirla.BackColor = System.Drawing.Color.Transparent;
            this.checkBeniHatirla.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBeniHatirla.CheckedState.BorderRadius = 0;
            this.checkBeniHatirla.CheckedState.BorderThickness = 0;
            this.checkBeniHatirla.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBeniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBeniHatirla.Location = new System.Drawing.Point(255, 343);
            this.checkBeniHatirla.Name = "checkBeniHatirla";
            this.checkBeniHatirla.Size = new System.Drawing.Size(100, 21);
            this.checkBeniHatirla.TabIndex = 3;
            this.checkBeniHatirla.Text = "Beni Hatırla";
            this.checkBeniHatirla.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.checkBeniHatirla.UncheckedState.BorderRadius = 0;
            this.checkBeniHatirla.UncheckedState.BorderThickness = 0;
            this.checkBeniHatirla.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.checkBeniHatirla.UseVisualStyleBackColor = false;
            this.checkBeniHatirla.CheckedChanged += new System.EventHandler(this.checkBeniHatirla_CheckedChanged);
            // 
            // Login_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(374, 447);
            this.Controls.Add(this.checkBeniHatirla);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.iconSifre);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.iconLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap - Kütüphane Yönetim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Panel_FormClosed);
            this.Load += new System.EventHandler(this.Login_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox closeForm;
        private Guna.UI2.WinForms.Guna2BorderlessForm form_control;
        private Guna.UI2.WinForms.Guna2CheckBox checkBeniHatirla;
        private Guna.UI2.WinForms.Guna2Button btnGirisYap;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdi;
        private FontAwesome.Sharp.IconPictureBox iconSifre;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private FontAwesome.Sharp.IconPictureBox iconLogo;
    }
}