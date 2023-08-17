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
        private static List<Farmer> _farmers = new List<Farmer> {    // List of Farmer Controller Property
            new Farmer(),                                           // with list of Initialised farmers
            
            // Farmer Class Ctor called  
            // Object Creation with initialization
            new Farmer{ FarmerId=1, FarmerName="ABC" , FarmerPlace="abc" , MobileNo=9999912345, Aadhaar=123412341234}
            
        };

        public FarmersController(IFarmerService farmerService ) { _farmerService = farmerService; }

        [HttpGet()]
        public ActionResult<Farmer> Get() {
            return Ok(farmer);
        }

        [HttpGet("GetAll")]
        public ActionResult<Farmer> GetFarmers() {
            return Ok(_farmers);    
        }


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
