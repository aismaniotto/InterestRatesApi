using System;
using System.Threading.Tasks;
using CalculateInterestApi.Services;
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
        public async Task<double> Get(double initValue, int months)
        {
            var interestRates = await _interestRatesService.GetInterestRates();
            return initValue * Math.Pow((1 + interestRates), months);
        }
    }
}
