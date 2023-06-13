using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class CitiesInfoController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
