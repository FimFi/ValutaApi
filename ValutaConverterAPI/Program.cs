public class Program {

    public static void Main(string[] args) {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(String[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(WebApplicationBuilder =>
            {
                WebApplicationBuilder.UseStartup<ValutaConverterAPI.Startup>();
            })
            .ConfigureAppConfiguration(builder =>
            {
                builder.AddJsonFile("appsettings.json");
            });
    }

  
}