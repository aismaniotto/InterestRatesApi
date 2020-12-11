using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculateInterestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateInterestController : ControllerBase
    {
        [HttpGet]
        public double Get(double initValue, int months)
        {
            return initValue * Math.Pow((1 + 0.01), months);
        }
    }
}
