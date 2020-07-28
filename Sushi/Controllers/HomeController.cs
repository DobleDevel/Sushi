using Sushi.DependencyAndRepositories.Repositories;
using Sushi.Models;
using System.Web.Mvc;

namespace Sushi.Controllers
{
    public class HomeController : Controller
    {
        DataManager _dm;
        public HomeController(DataManager dm) => _dm = dm;
        //GET: Index View
        public ActionResult Index() => View(new MainViewModel() { Categories = _dm._category.GetCategories() });
        //GET: About View
        public ActionResult About() => View();
        //GET: Contact View
        public ActionResult Contact() => View();

        public ActionResult Delivery() => View();

    }
}