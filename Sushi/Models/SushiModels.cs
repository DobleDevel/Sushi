using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sushi.Models
{
    public class Order
    {   public int orderId { get; set; }
        [Display(Name = "Дата заказа")]
        [Required]
        public DateTime order_date { get; set; }
        [Display(Name = "Сумма заказа")]
        [Required]
        public decimal order_money { get; set; }

        public virtual Production Production { get; set; }
    }
    public class Production
    {
        public int productionId { get; set; }
        [Required]
        public int categoryId { get; set; }
        [Display(Name = "Наименование продукта")]
        [Required]
        public string product_name { get; set; }
        [Display(Name = "Изображение")]
        [Required]
        public string product_image { get; set; }
        [Display(Name = "Стоимость продукта")]
        [Required]
        public decimal product_cost { get; set; }
        [Display(Name = "Описание продукта продукта")]
        public string product_description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual Category Category { get; set; }
    }
    public class Category
    {
        public int categoryId { get; set; }
        [Display(Name = "Наименование категории")]
        [Required]
        public string category_name { get; set; }
        [Display(Name = "Изображение")]
        public string category_image { get; set; }
    }
    public class Basket
    {
        public int basketId { get; set; }
        [Display(Name = "Итоговая сумма заказа")]
        [Required]
        public decimal basket_result { get; set; }
        [Display(Name = "Описание заказа")]
        [Required]
        public string basket_description { get; set; }
    }
}