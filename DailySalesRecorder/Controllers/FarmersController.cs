using DailySalesRecorder.Models;
using DailySalesRecorder.Services.FarmerService;
using Microsoft.AspNetCore.Mvc;

namespace DailySalesRecorder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FarmersController : ControllerBase
    {

        private static Farmer farmer = new Farmer();
        private readonly IFarmerService _farmerService;

        public FarmersController(IFarmerService farmerService ) { _farmerService = farmerService; }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _farmerService.View(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Farmer farmer)
        {            
            return Ok(await _farmerService.AddFarmer(farmer));
        }


    }
}
