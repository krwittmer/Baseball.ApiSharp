#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Baseball.ApiSharp.Api.Tests
{
    [Trait("Category", "BasicApiStatus")]
    public class BasicApiTests : ApiTestBase, IClassFixture<WebApplicationFactory<Startup>>
    {
        public BasicApiTests(WebApplicationFactory<Startup> factory) : base(factory) { }

        [Theory(Skip = "TODO: Resolve HUT-integration testing")]
        [InlineData("/")]
        public async Task GetEndpointReturnSuccessStatusCodeAndCorrectContentType(string url)
        {
            // Arrange
            var client = CreateHttpClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());

            // Teardown
            client.Dispose();
        }
    }
}
