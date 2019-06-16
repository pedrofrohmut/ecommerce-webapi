using Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Webapi
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = CreateWebHostBuilder(args).Build();

      using (var scope = host.Services.CreateScope()) 
      {
        var services = scope.ServiceProvider;
        try {
          var context = services.GetRequiredService<ECommerceDbContext>();
          context.Database.Migrate();
          SeedData.Initialize(services);
        } catch (Exception e) {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(e, "An error has occured seeding the database");
        }
      }

      host.Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
      WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
  }
}
