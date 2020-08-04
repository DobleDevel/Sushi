using Sushi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Sushi.DependencyAndRepositories.Repositories
{
    public interface ICart
    {
        void AddToCart(Production production);
        void RemoveFromCart(int id);

        List<Production> GetProductionsCart();

    }
    public class Cart : ICart
    {
        private static List<Production> _cartproduction { get; set; } = new List<Production>();
        public void AddToCart(Production production) => _cartproduction.Add(production);
        public List<Production> GetProductionsCart() => _cartproduction;

        public static int GetCountCart() => _cartproduction.Count();

        public static decimal GetResultSumm() => _cartproduction.Sum(x => x.product_cost);

        public static bool ProdExist(int id) => _cartproduction.Find(prod => prod.productionId == id) == null ? false : true;

        public void RemoveFromCart(int id) => _cartproduction.Remove(_cartproduction.Where(p=>p.productionId==id).FirstOrDefault());
    }
}
