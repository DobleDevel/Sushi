using Sushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sushi.DependencyAndRepositories.Repositories
{
     public interface IProductRepositories
    {
        void AddProduct(Production production);
        void RemoveProduct(int id);
        List<Production> GetProducts();
    }
    public class ProductRepository : IProductRepositories
    {
        private ApplicationDbContext db;
        public ProductRepository()
        {
            db = ApplicationDbContext.Create();
        }
        public void AddProduct(Production production)
        {
            throw new NotImplementedException();
        }

        public List<Production> GetProducts() => db.Productions.ToList();

        public void RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
