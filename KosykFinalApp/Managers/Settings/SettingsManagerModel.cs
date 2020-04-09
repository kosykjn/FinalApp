using KosykFinalApp.Database.Models;
using Microsoft.Win32;
using System;

namespace KosykFinalApp.Managers.Settings 
{
    public class SettingsManagerModel : ISettingsManager
    {
        public OrderStatus CurrentOrderStatus { get; set; }

        public SettingsManagerModel()
        {
            Load();
        }

        public void Load()
        {
            try
            {
                var rootSoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);

                var appKey = rootSoftwareKey?.OpenSubKey("KosykFinalApp", false);

                CurrentOrderStatus = (OrderStatus)((int)appKey.GetValue("CurrentOrderStatus"));

            }
            catch (Exception)
            {
                CurrentOrderStatus = OrderStatus.New;
            }           
        }

        public void Save()
        {
            var rootSoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);

            if (rootSoftwareKey != null)
            {
                var appKey = rootSoftwareKey.OpenSubKey("KosykFinalApp", true) ?? rootSoftwareKey.CreateSubKey("KosykFinalApp");

                if (appKey != null)
                {
                    appKey.SetValue("CurrentOrderStatus", (int)CurrentOrderStatus);
                }
            }
        }
    }
}
