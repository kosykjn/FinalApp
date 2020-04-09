using KosykFinalApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KosykFinalApp.Managers.DB
{
    public interface IDatabaseManager
    {
        #region Login

        LoginResult Login(string login, string password);
        Task<LoginResult> LoginAsync(string login, string password);

        #endregion

        #region Product

        bool AddProdurcts(string name, double price);

        IEnumerable<Product> GetProducts();

        #endregion

        #region Order

        bool AddOrder(Customer customer, IEnumerable<(Product, int)> productQuantities, out Order addedOrder);

        IEnumerable<Order> GetOrdersByCustomer(Customer customer);

        IEnumerable<Order> GetOrdersByStatus(OrderStatus status);

        bool SetOrderStatus(Order order, OrderStatus status);

        IEnumerable<Order> GetOrders();

        #endregion

        #region Customer

        IEnumerable<Customer> GetCustomers();

        bool AddCustomer(string name, string lastname, string address, string email, DateTime dateTime, string login, string password);

        bool RemoveCustomer(Customer customer);

        #endregion

        void FillTestDataInDatabase();
    }
}
