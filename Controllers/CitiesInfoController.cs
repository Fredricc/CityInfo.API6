using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class CitiesInfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
