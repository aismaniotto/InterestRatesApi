using System;
using CalculateInterestApi.Controllers;
using NUnit.Framework;

namespace InterestRates.Tests.CalculateInterestApi.Controllers
{
    public class ShowMeTheCodeControllerTests
    {
        public ShowMeTheCodeController Controller { get; set; }

        [OneTimeSetUp]
        public void Init()
        {
            Controller = new ShowMeTheCodeController();
        }

        [Test]
        public void Should_Return_Repo_Address_From_Show_Me_The_Code_End_Point()
        {
            var repoAddressExpected = "https://github.com/aismaniotto/InterestRatesApi";
            var repoAddress = Controller.Get();
            Assert.AreEqual(repoAddressExpected, repoAddress);
        }
    }
}
