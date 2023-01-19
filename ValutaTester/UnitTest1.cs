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
        /*    [Fact]
            public async Task Test2Async()
            {
                var selectedCountry = "Denmark";
                var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
                var httpClient = new HttpClient();
                var testString = await httpClient.GetStringAsync(url);
                var expectedResponse = "{"currencyName": "DKK","currencyRate": "6,882488","date": "16:19-19.01.2023"}";
                Assert.Equal(expectedResponse, testString);
            }*/
    }
}