using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using ValutaConverterAPI.Entity;
using ValutaConverterAPI.Interface;
using ValutaConverterAPI.Services;

namespace ValutaConverterAPI.Controllers
{
    [ApiController]
    [Route("Valuta")]
    public class ValutaConverterController : ControllerBase, IExchangeValueCalculater
    {
        private readonly ILogger<ValutaConverterController> _logger;
        private readonly IConfiguration _configuration;
        private CountryCodeService countryCodeService = new CountryCodeService();
        private ExchangeRateService exchangeRateService = new ExchangeRateService();

        public ValutaConverterController(ILogger<ValutaConverterController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }


        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Route("Valuta/GetCurrencyName")]
        public string GetCurrencyName(string countryName)
        {
            ;
            return countryCodeService.GetCountryCode(countryName, _configuration);
        }


        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Route("Valuta/GetExchangeRate")]
        public ExchangeRate GetExchangeRate(string countryName)
        {
            var currencyName = countryCodeService.GetCountryCode(countryName, _configuration);
            return exchangeRateService.GetExchangeRate(currencyName, _configuration);

        }

    }

}
