using System;
using System.Windows.Forms;

namespace ZenithLauncher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // BURASI ÇOK ÖNEMLİ: Program LoginForm ile başlayacak
            Application.Run(new LoginForm());
        }
    }
}