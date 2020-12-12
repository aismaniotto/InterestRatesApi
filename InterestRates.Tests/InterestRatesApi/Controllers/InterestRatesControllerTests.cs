using System;
using InterestRates.Controllers;
using NUnit.Framework;

namespace InterestRates.Tests.InterestRatesApi.Controllers
{
    public class InterestRatesControllerTests
    {
        public InterestRatesController Controller { get; set; }

        [OneTimeSetUp]
        public void Init()
        {
            Controller = new InterestRatesController();
        }

        [Test]
        public void Should_Return_Constant_Value_From_Interest_Rates_End_Point()
        {
            var constValueExpected = 0.01;
            var interestRate = Controller.Get();
            Assert.AreEqual(constValueExpected, interestRate);
        }
    }
}
