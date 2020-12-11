using Microsoft.AspNetCore.Mvc;

namespace InterestRates.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterestRatesController : ControllerBase
    {
        [HttpGet]
        public double Get()
        {
            return 0.01;
        }
    }
}
