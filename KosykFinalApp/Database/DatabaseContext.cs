using System.Data.Entity;
using KosykFinalApp.Database.Models;

namespace KosykFinalApp.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("DbConnection")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
