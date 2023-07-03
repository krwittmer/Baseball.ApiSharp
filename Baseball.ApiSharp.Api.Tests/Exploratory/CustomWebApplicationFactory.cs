using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization;

namespace Baseball.ApiSharp.Api.Tests.Exploratory
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                        typeof(DbContextOptions<LahmansDbContext>));

                services.Remove(descriptor);
                services.AddDbContext<LahmansDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                });

                var provider = services.BuildServiceProvider();
                using (var scope = provider.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    using (var context = scopedServices.GetRequiredService<LahmansDbContext>())
                    {
                        var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

                        logger.LogDebug("Preparing database creation (if necessary)");
                        // Ensure the database is created.
                        context.Database.EnsureCreated();
                        logger.LogDebug("Database created (if necessary)");

                        try
                        {
                            // Seed the database with test data.
                            SampleDataInitializer.InitializeInMemoryDb(context);
                        }
                        catch (Exception ex)
                        {
                            logger.LogError(ex, "An error occurred seeding the " +
                                                "database with sample data. Error: {Message}", ex.Message);
                        }
                    }
                }
            });
        }

    }
}
