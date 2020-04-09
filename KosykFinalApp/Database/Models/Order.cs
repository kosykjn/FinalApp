using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace KosykFinalApp.Database.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public OrderStatus Status { get; set; }

        [NotMapped] 
        public double Total => OrderDetails.Sum(od => od.Product.Price * od.Quantity);
    }
}
