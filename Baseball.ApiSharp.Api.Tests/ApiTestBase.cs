#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Baseball.ApiSharp.Api.Tests
{
    public class ApiTestBase
    {
        protected readonly WebApplicationFactory<Startup> _factory;

        public ApiTestBase(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        protected virtual HttpClient CreateHttpClient()
        {
            return _factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
            /*
            return _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services => new ServiceCollection()
                    .AddLogging(config => config.AddConsole())
                    .AddLogging(config => config.AddDebug())
                    .BuildServiceProvider());
            }).CreateClient();
            */
        }
    }
}
