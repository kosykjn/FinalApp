using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;
using KosykFinalApp.Managers.Settings;
using System.Windows.Forms;

namespace KosykFinalApp.Forms
{
    public class AutorizedForm : Form
    {
        protected IAutorizedUser autorizedUser;
        protected IDatabaseManager databaseManager;
        protected ISettingsManager settingsManager;

        public AutorizedForm()
        {

        }

        protected AutorizedForm(IDatabaseManager databaseManager, ISettingsManager settingsManager, IAutorizedUser autorizedUser)
            : base()
        {
            this.databaseManager = databaseManager;
            this.settingsManager = settingsManager;
            this.autorizedUser = autorizedUser;
        }

        protected void SetTitleGreeting()
        {
            this.Text = $"Пользователь {autorizedUser.Name} {autorizedUser.LastName} [{autorizedUser.Role}]";
        }
    }
}
