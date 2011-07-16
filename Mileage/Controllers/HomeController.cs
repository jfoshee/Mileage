using System.Web.Mvc;

namespace Mileage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "My My Mileage...";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
