using KosykFinalApp.Managers.DB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KosykFinalApp.Tests
{
    [TestClass]
    public class DatabaseManagerTests
    {
        private readonly IDatabaseManager databaseManager;

        public DatabaseManagerTests()
        {
            databaseManager = new DatabaseManagerModel();
        }

        [TestMethod]
        public void LoginTest()
        {
            var result = databaseManager.Login("alex", "alex");

            Assert.IsTrue(databaseManager.Login("alex", "alex"));
        }

        [TestMethod]
        public void GetProductsTest()
        {
            var result = databaseManager.GetProducts();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetOrdersTest()
        {
            var result = databaseManager.GetOrders();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetCustomersTest()
        {
            var result = databaseManager.GetCustomers();
            Assert.IsNotNull(result);
        }
    }
}
