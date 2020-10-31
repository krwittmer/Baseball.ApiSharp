using System.IO;
using System.Threading;
using Baseball.ApiSharp.Dal.Tests;
using Microsoft.AspNetCore.Hosting;
using RestSharp;
using static System.String;

namespace Baseball.ApiSharp.Api.Tests.Tags
{
    public class RestSharpClientTest
    {
        protected IWebHost _host;

        protected RestClient GetClient()
        {
            var randomPort = RandomNumberHelper.NextIntegerInRange(5120, 8192);
            var httpServerUrl = $"http://*:{randomPort}";

            _host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<StartupTest>()
                .UseUrls(httpServerUrl)
                .Build();

            _host.Start();

            Thread.Sleep(3000);

            string localHostUrl = Format("http://localhost:{0}", randomPort);
            return new RestClient(localHostUrl);
        }
    }
}
