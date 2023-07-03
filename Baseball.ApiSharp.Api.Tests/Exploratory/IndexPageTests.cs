using Baseball.ApiSharp.Api.Tests;
using Baseball.ApiSharp.Api.Tests.Exploratory;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RazorPagesProject.Tests
{
    public class IndexPageTests : IClassFixture<Baseball.ApiSharp.Api.Tests.Exploratory.CustomWebApplicationFactory<Baseball.ApiSharp.Api.Startup>>
    {
        private readonly HttpClient _client;
        private readonly Baseball.ApiSharp.Api.Tests.Exploratory.CustomWebApplicationFactory<Baseball.ApiSharp.Api.Startup>
            _factory;

        public IndexPageTests(Baseball.ApiSharp.Api.Tests.Exploratory.CustomWebApplicationFactory<Baseball.ApiSharp.Api.Startup> factory)
        {
            _factory = factory;
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        [Fact]
        public async Task GetResponseAsyc_RootUri()
        {
            // Arrange
            var uriPath = await _client.GetAsync("/");
            var content = await Baseball.ApiSharp.Api.Tests.Exploratory.HtmlHelpers.GetResponseAsync(uriPath);
            Assert.NotEmpty(content);
        }

    }
}
