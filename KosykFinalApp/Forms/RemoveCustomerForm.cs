using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KosykFinalApp.Managers.Settings;

namespace KosykFinalApp.Forms
{
    public partial class RemoveCustomerForm : AutorizedForm
    {
        public RemoveCustomerForm()
        {
        }

        public RemoveCustomerForm(IDatabaseManager databaseManager, ISettingsManager settingsManager, IAutorizedUser autorizedUser)
            : base(databaseManager, settingsManager, autorizedUser)
        {
            InitializeComponent();
            GetCustomer();
        }

        public void GetCustomer()
        {
            var customers = databaseManager.GetCustomers();

            foreach (var customer in customers)
            {
                var lvItem = new ListViewItem(new[] 
                { 
                    customer.Name,
                    customer.LastName,
                    customer.Address 
                });
                lvItem.Tag = customer;

                lvAllCustomer.Items.Add(lvItem);
            }
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            if (lvAllCustomer.SelectedIndices.Count > 0)
            {
                var selectedItem = lvAllCustomer.Items[lvAllCustomer.SelectedIndices[0]];

                if (selectedItem != null)
                {
                    if (databaseManager.RemoveCustomer(selectedItem.Tag as Customer))
                    {
                        lvAllCustomer.Items[lvAllCustomer.SelectedIndices[0]].Remove();

                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        DialogResult = DialogResult.No;
                    }
                }   
                else
                {
                    DialogResult = DialogResult.No;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
