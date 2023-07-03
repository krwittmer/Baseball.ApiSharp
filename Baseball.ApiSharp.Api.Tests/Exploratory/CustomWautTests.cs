using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using System.Threading.Tasks;

namespace Baseball.ApiSharp.Api.Tests.Exploratory
{
    public class IntermediateWautTests : IClassFixture<CustomWebApplicationFactory<Baseball.ApiSharp.Api.Startup>>
    {
        private readonly CustomWebApplicationFactory<Baseball.ApiSharp.Api.Startup> _factory;

        public IntermediateWautTests(CustomWebApplicationFactory<Baseball.ApiSharp.Api.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        public async Task Get_EndpointsReturnSuccess(string url)
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
        }
    }
}
