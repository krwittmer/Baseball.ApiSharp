using Baseball.ApiSharp.Dal;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization;
using Baseball.ApiSharp.Dal.Repos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Baseball.ApiSharp.Api.Tests.Tags
{
    public class StartupTest
    {
        public StartupTest(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            var dbConfig = new EnvironmentDbConfig { UseInMemoryDb = true };
            var dbContextOptions = dbConfig.GetDbContextOptions();
            services.AddDbContextPool<LahmansDbContext>(dbContextOptions);

            services.AddScoped<DbContext, LahmansDbContext>();
            services.AddScoped<IReadRepository, Repository>();
            services.AddScoped<IRepository, Repository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            SampleDataInitializer.InitializeInMemoryDb(serviceScope.ServiceProvider.GetRequiredService<LahmansDbContext>());

            app.UseDeveloperExceptionPage();
            app.UseExceptionHandler("/Home/Error");

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
