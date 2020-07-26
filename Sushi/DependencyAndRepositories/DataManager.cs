using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sushi.DependencyAndRepositories.Repositories
{
    public class DataManager
    {
        public ICategoryRepositories _catalog { get; set; }
        public IOrdersRepository _orders { get; set; }
        public IProductRepositories _product { get; set; }
        public DataManager(
            ICategoryRepositories catalog,
            IOrdersRepository orders,
            IProductRepositories product
            )
        {
            _catalog = catalog;
            _orders = orders;
            _product = product;
        }
    }
}