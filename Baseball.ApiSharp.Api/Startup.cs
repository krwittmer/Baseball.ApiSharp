#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Dal;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization;
using Baseball.ApiSharp.Dal.Repos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Baseball.ApiSharp.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            var dbConfig = new EnvironmentDbConfig {UseInMemoryDb = ClaHelper.HasMatchingArgument("i")};
            var dbContextOptions = dbConfig.GetDbContextOptions();
            services.AddDbContextPool<LahmansDbContext>(dbContextOptions);

            services.AddScoped<DbContext, LahmansDbContext>();
            services.AddScoped<IReadRepository, Repository>();
            services.AddScoped<IRepository, Repository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (ClaHelper.HasMatchingArgument("i")) // use in-memory DB and load with sample data
            {
                using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
                SampleDataInitializer.InitializeInMemoryDb(serviceScope.ServiceProvider.GetRequiredService<LahmansDbContext>());
            }

            if (env.IsDevelopment() || env.IsEnvironment("Local"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            // TODO: app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
