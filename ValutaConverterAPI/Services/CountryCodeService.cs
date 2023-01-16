using Newtonsoft.Json;
using System.Net;

namespace ValutaConverterAPI.Services
{
    public class CountryCodeService
    {
        public CountryCodeService()
        {

        }

        public string GetCountryCode(string country, IConfiguration configuration)
        {

            var code = "";
            var countryLayer = configuration["CountryLayer"];
            var countryLayerFull = countryLayer + country;

            PropertyService propertyService = new PropertyService();
            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";

                // Download data2.
                var data = client.DownloadString(countryLayerFull);
                var result = JsonConvert.DeserializeObject<dynamic>(data);
                var exchangeRate = data;
                foreach (var pair in result[0].currencies)
                {
                    var foo = pair.GetType().GetProperties();
                }

                foreach (string propertyName in propertyService.GetPropertyKeysForDynamic(result[0].currencies))
                {
                    code = propertyName;
                }

            }
            return code;
        }
    }
}
