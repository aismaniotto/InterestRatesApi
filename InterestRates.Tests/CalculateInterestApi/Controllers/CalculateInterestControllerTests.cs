using System.Threading.Tasks;
using CalculateInterestApi.Controllers;
using CalculateInterestApi.Mocks;
using NUnit.Framework;

namespace InterestRates.Tests.CalculateInterestApi.Controllers
{
    public class CalculateInterestControllerTests
    {
        public CalculateInterestController Controller { get; set; }

        [OneTimeSetUp]
        public void Init()
        {
            Controller = new CalculateInterestController(new InterestRatesServiceMock());
        }

        [Test]
        public async Task Should_Return_The_Interest_Rates_Acording_The_Parameters()
        {
            Assert.AreEqual(105.10, await Controller.Get(100, 5));
            Assert.AreEqual(563.41, await Controller.Get(500, 12));
        }
    }
}
