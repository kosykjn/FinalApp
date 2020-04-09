using KosykFinalApp.Database.Models;

namespace KosykFinalApp.Managers.Settings
{
    public interface ISettingsManager
    {
        OrderStatus CurrentOrderStatus { get; set; }
        void Load();
        void Save();
    }
}
