using System;
using System.Collections.Generic;

namespace KosykFinalApp.Database.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
