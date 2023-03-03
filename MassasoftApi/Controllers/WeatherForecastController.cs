using Microsoft.AspNetCore.Mvc;

namespace MassasoftApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
   

        [HttpGet(Name = "test")]
        public async Task<ActionResult> Get()
        {
            return Ok("du hurensohn");
        }
    }
}