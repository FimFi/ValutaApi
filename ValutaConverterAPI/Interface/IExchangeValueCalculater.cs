using ValutaConverterAPI.Controllers;
using ValutaConverterAPI.Entity;

namespace ValutaConverterAPI.Interface
{
    public interface IExchangeValueCalculater
    {
        public string GetCurrencyName(string countryName);
        public ExchangeRate GetExchangeRate(string countryName);
    }
}
