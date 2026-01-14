using System.Collections.Generic;

namespace ZenithLauncher
{
    public static class LanguageManager
    {
        // Şu anki seçili dil
        public static string CurrentLanguage = "TR";

        // Türkçe Sözlük
        private static Dictionary<string, string> TR = new Dictionary<string, string>
        {
            // Giriş Ekranı
            {"Login_Title", "GİRİŞ YAP"},
            {"Login_Username", "Kullanıcı Adı"},
            {"Login_Remember", "Beni Hatırla"},
            {"Login_Button", "GİRİŞ YAP"},
            {"Login_Error_Empty", "Lütfen bir kullanıcı adı girin."},
            {"Login_Error_Invalid", "Kullanıcı adı sadece harf, rakam ve _ içerebilir!"},
            {"Login_Error_Length", "Kullanıcı adı 3-16 karakter arasında olmalıdır."},

            // Ana Ekran (Form1)
            {"Main_Play", "OYNA"},
            {"Main_Preparing", "HAZIRLANIYOR..."},
            {"Main_Downloading", "İNDİRİLİYOR..."},
            {"Main_Running", "OYUN AÇILIYOR..."},
            {"Main_Version", "OYUN SÜRÜMÜ"},
            {"Main_Settings", "⚙ Ayarlar"},
            {"Main_Status_Ready", "Hazır. Hoş geldin"},
            {"Main_Status_Offline", "Offline mod."},
            {"Main_Status_Searching", "Sürümler aranıyor..."},
            {"Main_GameClosed", "Oyun kapandı. Tekrar hoş geldin!"},

            // Ayarlar Paneli
            {"Settings_Title", "AYARLAR"},
            {"Settings_RamTitle", "RAM MİKTARI:"},
            {"Settings_AutoRam", "Otomatik RAM Kullan"},
            {"Settings_JavaPath", "JAVA YOLU:"},
            {"Settings_Language", "DİL / LANGUAGE:"},
            {"Settings_Save", "KAYDET"}
        };

        // İngilizce Sözlük
        private static Dictionary<string, string> EN = new Dictionary<string, string>
        {
            // Login Screen
            {"Login_Title", "LOGIN"},
            {"Login_Username", "Username"},
            {"Login_Remember", "Remember Me"},
            {"Login_Button", "LOGIN"},
            {"Login_Error_Empty", "Please enter a username."},
            {"Login_Error_Invalid", "Username can only contain letters, numbers and _"},
            {"Login_Error_Length", "Username must be between 3-16 characters."},

            // Main Screen
            {"Main_Play", "PLAY"},
            {"Main_Preparing", "PREPARING..."},
            {"Main_Downloading", "DOWNLOADING..."},
            {"Main_Running", "GAME RUNNING..."},
            {"Main_Version", "GAME VERSION"},
            {"Main_Settings", "⚙ Settings"},
            {"Main_Status_Ready", "Ready. Welcome"},
            {"Main_Status_Offline", "Offline mode."},
            {"Main_Status_Searching", "Searching versions..."},
            {"Main_GameClosed", "Game closed. Welcome back!"},

            // Settings Panel
            {"Settings_Title", "SETTINGS"},
            {"Settings_RamTitle", "RAM AMOUNT:"},
            {"Settings_AutoRam", "Use Auto RAM"},
            {"Settings_JavaPath", "JAVA PATH:"},
            {"Settings_Language", "LANGUAGE:"},
            {"Settings_Save", "SAVE"}
        };

        // Kelimeyi getiren fonksiyon
        public static string Get(string key)
        {
            if (CurrentLanguage == "EN")
            {
                if (EN.ContainsKey(key)) return EN[key];
            }
            else // Varsayılan TR
            {
                if (TR.ContainsKey(key)) return TR[key];
            }
            return key; // Bulamazsa anahtarın kendisini döndür
        }
    }
}