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
            public async Task Test2Async()
            {
                var selectedCountry = "GB";
                var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
                var httpClient = new HttpClient();
                var testString = await httpClient.GetStringAsync(url);
                var givenTime = DateTime.Now.ToString("HH:mm-dd.MM.yyyy");
                var response = "{\"currencyName\":\"GBP\",\"currencyRate\":\"0.809542\",\"date\":\"#givenTime#\"}";
                var expectedResponse = response.Replace("#givenTime#", givenTime);
                Assert.Equal(expectedResponse, testString);
            }
    }
}