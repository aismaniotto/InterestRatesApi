using System;
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
        public void Should_Return_The_Interest_Rates_Acording_The_Parameters()
        {
            Assert.AreEqual(105.1, Controller.Get(100, 5));
            Assert.AreEqual(563.41, Controller.Get(500, 12));
        }
    }
}
