using Microsoft.AspNetCore.Mvc;

namespace CalculateInterestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "https://github.com/aismaniotto/InterestRatesApi";
        }
    }
}
