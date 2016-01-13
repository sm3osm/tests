using Microsoft.AspNet.Mvc;

namespace Tommy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Index", "Customers");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About this application:";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact information:";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
