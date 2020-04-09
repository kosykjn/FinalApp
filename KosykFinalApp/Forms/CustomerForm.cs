using KosykFinalApp.Database.Models;
using KosykFinalApp.Managers.DB;
using KosykFinalApp.Managers.Settings;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KosykFinalApp.Forms
{
    public partial class CustomerForm : AutorizedForm
    {
        public CustomerForm(IDatabaseManager databaseManager, ISettingsManager settingsManager, IAutorizedUser autorizedUser)
            : base(databaseManager, settingsManager, autorizedUser)
        {
            InitializeComponent();
            SetTitleGreeting();
            UpdateProductsList();
            UpdateCustomerOrdersList();
        }

        private void UpdateProductsList()
        {
            lvProducts.Items.Clear();

            var products = databaseManager.GetProducts();

            foreach (var product in products)
            {
                var listViewItem = new ListViewItem(new[] { product.Name, product.Price.ToString() })
                {
                    Tag = product
                };

                lvProducts.Items.Add(listViewItem);
            }
        }

        private void UpdateCustomerOrdersList()
        {
            lvCustomerOrders.Items.Clear();

            var orders = databaseManager.GetOrdersByCustomer(autorizedUser as Customer);

            foreach (var order in orders)
            {
                var lvItem = new ListViewItem(new[]
                {
                    order.CreateDate.ToString(CultureInfo.InvariantCulture),
                    order.Total.ToString(CultureInfo.InvariantCulture),
                });
                lvItem.Tag = order;

                lvCustomerOrders.Items.Add(lvItem);
            }
        }


        private void btnAddToBag_Click(object sender, System.EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                var productQuantityForm = new ProductQuantityForm();
                if (productQuantityForm.ShowDialog() == DialogResult.OK)
                {
                    if (lvProducts.SelectedItems[0].Tag is Product product)
                    {
                        var lvItem = new ListViewItem(new[]
                        {
                            product.Name,
                            product.Price.ToString(CultureInfo.InvariantCulture),
                            productQuantityForm.Quantity.ToString()
                        });
                        lvItem.Tag = (product, productQuantityForm.Quantity);

                        lvBag.Items.Add(lvItem);
                    }
                }
            }
        }

        private void btnRemoveFromBag_Click(object sender, System.EventArgs e)
        {
            for (int i = lvBag.Items.Count - 1; i >= 0; i--)
            {
                if (lvBag.Items[i].Selected)
                {
                    lvBag.Items[i].Remove();
                }
            }
        }

        private string SaveOrderToFile(string fileName, Order order)
        {
            var fullPath = Path.Combine(Path.GetTempPath(), fileName);

            using (var writer = new StreamWriter(fullPath, false, Encoding.UTF8))
            {
                writer.WriteLine($"Дата формирования заказа: {order.CreateDate}");
                writer.WriteLine($"Имя пользователя: {autorizedUser.Name}");

                foreach (var orderDetail in order.OrderDetails)
                {
                    writer.WriteLine($"{orderDetail.Product.Name} {orderDetail.Product.Price} грн {orderDetail.Quantity} шт");
                }


                writer.WriteLine($"Итоговая сумма: {order.Total} грн");
            }

            return fullPath;
        }

        private void btnGenerateOrder_Click(object sender, System.EventArgs e)
        {
            var bagProducts = new List<(Product, int)>();

            foreach (ListViewItem lvBagItem in lvBag.Items)
            {
                var productQuantityValue = ((Product, int))lvBagItem.Tag;
                bagProducts.Add(productQuantityValue); 
            }

            if (databaseManager.AddOrder(autorizedUser as Customer, bagProducts, out var addedOrder))
            {
                MessageBox.Show("Заказ успешно сформирован!", "Форма заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clear bag
                lvBag.Items.Clear();

                //Save to file and show
                Process.Start("notepad.exe", SaveOrderToFile("order.txt", addedOrder));
            }
            
        }

        private void lvCustomerOrders_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvCustomerOrders.SelectedItems.Count > 0)
            {
                lvOrderDetails.Items.Clear();

                if (lvCustomerOrders.SelectedItems[0].Tag is Order order)
                {
                    foreach (var orderDetail in order.OrderDetails)
                    {
                        var lvItem = new ListViewItem(new[]
                        {
                            orderDetail.Product.Name,
                            orderDetail.Product.Price.ToString(CultureInfo.InvariantCulture),
                            orderDetail.Quantity.ToString()
                        });

                        lvOrderDetails.Items.Add(lvItem);
                    }
                }
            }
           
        }

        private void btnUpdateCustomerOrders_Click(object sender, System.EventArgs e)
        {
           UpdateCustomerOrdersList();
        }

        private void btnUpdateProducts_Click(object sender, System.EventArgs e)
        {
            UpdateProductsList();
        }
    }
}
