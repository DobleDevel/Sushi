using Sushi.Models;
using System.Collections.Generic;

namespace Sushi.DependencyAndRepositories.Repositories
{
    public interface ICart
    {
        void AddToCart(Production production);
        void RemoveFromCart(Production production);

        List<Production> GetProductionsCart();
    }
    public class Cart : ICart
    {
        private List<Production> _cartproduction { get; set; }
        public void AddToCart(Production production) => _cartproduction.Add(production);
        public List<Production> GetProductionsCart() => _cartproduction;

        public void RemoveFromCart(Production production) => _cartproduction.Remove(production);
    }
}
