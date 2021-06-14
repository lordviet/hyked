using Hyked.API.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog.Web;
using System;

namespace Hyked.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder
                    .ConfigureNLog("nlog.config")
                    .GetCurrentClassLogger();

            try
            {
                var host = CreateHostBuilder(args).Build();
                using (var scope = host.Services.CreateScope())
                {
                    try
                    {
                        var context = scope.ServiceProvider.GetService<HykedContext>();

                        // For demo purposes delete the db & migrate on startup so we can start with clean state
                        //context.Database.EnsureDeleted();

                        context.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex, "An error occurred while migrating the database.");
                    }
                }

                host.Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Application stopped because of exception.");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseStartup<Startup>()
                        .UseNLog();
                });
    }
}
