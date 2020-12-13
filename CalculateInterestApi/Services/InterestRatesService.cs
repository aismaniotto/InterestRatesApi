using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculateInterestApi.Services
{
    public class InterestRatesService : IInterestRatesService
    {
        private readonly string _baseUri = "https://localhost:5000/interestrates";

        public async Task<double> GetInterestRates()
        {
            var uri = _baseUri;
            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                throw new HttpRequestException(content);
            }

            var resultString = await response.Content.ReadAsStringAsync();
            var result = double.Parse(resultString);
            return result;
        }
    }
}
