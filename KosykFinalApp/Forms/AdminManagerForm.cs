using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;

namespace KosykFinalApp.Forms
{
    public partial class AdminManagerForm : AutorizedForm
    {
        public AdminManagerForm(IDatabaseManager databaseManager, IAutorizedUser autorizedUser)
            : base(databaseManager, autorizedUser)
        {
            InitializeComponent();
            SetTitleGreeting();
        }
    }
}
