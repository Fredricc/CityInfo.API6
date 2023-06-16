using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class PointOfInterestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
