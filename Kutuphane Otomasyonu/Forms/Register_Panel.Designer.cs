using Kutuphane_Otomasyonu.Properties;

namespace Kutuphane_Otomasyonu.Forms
{
    partial class Register_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Panel));
            this.control_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.form_control = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.button_Kayit = new Guna.UI2.WinForms.Guna2Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtKadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKadi = new System.Windows.Forms.Label();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // control_exit
            // 
            this.control_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.control_exit.Animated = true;
            this.control_exit.BackColor = System.Drawing.Color.LightGray;
            this.control_exit.FillColor = System.Drawing.Color.LightGray;
            this.control_exit.HoverState.FillColor = System.Drawing.Color.Red;
            this.control_exit.HoverState.IconColor = System.Drawing.Color.White;
            this.control_exit.IconColor = System.Drawing.Color.Black;
            this.control_exit.Location = new System.Drawing.Point(412, 0);
            this.control_exit.Name = "control_exit";
            this.control_exit.Size = new System.Drawing.Size(45, 29);
            this.control_exit.TabIndex = 6;
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
            // button_Kayit
            // 
            this.button_Kayit.Animated = true;
            this.button_Kayit.BackColor = System.Drawing.Color.Transparent;
            this.button_Kayit.BorderRadius = 10;
            this.button_Kayit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Kayit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Kayit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Kayit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Kayit.FillColor = System.Drawing.Color.White;
            this.button_Kayit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Kayit.ForeColor = System.Drawing.Color.Black;
            this.button_Kayit.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.button_Kayit.Location = new System.Drawing.Point(158, 412);
            this.button_Kayit.Name = "button_Kayit";
            this.button_Kayit.Size = new System.Drawing.Size(142, 35);
            this.button_Kayit.TabIndex = 5;
            this.button_Kayit.Text = "Kayıt Ol";
            this.button_Kayit.Click += new System.EventHandler(this.button_Kayit_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(78, 246);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(32, 17);
            this.lblAd.TabIndex = 15;
            this.lblAd.Text = "Adı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Animated = true;
            this.txtSoyad.BackColor = System.Drawing.Color.Transparent;
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
            this.txtSoyad.Location = new System.Drawing.Point(171, 277);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.PlaceholderText = "";
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.Size = new System.Drawing.Size(210, 33);
            this.txtSoyad.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoyad.TabIndex = 1;
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
            this.txtAd.Location = new System.Drawing.Point(171, 238);
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAd.PlaceholderText = "";
            this.txtAd.SelectedText = "";
            this.txtAd.Size = new System.Drawing.Size(210, 33);
            this.txtAd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAd.TabIndex = 0;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle2.Location = new System.Drawing.Point(193, 185);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(73, 24);
            this.lblTitle2.TabIndex = 13;
            this.lblTitle2.Text = "Kayıt Ol";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(115, 156);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 29);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Kütüphane Yönetimi";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Enabled = false;
            this.pictureLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pictureLogo.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.pictureLogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.pictureLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureLogo.IconSize = 134;
            this.pictureLogo.Location = new System.Drawing.Point(161, 15);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(136, 134);
            this.pictureLogo.TabIndex = 9;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.UseGdi = true;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(78, 285);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(55, 17);
            this.lblSoyad.TabIndex = 20;
            this.lblSoyad.Text = "Soyadı:";
            // 
            // txtKadi
            // 
            this.txtKadi.Animated = true;
            this.txtKadi.BorderThickness = 2;
            this.txtKadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKadi.DefaultText = "";
            this.txtKadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKadi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKadi.ForeColor = System.Drawing.Color.Black;
            this.txtKadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKadi.Location = new System.Drawing.Point(171, 316);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.PasswordChar = '\0';
            this.txtKadi.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtKadi.PlaceholderText = "";
            this.txtKadi.SelectedText = "";
            this.txtKadi.Size = new System.Drawing.Size(210, 33);
            this.txtKadi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtKadi.TabIndex = 2;
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.BackColor = System.Drawing.Color.Transparent;
            this.lblKadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadi.Location = new System.Drawing.Point(78, 324);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(88, 17);
            this.lblKadi.TabIndex = 22;
            this.lblKadi.Text = "Kullanıcı Adı:";
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
            this.txtSifre.Location = new System.Drawing.Point(171, 355);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSifre.PlaceholderText = "";
            this.txtSifre.SelectedText = "";
            this.txtSifre.Size = new System.Drawing.Size(210, 33);
            this.txtSifre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(78, 363);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(41, 17);
            this.lblSifre.TabIndex = 22;
            this.lblSifre.Text = "Şifre:";
            // 
            // Register_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(458, 468);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKadi);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.control_exit);
            this.Controls.Add(this.button_Kayit);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap - Kütüphane Yönetim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox control_exit;
        private Guna.UI2.WinForms.Guna2BorderlessForm form_control;
        private Guna.UI2.WinForms.Guna2Button button_Kayit;
        private System.Windows.Forms.Label lblAd;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyad;
        private Guna.UI2.WinForms.Guna2TextBox txtAd;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconPictureBox pictureLogo;
        private System.Windows.Forms.Label lblSoyad;
        private Guna.UI2.WinForms.Guna2TextBox txtKadi;
        private System.Windows.Forms.Label lblKadi;
        private System.Windows.Forms.Label lblSifre;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
    }
}