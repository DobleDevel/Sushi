using Sushi.DependencyAndRepositories.Repositories;
using Sushi.Models;
using System.Web.Mvc;

namespace Sushi.Controllers
{
    public class HomeController : Controller
    {
        DataManager _dm;
        ICart _cart;
        public HomeController(DataManager dm, ICart cart)
        {
            _dm = dm;
            _cart = cart;
        }

        //GET: Index View
        public ActionResult Index() => View(new MainViewModel() { Categories = _dm._category.GetCategories() });
        //GET: About View
        public ActionResult About() => View();
        //GET: Contact View
        public ActionResult Contact() => View();

        public ActionResult Delivery() => View();

        public ActionResult Cart() => View(_cart.GetProductionsCart());
    }
}