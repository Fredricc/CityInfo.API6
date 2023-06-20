using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
