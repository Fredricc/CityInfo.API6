using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
   // [Route]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "New Yoek City"},
                    new { id = 2, Name = "Antwerp"}
                });
        }
    }
}
