using KosykFinalApp.Database;
using System;
using System.Linq;
using System.Data.Entity;
using KosykFinalApp.Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KosykFinalApp.Managers.DB
{
    public class DatabaseManagerModel : IDatabaseManager
    {
        private readonly DatabaseContext context;

        #region Constructors

        public DatabaseManagerModel()
        {
            context = new DatabaseContext();
        }

        #endregion

        #region Login

        public LoginResult Login(string login, string password)
        {
            try
            {
                var autorizedUser = default(IAutorizedUser);

                var encryptedPassword = PasswordEncryptor.Encrypt(password);

                var findUser = context.Users
                  .SingleOrDefault(user => user.Login.Equals(login) && user.Password.Equals(encryptedPassword));

                if (findUser != null)
                {
                    switch (findUser.Role)
                    {
                        case Role.Manager:
                            autorizedUser = context.Managers
                                .Include(manager => manager.User)
                                .SingleOrDefault(manager => manager.User.Id == findUser.Id);
                            break;
                        case Role.Customer:
                            autorizedUser = context.Customers
                                .Include(customer => customer.User)
                                .SingleOrDefault(customer => customer.User.Id == findUser.Id);
                            break;
                    }
                }

                return autorizedUser != null
                    ? new LoginResult(true, autorizedUser)
                    : new LoginResult(false, null);
            }
            catch (Exception e)
            {
                return new LoginResult(false, null);
            }
        }

        public Task<LoginResult> LoginAsync(string login, string password)
        {
            return Task.Run(() => Login(login, password));
        }

        #endregion

        #region Product

        public bool AddProdurcts(string name, double price)
        {
            try
            {
                context.Products.Add(new Product()
                {
                    Name = name,
                    Price = price,
                    CreateDate = DateTime.Now                    
                });

                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }         
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        #endregion

        #region Order

        public bool AddOrder(Customer customer, IEnumerable<(Product, int)> productQuantities, out Order addedOrder)
        {
            try
            {
                addedOrder = new Order()
                {
                    Status = OrderStatus.New,
                    Customer = customer,
                    CreateDate = DateTime.Now,
                    OrderDetails = productQuantities.Select(pq => new OrderDetail()
                    {
                        Product = pq.Item1,
                        Quantity = pq.Item2
                    }).ToList()
                };

                context.Orders.Add(addedOrder);

                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                addedOrder = default(Order);
                return false;
            }
        }

        public IEnumerable<Order> GetOrdersByCustomer(Customer customer)
        {
            return context.Orders.Include(o => o.OrderDetails).Where(o => o.Customer.Id == customer.Id).ToList();
        }

        public IEnumerable<Order> GetOrdersByStatus(OrderStatus status)
        {
            try
            {
                return context.Orders.Include(o => o.Customer).Where(o => o.Status == status).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool SetOrderStatus(Order order, OrderStatus status)
        {
            try
            {
                order.Status = status;

                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetOrders()
        {
            return context.Orders.Include(o => o.Customer).ToList();
        }

        #endregion

        #region Customer

        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.Include(c => c.User).ToList();
        }

        public bool AddCustomer(string name, string lastname, string address, string email,
            DateTime dateTime, string login, string password)
        {
            try
            {
                context.Customers.Add(new Customer()
                {
                    Name = name,
                    LastName = lastname,
                    Address = address,
                    Email = email,
                    DateOfBirth = dateTime,
                    User = new User()
                    {
                        Login = login,
                        Password = PasswordEncryptor.Encrypt(password),
                        Role = Role.Customer
                    }
                });

                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveCustomer(Customer customer)
        {
            try
            {
                //Clear orders
                var customerOrders = GetOrdersByCustomer(customer);

                foreach (var customerOrder in customerOrders)
                {
                    context.OrderDetails.RemoveRange(customerOrder.OrderDetails);
                    context.Orders.Remove(customerOrder);
                }

                //Clear user data
                context.Users.Remove(customer.User);

                //Remove customer
                context.Customers.Remove(customer);

                //Save changes
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        public void FillTestDataInDatabase()
        {
            context.Managers.Add(new Manager
            {
                Name = "Alexander",
                LastName = "Alexandrov",
                Address = "Zhytomer",
                Email = "alexandrov@ukr.net",
                DateOfBirth = new DateTime(1989, 10, 10),
                User = new User
                {
                    Login = "alex",
                    Password = PasswordEncryptor.Encrypt("alex"),
                    Role = Role.Manager
                }
            });

            context.Customers.Add(new Customer
            {
                Name = "Ivan",
                LastName = "Ivanov",
                Address = "Kyiv",
                Email = "ivanov@ukr.net",
                DateOfBirth = new DateTime(1985, 1, 1),
                User = new User
                {
                    Login = "ivan",
                    Password = PasswordEncryptor.Encrypt("ivan"),
                    Role = Role.Customer
                }
            });

            context.SaveChanges();
        }
    }
}
