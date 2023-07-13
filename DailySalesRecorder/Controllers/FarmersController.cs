using Microsoft.AspNetCore.Mvc;

namespace DailySalesRecorder.Controllers
{
    [ApiController]
    [Route("controller")]
    public class FarmersController : Controller
    {
        
        [HttpGet("Farmer")]
        //[HttpGet(Name = "GetFarmers")]
        public IActionResult Get()
        {
            return Ok("Hello World!...");
        }
    }
}
