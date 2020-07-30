using Sushi.DependencyAndRepositories.Repositories;
using Sushi.Models;
using System.Web.Mvc;
using System.Linq;

namespace Sushi.Controllers
{
    public class CategoryController : Controller
    {
        private DataManager _dm { get; set; }
        private ICart _cart { get; set; }
        public CategoryController(DataManager dm, ICart cart)
        {
            _dm = dm;
            _cart = cart;
        }

        public ActionResult Menu(int? categoryId)
        {   categoryId = categoryId ?? 1;
            return View(new CategoryViewModel()
            {   
                categories = _dm._category.GetCategories(),
                productions = (from prod in _dm._product.GetProducts()
                               where prod.Category.categoryId == categoryId
                               select prod).ToList()


            });
        }
        public void AddCart(int id)
        {   
            if(!Cart.ProdExist(id))
            _cart.AddToCart(_dm._product.GetProductFromId(id));
        }
    }
}