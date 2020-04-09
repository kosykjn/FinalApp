using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;
using KosykFinalApp.Managers.Settings;
using System;
using System.Windows.Forms;

namespace KosykFinalApp.Forms
{
    public partial class LoginForm : Form
    {
        private IDatabaseManager databaseManager;
        private ISettingsManager settingsManager;

        public LoginForm(IDatabaseManager databaseManager, ISettingsManager settingsManager)
        {
            InitializeComponent();
            this.databaseManager = databaseManager;
            this.settingsManager = settingsManager;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            var loginResult = await databaseManager.LoginAsync(tbLogin.Text, tbPassword.Text);

            Cursor = Cursors.Default;

            if (loginResult)
            {
                this.Hide();

                switch (loginResult.AutorizedUser.Role)
                {
                    case Role.Manager:
                        new ManagerForm(databaseManager, settingsManager, loginResult.AutorizedUser).ShowDialog();
                        break;
                    case Role.Customer:
                        new CustomerForm(databaseManager, settingsManager, loginResult.AutorizedUser).ShowDialog();
                        break;
                }

                this.Close();           
            }
            else
            {
                MessageBox.Show("Ошибка авторизации!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }
    }
}
