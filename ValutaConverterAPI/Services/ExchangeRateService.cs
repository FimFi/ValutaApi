using Newtonsoft.Json;
using System.Net;
using ValutaConverterAPI.Entity;

namespace ValutaConverterAPI.Services
{
    public class ExchangeRateService
    {
        public ExchangeRateService()
        {

        }

        public ExchangeRate GetExchangeRate(string currencyName, IConfiguration configuration)
        {
            var latestValuta = configuration["LatestValuta"];
            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";

                var data = client.DownloadString(latestValuta);
                var result = JsonConvert.DeserializeObject<Root>(data);
                var exchangeRate = result.rates.GetType().GetProperty(currencyName).GetValue(result.rates, null);

                return new ExchangeRate()
                {
                    CurrencyRate = exchangeRate.ToString(),
                    CurrencyName = currencyName,
                    Date = DateTime.Now.ToString("HH:mm-dd.MM.yyyy")
                };

            }
        }
    }
}
