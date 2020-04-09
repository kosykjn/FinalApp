using KosykFinalApp.Forms;
using KosykFinalApp.Managers.DB;
using KosykFinalApp.Managers.Settings;
using System;
using System.Windows.Forms;

namespace KosykFinalApp
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var settingsManager = new SettingsManagerModel();
            var databaseManager = new DatabaseManagerModel();
            //dbManager.FillTestDataInDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(databaseManager, settingsManager));
        }
    }
}
