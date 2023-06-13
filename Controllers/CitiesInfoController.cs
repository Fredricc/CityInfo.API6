using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class CitiesInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
