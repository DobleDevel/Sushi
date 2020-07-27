using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sushi.DependencyAndRepositories.Repositories
{
    public class DataManager
    {
        public ICategoryRepositories _category { get; set; }
        public IOrdersRepository _orders { get; set; }
        public IProductRepositories _product { get; set; }
        public DataManager(
            ICategoryRepositories category,
            IOrdersRepository orders,
            IProductRepositories product
            )
        {
            _category = category;
            _orders = orders;
            _product = product;
        }
    }
}