using System.Diagnostics;

namespace ValutaTester
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetCurrencyNameTestAsyncDenmark()
        {
            var selectedCountry = "Denmark";
            var url = $"http://localhost:7435/Valuta/Valuta/GetCurrencyName?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var expectedResponse = "DKK";
            Assert.Equal(expectedResponse, testString);
        }
        [Fact]
        public async Task GetCurrencyNameTestAsyncGermany()
        {
            var selectedCountry = "Germany";
            var url = $"http://localhost:7435/Valuta/Valuta/GetCurrencyName?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var expectedResponse = "EUR";
            Assert.Equal(expectedResponse, testString);
        }
        [Fact]
        public async Task GetCurrencyNameTestAsyncUSA()
        {
            var selectedCountry = "USA";
            var url = $"http://localhost:7435/Valuta/Valuta/GetCurrencyName?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var expectedResponse = "USD";
            Assert.Equal(expectedResponse, testString);
        }
        [Fact]
        public async Task GetCurrencyNameTestAsyncGB()
        {
            var selectedCountry = "GB";
            var url = $"http://localhost:7435/Valuta/Valuta/GetCurrencyName?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var expectedResponse = "GBP";
            Assert.Equal(expectedResponse, testString);
        }
        [Fact]
        public async Task GetCurrencyNameTestAsyncMexico()
        {
            var selectedCountry = "Mexico";
            var url = $"http://localhost:7435/Valuta/Valuta/GetCurrencyName?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var expectedResponse = "MXN";
            Assert.Equal(expectedResponse, testString);
        }
            [Fact]
            public async Task GetExchangeRateTestAsyncGB()
            {
                var selectedCountry = "GB";
                var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
                var httpClient = new HttpClient();
                var testString = await httpClient.GetStringAsync(url);
                var givenTime = DateTime.Now.ToString("HH:mm-dd.MM.yyyy");
                var response = "{\"currencyName\":\"GBP\",\"currencyRate\":\"0.809144\",\"date\":\"#givenTime#\"}";
                var expectedResponse = response.Replace("#givenTime#", givenTime);
                Assert.Equal(expectedResponse, testString);
            }
        [Fact]
        public async Task GetExchangeRateTestAsyncDenmark()
        {
            var selectedCountry = "Denmark";
            var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var givenTime = DateTime.Now.ToString("HH:mm-dd.MM.yyyy");
            var response = "{\"currencyName\":\"DKK\",\"currencyRate\":\"6.895975\",\"date\":\"#givenTime#\"}";
            var expectedResponse = response.Replace("#givenTime#", givenTime);
            Assert.Equal(expectedResponse, testString);
        }
        [Fact]
        public async Task GetExchangeRateTestAsyncUSA()
        {
            var selectedCountry = "USA";
            var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var givenTime = DateTime.Now.ToString("HH:mm-dd.MM.yyyy");
            var response = "{\"currencyName\":\"USD\",\"currencyRate\":\"1\",\"date\":\"#givenTime#\"}";
            var expectedResponse = response.Replace("#givenTime#", givenTime);
            Assert.Equal(expectedResponse, testString);
        }
        [Fact]
        public async Task GetExchangeRateTestAsyncMexico()
        {
            var selectedCountry = "Mexico";
            var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var givenTime = DateTime.Now.ToString("HH:mm-dd.MM.yyyy");
            var response = "{\"currencyName\":\"MXN\",\"currencyRate\":\"19.030705\",\"date\":\"#givenTime#\"}";
            var expectedResponse = response.Replace("#givenTime#", givenTime);
            Assert.Equal(expectedResponse, testString);
        }
        [Fact]
        public async Task GetExchangeRateTestAsyncGermany()
        {
            var selectedCountry = "Germany";
            var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
            var httpClient = new HttpClient();
            var testString = await httpClient.GetStringAsync(url);
            var givenTime = DateTime.Now.ToString("HH:mm-dd.MM.yyyy");
            var response = "{\"currencyName\":\"EUR\",\"currencyRate\":\"0.92682\",\"date\":\"#givenTime#\"}";
            var expectedResponse = response.Replace("#givenTime#", givenTime);
            Assert.Equal(expectedResponse, testString);
        }
    }
}