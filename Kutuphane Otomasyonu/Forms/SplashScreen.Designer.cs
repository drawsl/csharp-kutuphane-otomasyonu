namespace Kutuphane_Otomasyonu
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.PanelLoading = new System.Windows.Forms.Panel();
            this.PanelLoadRunning = new System.Windows.Forms.Panel();
            this.TimeRunning = new System.Windows.Forms.Timer(this.components);
            this.form_control = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PanelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLoading
            // 
            this.PanelLoading.BackColor = System.Drawing.Color.LightSlateGray;
            this.PanelLoading.Controls.Add(this.PanelLoadRunning);
            this.PanelLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLoading.Location = new System.Drawing.Point(0, 0);
            this.PanelLoading.Name = "PanelLoading";
            this.PanelLoading.Size = new System.Drawing.Size(684, 13);
            this.PanelLoading.TabIndex = 0;
            this.PanelLoading.UseWaitCursor = true;
            // 
            // PanelLoadRunning
            // 
            this.PanelLoadRunning.BackColor = System.Drawing.Color.DimGray;
            this.PanelLoadRunning.Location = new System.Drawing.Point(0, 0);
            this.PanelLoadRunning.Name = "PanelLoadRunning";
            this.PanelLoadRunning.Size = new System.Drawing.Size(21, 13);
            this.PanelLoadRunning.TabIndex = 1;
            this.PanelLoadRunning.UseWaitCursor = true;
            // 
            // TimeRunning
            // 
            this.TimeRunning.Enabled = true;
            this.TimeRunning.Interval = 10;
            this.TimeRunning.Tick += new System.EventHandler(this.TimeRunning_Tick);
            // 
            // form_control
            // 
            this.form_control.BorderRadius = 11;
            this.form_control.ContainerControl = this;
            this.form_control.DockForm = false;
            this.form_control.DockIndicatorTransparencyValue = 0.6D;
            this.form_control.DragForm = false;
            this.form_control.DragStartTransparencyValue = 1D;
            this.form_control.ResizeForm = false;
            this.form_control.TransparentWhileDrag = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane_Otomasyonu.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.PanelLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Yönetimi";
            this.UseWaitCursor = true;
            this.PanelLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLoading;
        private System.Windows.Forms.Panel PanelLoadRunning;
        private System.Windows.Forms.Timer TimeRunning;
        private Guna.UI2.WinForms.Guna2BorderlessForm form_control;
    }
}

