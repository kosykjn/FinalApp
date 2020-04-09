using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;
using KosykFinalApp.Managers.Settings;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace KosykFinalApp.Forms
{
    public partial class ManagerForm : AutorizedForm
    {
        //private OrderStatus CurrentOrderStatus
        //{
        //    get
        //    {
        //        if (rbCompledOrders.Checked) return OrderStatus.Completed;
        //        if (rbCanceledOrders.Checked) return OrderStatus.Canceled;
        //        return OrderStatus.New;
        //    }
        //}

        public ManagerForm(IDatabaseManager databaseManager, ISettingsManager settingsManager, IAutorizedUser autorizedUser)
            : base(databaseManager, settingsManager, autorizedUser)
        {
            InitializeComponent();
            SetTitleGreeting();
            SetFormValues();
            UpdateOrderList();
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            lvProducts.Items.Clear();

            var products = databaseManager.GetProducts();

            foreach (var product in products)
            {
                var listViewItem = new ListViewItem(new[] 
                { 
                    product.Name,
                    product.Price.ToString(),
                    product.CreateDate.ToString()
                })
                {
                    Tag = product
                };

                lvProducts.Items.Add(listViewItem);
            }
        }

        private void UpdateOrderList()
        {
            lvAllOrders.Items.Clear();

            var infoAboutOrders = databaseManager.GetOrdersByStatus(settingsManager.CurrentOrderStatus);

            foreach (var infoOrder in infoAboutOrders)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    infoOrder.CreateDate.ToString(CultureInfo.CurrentCulture),
                    infoOrder.Customer.LastName,
                    infoOrder.Status.ToString()
                });
                listViewItem.Tag = infoOrder;

                lvAllOrders.Items.Add(listViewItem);
            }
        }

        private void tsmAddNewCustomer_Click(object sender, System.EventArgs e)
        {
            var result = new AddNewCustomerForm(databaseManager, settingsManager, autorizedUser).ShowDialog();

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                   "Пользователь успешно добавлен!",
                   "Добавление пользователя",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(
                   "Пользователь не добавлен, произошла ошибка!",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void tsmRemoveCustomer_Click(object sender, System.EventArgs e)
        {
            var result = new RemoveCustomerForm(databaseManager, settingsManager, autorizedUser).ShowDialog();

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                   "Пользователь успешно удален!",
                   "Удаление пользователя",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(
                   "Пользователь не удален, произошла ошибка!",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void btnCompleteOrder_Click(object sender, System.EventArgs e)
        {
            if (lvAllOrders.SelectedIndices.Count > 0)
            {
                if (lvAllOrders.Items[lvAllOrders.SelectedIndices[0]].Tag is Order order)
                {
                    if (databaseManager.SetOrderStatus(order, OrderStatus.Completed))
                    {
                        UpdateOrderList();
                    }
                    else
                    {
                        MessageBox.Show(
                           "Не удалось изменить статус заказа!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnCancelOrder_Click(object sender, System.EventArgs e)
        {
            if (lvAllOrders.SelectedIndices.Count > 0)
            {
                if (lvAllOrders.Items[lvAllOrders.SelectedIndices[0]].Tag is Order order)
                {
                    if (databaseManager.SetOrderStatus(order, OrderStatus.Canceled))
                    {
                        UpdateOrderList();
                    }
                    else
                    {
                        MessageBox.Show(
                           "Не удалось изменить статус заказа!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void rbOrders_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateOrderList();

            SetSettingValues();
        }

        private void SetFormValues()
        {
            switch (settingsManager.CurrentOrderStatus)
            {
                case OrderStatus.New:
                    rbNewOrders.Checked = true;
                    break;
                case OrderStatus.Completed:
                    rbCompledOrders.Checked = true;
                    break;
                case OrderStatus.Canceled:
                    rbCanceledOrders.Checked = true;
                    break;
            }
        }

        private void SetSettingValues()
        {
            if (rbNewOrders.Checked)
            {
                settingsManager.CurrentOrderStatus = OrderStatus.New;
            }
            else if (rbCompledOrders.Checked)
            {
                settingsManager.CurrentOrderStatus = OrderStatus.Completed;
            }
            else
            {
                settingsManager.CurrentOrderStatus = OrderStatus.Canceled;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var result = new AddProductForm(databaseManager, settingsManager, autorizedUser).ShowDialog();

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                   "Товар успешно добавлен!",
                   "Удаление пользователя",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(
                   "Товар не добавлен, произошла ошибка!",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }

            UpdateProductList();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetSettingValues();
            settingsManager.Save();
        }
    }
}
