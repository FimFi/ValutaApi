// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Customer!");
Console.WriteLine("What would country's exchange rate, would you like to find today?");
var selectedCountry = Console.ReadLine();
var url = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry}";
var httpClient = new HttpClient();
var HttpResponse = await httpClient.GetStringAsync(url);
Console.WriteLine(HttpResponse);
Console.WriteLine("What other country's exchange rate, would you like to find??");
var selectedCountry2 = Console.ReadLine();
var url2 = $"http://localhost:7435/Valuta/Valuta/GetExchangeRate?countryName={selectedCountry2}";
var httpClient2 = new HttpClient();
var HttpResponse2 = await httpClient2.GetStringAsync(url2);
Console.WriteLine(HttpResponse2);
Console.WriteLine("Congratulations, you have now found 2 countries and their exchange rate.");