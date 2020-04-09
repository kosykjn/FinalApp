using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;
using KosykFinalApp.Managers.Settings;
using System;
using System.Windows.Forms;

namespace KosykFinalApp.Forms
{
    public partial class AddNewCustomerForm : AutorizedForm
    {
        public AddNewCustomerForm()
        {
        }

        public AddNewCustomerForm(IDatabaseManager databaseManager, ISettingsManager settingsManager, IAutorizedUser autorizedUser)
            : base(databaseManager, settingsManager, autorizedUser)
        {
            InitializeComponent();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            if (databaseManager.AddCustomer(tbNameCustomer.Text, tbLastnameCustomer.Text, 
                tbAddressCustomer.Text, tbEmailCustomer.Text, dtDateOfBirthCustomer.Value, 
                tbPasswordCustomer.Text, tbLoginCustomer.Text))
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
