using System.Web.Mvc;
using Mileage.Models;

namespace Mileage.Controllers
{
    public class TripController : Controller
    {
        public MileageDB MileageDB { get; set; }

        public TripController()
        {
            MileageDB = new MileageDB();
        }

        public ViewResult Index()
        {
            return View(MileageDB.Trips);
        }
    }
}
