using System;
using System.Collections.Generic;

namespace Sushi.Models
{
    public class Order
    {   public int orderId { get; set; }
        public DateTime order_date { get; set; }
        public decimal order_money { get; set; }

        public virtual Production Production { get; set; }
    }
    public class Production
    {
        public int productionId { get; set; }
        public int categoryId { get; set; }
        public string product_name { get; set; }
        public string product_image { get; set; }
        public decimal product_cost { get; set; }
        public string product_description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual Category Category { get; set; }
    }
    public class Category
    {
        public int categoryId { get; set; }
        public string category_name { get; set; }
        public string category_image { get; set; }
    }
}