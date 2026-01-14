namespace ZenithLauncher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.cmbVersions = new System.Windows.Forms.ComboBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();

            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();

            this.btnBrowseJava = new System.Windows.Forms.Button();
            this.txtJavaPath = new System.Windows.Forms.TextBox();
            this.lblJavaTitle = new System.Windows.Forms.Label();
            this.lblRamAmount = new System.Windows.Forms.Label();
            this.chkAutoRam = new System.Windows.Forms.CheckBox();
            this.tbRam = new System.Windows.Forms.TrackBar();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblSettingsTitle = new System.Windows.Forms.Label();
            this.lblRamTitle = new System.Windows.Forms.Label();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRam)).BeginInit();
            this.SuspendLayout();

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZenithLauncher";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Load += new System.EventHandler(this.Form1_Load);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ZENITH";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);

            // btnClose
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(850, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "✕";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // btnMinimize
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(800, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 40);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.Text = "─";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);

            // lblVer
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblVer.ForeColor = System.Drawing.Color.Gray;
            this.lblVer.Location = new System.Drawing.Point(55, 180);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(117, 19);
            this.lblVer.TabIndex = 3;
            this.lblVer.Text = "OYUN SÜRÜMÜ";

            // cmbVersions
            this.cmbVersions.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.cmbVersions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVersions.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbVersions.ForeColor = System.Drawing.Color.White;
            this.cmbVersions.FormattingEnabled = true;
            this.cmbVersions.Location = new System.Drawing.Point(55, 205);
            this.cmbVersions.Name = "cmbVersions";
            this.cmbVersions.Size = new System.Drawing.Size(350, 33);
            this.cmbVersions.TabIndex = 1;

            // btnLaunch
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(0, 150, 200);
            this.btnLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaunch.FlatAppearance.BorderSize = 0;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(55, 280);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(350, 60);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "OYNA";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);

            // pbDownload
            this.pbDownload.Location = new System.Drawing.Point(55, 350);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(350, 5);
            this.pbDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDownload.TabIndex = 12;
            this.pbDownload.Visible = false;

            // btnSettings
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.DimGray;
            this.btnSettings.Location = new System.Drawing.Point(155, 370);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 30);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "⚙ Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(12, 520);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 14);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Hazır.";

            // pnlSettings
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // DİL SEÇENEKLERİ EKLENDİ
            this.pnlSettings.Controls.Add(this.cmbLanguage);
            this.pnlSettings.Controls.Add(this.lblLanguage);

            this.pnlSettings.Controls.Add(this.btnBrowseJava);
            this.pnlSettings.Controls.Add(this.txtJavaPath);
            this.pnlSettings.Controls.Add(this.lblJavaTitle);
            this.pnlSettings.Controls.Add(this.lblRamAmount);
            this.pnlSettings.Controls.Add(this.chkAutoRam);
            this.pnlSettings.Controls.Add(this.tbRam);
            this.pnlSettings.Controls.Add(this.btnSaveSettings);
            this.pnlSettings.Controls.Add(this.lblSettingsTitle);
            this.pnlSettings.Controls.Add(this.lblRamTitle);
            this.pnlSettings.Location = new System.Drawing.Point(450, 150);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(300, 350); // Panel boyunu uzattık
            this.pnlSettings.TabIndex = 200;
            this.pnlSettings.Visible = false;

            // lblSettingsTitle
            this.lblSettingsTitle.AutoSize = true;
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSettingsTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblSettingsTitle.Location = new System.Drawing.Point(100, 10);
            this.lblSettingsTitle.Name = "lblSettingsTitle";
            this.lblSettingsTitle.Size = new System.Drawing.Size(95, 25);
            this.lblSettingsTitle.Text = "AYARLAR";

            // lblRamTitle
            this.lblRamTitle.AutoSize = true;
            this.lblRamTitle.ForeColor = System.Drawing.Color.White;
            this.lblRamTitle.Location = new System.Drawing.Point(20, 50);
            this.lblRamTitle.Name = "lblRamTitle";
            this.lblRamTitle.Size = new System.Drawing.Size(77, 13);
            this.lblRamTitle.Text = "RAM MİKTARI:";

            // tbRam
            this.tbRam.Location = new System.Drawing.Point(20, 70);
            this.tbRam.Maximum = 16384;
            this.tbRam.Minimum = 1024;
            this.tbRam.Name = "tbRam";
            this.tbRam.Size = new System.Drawing.Size(260, 45);
            this.tbRam.SmallChange = 512;
            this.tbRam.TabIndex = 5;
            this.tbRam.TickFrequency = 1024;
            this.tbRam.Value = 2048;
            this.tbRam.Scroll += new System.EventHandler(this.tbRam_Scroll);

            // lblRamAmount
            this.lblRamAmount.AutoSize = true;
            this.lblRamAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblRamAmount.Location = new System.Drawing.Point(220, 50);
            this.lblRamAmount.Name = "lblRamAmount";
            this.lblRamAmount.Size = new System.Drawing.Size(51, 13);
            this.lblRamAmount.Text = "2048 MB";

            // chkAutoRam
            this.chkAutoRam.AutoSize = true;
            this.chkAutoRam.ForeColor = System.Drawing.Color.LightGray;
            this.chkAutoRam.Location = new System.Drawing.Point(25, 110);
            this.chkAutoRam.Name = "chkAutoRam";
            this.chkAutoRam.Size = new System.Drawing.Size(126, 17);
            this.chkAutoRam.TabIndex = 6;
            this.chkAutoRam.Text = "Otomatik RAM Kullan";
            this.chkAutoRam.UseVisualStyleBackColor = true;
            this.chkAutoRam.CheckedChanged += new System.EventHandler(this.chkAutoRam_CheckedChanged);

            // lblJavaTitle
            this.lblJavaTitle.AutoSize = true;
            this.lblJavaTitle.ForeColor = System.Drawing.Color.White;
            this.lblJavaTitle.Location = new System.Drawing.Point(20, 140);
            this.lblJavaTitle.Name = "lblJavaTitle";
            this.lblJavaTitle.Size = new System.Drawing.Size(66, 13);
            this.lblJavaTitle.Text = "JAVA YOLU:";

            // txtJavaPath
            this.txtJavaPath.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.txtJavaPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJavaPath.ForeColor = System.Drawing.Color.White;
            this.txtJavaPath.Location = new System.Drawing.Point(23, 160);
            this.txtJavaPath.Name = "txtJavaPath";
            this.txtJavaPath.Size = new System.Drawing.Size(210, 20);
            this.txtJavaPath.TabIndex = 7;

            // btnBrowseJava
            this.btnBrowseJava.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnBrowseJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseJava.ForeColor = System.Drawing.Color.White;
            this.btnBrowseJava.Location = new System.Drawing.Point(240, 158);
            this.btnBrowseJava.Name = "btnBrowseJava";
            this.btnBrowseJava.Size = new System.Drawing.Size(40, 23);
            this.btnBrowseJava.TabIndex = 8;
            this.btnBrowseJava.Text = "...";
            this.btnBrowseJava.UseVisualStyleBackColor = false;
            this.btnBrowseJava.Click += new System.EventHandler(this.btnBrowseJava_Click);

            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(20, 200);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Text = "DİL / LANGUAGE:";
            this.lblLanguage.Size = new System.Drawing.Size(66, 13);

            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.cmbLanguage.ForeColor = System.Drawing.Color.White;
            this.cmbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] { "Türkçe", "English" });
            this.cmbLanguage.Location = new System.Drawing.Point(23, 220);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(257, 21);
            // 

            // btnSaveSettings
            this.btnSaveSettings.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(23, 280); // Yeri aşağı kaydı
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(257, 40);
            this.btnSaveSettings.TabIndex = 9;
            this.btnSaveSettings.Text = "KAYDET";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);

            // Controls
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.cmbVersions);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.ComboBox cmbVersions;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblSettingsTitle;
        private System.Windows.Forms.Label lblRamTitle;
        private System.Windows.Forms.TextBox txtJavaPath;
        private System.Windows.Forms.Label lblJavaTitle;
        private System.Windows.Forms.Button btnBrowseJava;
        private System.Windows.Forms.TrackBar tbRam;
        private System.Windows.Forms.Label lblRamAmount;
        private System.Windows.Forms.CheckBox chkAutoRam;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
    }

}
