using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Diagnostics;
using System.Reflection;
using System.Runtime;
using System.Security.Claims;

namespace ValutaConverterAPI
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;

        }



        public IConfiguration Configuration { get; }



        public void ConfigureServices(IServiceCollection services)
        {

            IdentityModelEventSource.ShowPII = true; 

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo() { Title = "ValutaConverter API", Version = "v1" });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

            });


        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseRouting();

            app.UseHttpsRedirection();


            app.UseAuthentication();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();

            });

            app.UseStatusCodePages();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {

                c.RoutePrefix = "swagger/ui";

                c.DocExpansion(DocExpansion.None);

                c.SwaggerEndpoint($"/swagger/v1/swagger.json", "ValutaConverter API");

            });

        }

    }

}