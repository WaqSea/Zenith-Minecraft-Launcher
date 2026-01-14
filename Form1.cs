using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Linq;

using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Installers;
using CmlLib.Core.ProcessBuilder;

namespace ZenithLauncher
{
    public partial class Form1 : Form
    {
        private string globalUsername;
        private MinecraftPath path;
        private MinecraftLauncher launcher;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1(string user)
        {
            InitializeComponent();
            globalUsername = user;

            this.Size = new Size(900, 550);
            if (lblTitle != null) lblTitle.Text = "ZENITH";
            if (pnlSettings != null) pnlSettings.Visible = false;

            path = new MinecraftPath();
            launcher = new MinecraftLauncher(path);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Önce Ayarları ve Dili Yükle
            LoadUserSettings();
            ApplyLanguage();

            try
            {
                lblStatus.Text = LanguageManager.Get("Main_Status_Searching");
                var versions = await launcher.GetAllVersionsAsync();
                cmbVersions.Items.Clear();

                foreach (var item in versions.Where(v => v.Type == "release"))
                    cmbVersions.Items.Add(item.Name);

                cmbVersions.DropDownStyle = ComboBoxStyle.DropDown;
                cmbVersions.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbVersions.AutoCompleteSource = AutoCompleteSource.ListItems;

                if (cmbVersions.Items.Count > 0) cmbVersions.SelectedIndex = 0;
                lblStatus.Text = LanguageManager.Get("Main_Status_Ready") + " " + globalUsername;
            }
            catch
            {
                lblStatus.Text = LanguageManager.Get("Main_Status_Offline");
                cmbVersions.Items.Add("1.20.4");
                cmbVersions.SelectedIndex = 0;
            }
        }

        // --- DİL GÜNCELLEME METODU ---
        private void ApplyLanguage()
        {
            btnLaunch.Text = LanguageManager.Get("Main_Play");
            lblVer.Text = LanguageManager.Get("Main_Version");
            btnSettings.Text = LanguageManager.Get("Main_Settings");

            // Ayarlar Paneli
            lblSettingsTitle.Text = LanguageManager.Get("Settings_Title");
            lblRamTitle.Text = LanguageManager.Get("Settings_RamTitle");
            chkAutoRam.Text = LanguageManager.Get("Settings_AutoRam");
            lblJavaTitle.Text = LanguageManager.Get("Settings_JavaPath");
            lblLanguage.Text = LanguageManager.Get("Settings_Language");
            btnSaveSettings.Text = LanguageManager.Get("Settings_Save");
        }

        private void LoadUserSettings()
        {
            try
            {
                int savedRam = Properties.Settings.Default.RamAmount;
                if (savedRam < 1024) savedRam = 2048;
                tbRam.Value = savedRam;
                lblRamAmount.Text = savedRam + " MB";

                txtJavaPath.Text = Properties.Settings.Default.JavaPath;
                chkAutoRam.Checked = Properties.Settings.Default.IsAutoRam;
                tbRam.Enabled = !chkAutoRam.Checked;

                // Dil Yüklemesi
                string lang = Properties.Settings.Default.Language;
                LanguageManager.CurrentLanguage = lang;
                cmbLanguage.SelectedItem = (lang == "EN") ? "English" : "Türkçe";
            }
            catch { }
        }

        private void SaveUserSettings()
        {
            try
            {
                Properties.Settings.Default.RamAmount = tbRam.Value;
                Properties.Settings.Default.JavaPath = txtJavaPath.Text;
                Properties.Settings.Default.IsAutoRam = chkAutoRam.Checked;

                // Dil Kaydı
                string selectedLang = (cmbLanguage.SelectedItem.ToString() == "English") ? "EN" : "TR";
                Properties.Settings.Default.Language = selectedLang;
                LanguageManager.CurrentLanguage = selectedLang;

                Properties.Settings.Default.Save();

                // Kaydettikten sonra dili anında uygula
                ApplyLanguage();

            }
            catch (Exception ex) { MessageBox.Show("Kayıt hatası: " + ex.Message); }
        }

        private async void btnLaunch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbVersions.Text)) return;

            btnLaunch.Enabled = false;
            btnLaunch.Text = LanguageManager.Get("Main_Preparing");
            pbDownload.Visible = true;
            pbDownload.Value = 0;

            try
            {
                string selectedVersion = cmbVersions.Text;

                var fileProgress = new Progress<InstallerProgressChangedEventArgs>(prog =>
                {
                    pbDownload.Maximum = prog.TotalTasks;
                    pbDownload.Value = prog.ProgressedTasks;

                    // İndirme yazısı
                    if (prog.TotalTasks > 0)
                        lblStatus.Text = LanguageManager.Get("Main_Downloading") + $" %{prog.ProgressedTasks * 100 / prog.TotalTasks}";
                });

                var byteProgress = new Progress<ByteProgress>(prog => { });

                await launcher.InstallAsync(selectedVersion, fileProgress, byteProgress);

                btnLaunch.Text = LanguageManager.Get("Main_Running");

                var launchOption = new MLaunchOption
                {
                    Session = MSession.CreateOfflineSession(globalUsername),
                };

                if (!chkAutoRam.Checked) launchOption.MaximumRamMb = tbRam.Value;
                else launchOption.MaximumRamMb = 4096;

                if (!string.IsNullOrWhiteSpace(txtJavaPath.Text)) launchOption.JavaPath = txtJavaPath.Text;

                var process = await launcher.BuildProcessAsync(selectedVersion, launchOption);
                process.Start();

                this.Hide();

                await Task.Run(() => {
                    process.WaitForExit();
                });

                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();

                btnLaunch.Enabled = true;
                btnLaunch.Text = LanguageManager.Get("Main_Play");
                lblStatus.Text = LanguageManager.Get("Main_GameClosed");
                pbDownload.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                btnLaunch.Enabled = true;
                btnLaunch.Text = LanguageManager.Get("Main_Play");
                pbDownload.Visible = false;
                this.Show();
            }
        }

        private void tbRam_Scroll(object sender, EventArgs e) { lblRamAmount.Text = tbRam.Value + " MB"; }
        private void chkAutoRam_CheckedChanged(object sender, EventArgs e) { tbRam.Enabled = !chkAutoRam.Checked; if (chkAutoRam.Checked) lblRamAmount.Text = "AUTO"; else lblRamAmount.Text = tbRam.Value + " MB"; }

        private void btnBrowseJava_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Java Executable|javaw.exe|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) txtJavaPath.Text = ofd.FileName;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e) { SaveUserSettings(); pnlSettings.Visible = false; }
        private void btnSettings_Click(object sender, EventArgs e) { pnlSettings.Visible = !pnlSettings.Visible; pnlSettings.BringToFront(); }
        private void Form_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0); }
        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
    }
}