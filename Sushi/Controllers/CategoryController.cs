using Sushi.DependencyAndRepositories.Repositories;
using Sushi.Models;
using System.Web.Mvc;
using System.Linq;

namespace Sushi.Controllers
{
    public class CategoryController : Controller
    {
        private DataManager _dm { get; set; }
        public CategoryController(DataManager dm) => _dm = dm;
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
    }
}