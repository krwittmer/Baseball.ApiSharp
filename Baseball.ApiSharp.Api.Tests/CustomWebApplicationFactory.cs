#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Linq;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Baseball.ApiSharp.Api.Tests
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        private static readonly object _lock = new object();

        /*
         * Integration tests in ASP.NET Core (from Microsoft docs)
         * https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-3.1
         * The docs include class CustomWebApplicationFactory<TStartup> derived from base class WebApplicationFactory<TStartup>
         *
         * TODO: Organize doc and sample contributions to enhance API testing (with more complete source examples).
         *
         * See classes CustomWebApplicationFactory and IndexPageTests
         * https://github.com/dotnet/AspNetCore.Docs/blob/master/aspnetcore/test/integration-tests/samples/3.x/IntegrationTestsSample/tests/RazorPagesProject.Tests/IntegrationTests/IndexPageTests.cs
         *
         *
         * TODO: Investigate and resolve logging with customized Web application factory (and invoking of API-centric unit tests)
         * TODO: Logging includes event source (how to use this built-in logging subsystem, AddEventSourceLogger())
         *
         */
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            lock (_lock)
            {
                builder.ConfigureServices(services =>
                {
                    // Remove the prior LahmansDbContext registration.
                    var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<LahmansDbContext>));
                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    services.AddLogging(config => config.AddConsole());
                    services.AddLogging(config => config.AddDebug());
                    // TODO: services.AddLogging(config => config.AddEventSourceLogger());

                    // Add ApplicationDbContext using an in-memory database for testing.
                    services.AddDbContext<LahmansDbContext>(options =>
                    {
                        options.UseInMemoryDatabase("InMemoryDbForTesting");
                    });

                    // Build the service provider.
                    var serviceProvider = services.BuildServiceProvider();

                    // Create a scope to obtain a reference to the database
                    using (var scope = serviceProvider.CreateScope())
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
}
