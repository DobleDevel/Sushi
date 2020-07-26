using Sushi.DependencyAndRepositories.Repositories;
using Sushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sushi.Controllers
{
    public class HomeController : Controller
    {
        DataManager _dm;
        public HomeController(DataManager dm) => _dm = dm;
        public ActionResult Index()
        {
            return View(new MainViewModel() { Categories=_dm._catalog.GetCategories()});
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}