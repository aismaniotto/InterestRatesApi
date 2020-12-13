using System.Threading.Tasks;

namespace CalculateInterestApi.Services
{
    public interface IInterestRatesService
    {
        Task<double> GetInterestRates();
    }
}
