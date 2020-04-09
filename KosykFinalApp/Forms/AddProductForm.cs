using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;
using KosykFinalApp.Managers.Settings;
using System;
using System.Windows.Forms;

namespace KosykFinalApp.Forms
{
    public partial class AddProductForm : AutorizedForm
    {
        public AddProductForm(IDatabaseManager databaseManager, ISettingsManager settingsManager, IAutorizedUser autorizedUser)
            : base(databaseManager, settingsManager, autorizedUser)
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (databaseManager.AddProdurcts(tbName.Text, Convert.ToDouble(tbPrice.Text)))
            {
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
