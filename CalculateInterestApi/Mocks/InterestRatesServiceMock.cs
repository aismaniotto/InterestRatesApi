using System.Threading.Tasks;
using CalculateInterestApi.Services;

namespace CalculateInterestApi.Mocks
{
    public class InterestRatesServiceMock : IInterestRatesService
    {
        public Task<double> GetInterestRates()
        {
            return Task.Run(() => 0.01);
        }
    }
}
