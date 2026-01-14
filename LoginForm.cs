using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ZenithLauncher
{
    public partial class LoginForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();

            // Dili Yükle
            LanguageManager.CurrentLanguage = Properties.Settings.Default.Language;
            ApplyLanguage();

            LoadSettings();

            try
            {
                string gifPath = Application.StartupPath + "\\arka_plan.gif";
                if (System.IO.File.Exists(gifPath))
                {
                    pbSideImage.Image = Image.FromFile(gifPath);
                    pbSideImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch { }
        }

        // Dil Değişikliklerini Uygula
        private void ApplyLanguage()
        {
            lblUser.Text = LanguageManager.Get("Login_Username");
            chkRemember.Text = LanguageManager.Get("Login_Remember");
            btnLogin.Text = LanguageManager.Get("Login_Button");
            // lblTitle "ZENITH" olduğu için çevirmiyoruz, o marka adı.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                ShowError(LanguageManager.Get("Login_Error_Empty"));
                return;
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                ShowError(LanguageManager.Get("Login_Error_Invalid"));
                return;
            }

            if (username.Length < 3 || username.Length > 16)
            {
                ShowError(LanguageManager.Get("Login_Error_Length"));
                return;
            }

            SaveSettings();

            Form1 mainForm = new Form1(username);
            mainForm.Show();
            this.Hide();
        }

        private void ShowError(string message)
        {
            lblError.Text = "⚠ " + message;
            lblError.Visible = true;
            txtUsername.BackColor = Color.FromArgb(60, 20, 20);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (lblError.Visible)
            {
                lblError.Visible = false;
                txtUsername.BackColor = Color.FromArgb(40, 40, 40);
            }
        }

        private void SaveSettings()
        {
            try
            {
                Properties.Settings.Default.SavedUsername = txtUsername.Text;
                Properties.Settings.Default.IsRememberEnabled = chkRemember.Checked;
                Properties.Settings.Default.Save();
            }
            catch { }
        }

        private void LoadSettings()
        {
            try
            {
                if (Properties.Settings.Default.IsRememberEnabled)
                {
                    txtUsername.Text = Properties.Settings.Default.SavedUsername;
                    chkRemember.Checked = true;
                }
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}