using System;
using System.Threading.Tasks;
using CalculateInterestApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculateInterestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateInterestController : ControllerBase
    {
        private readonly IInterestRatesService _interestRatesService;


        public CalculateInterestController(IInterestRatesService interestRatesService)
        {
            _interestRatesService = interestRatesService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(double initValue, int months)
        {
            double interestRates; ;
            try
            {
                interestRates = await _interestRatesService.GetInterestRates();
            }
            catch
            {
                return BadRequest(StatusCode(500, "Internal server error"));
            }
            var value = initValue * Math.Pow((1 + interestRates), months);

            // truncate the value
            double mult = Math.Pow(10, 2);
            double result = Math.Truncate(mult * value) / mult;

            return Ok(result);
        }
    }
}
