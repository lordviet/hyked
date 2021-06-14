using Hyked.API.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Hyked.API.Services.Contracts;
using Hyked.API.Services.Concrete;
using System;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Hyked.API
{
    public class Startup
    {
        private const string APPLICATION_NAME = "Hyked";

        private const string API_VERSION = "v1";

        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowConfiguredOrigins", builder => builder
                    .WithOrigins("*")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("WWW-Authenticate")
                );
            });

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddMvc(option => option.EnableEndpointRouting = false)
                    .AddNewtonsoftJson();

            //const string connectionString = @"Server=.;Database=HykedTestDB;Trusted_Connection=True;";
            string connectionString = configuration["ConnectionStrings:DefaultConnection"];

            services.AddDbContext<HykedContext>(o =>
            {
                o.UseSqlServer(connectionString);
            });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc($"{API_VERSION}", new OpenApiInfo { Title = $"{APPLICATION_NAME} API", Version = $"{API_VERSION}" });

                c.CustomOperationIds(apiDescription =>
                {
                    return apiDescription.TryGetMethodInfo(out MethodInfo methodInfo) ? methodInfo.Name : null;
                });
            });

            // Register repositories
            services.AddScoped<IHykedRepository, HykedRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseStatusCodePages();

            app.UseCors("AllowConfiguredOrigins");
            
            app.UseMvc();
            
            app.UseSwagger();

            app.UseSwaggerUI(
                c =>
                {
                    c.SwaggerEndpoint($"{API_VERSION}/swagger.json", $"Hyked API {API_VERSION}");

                    c.DisplayOperationId();
                });

            //app.UseCors("default");


            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
