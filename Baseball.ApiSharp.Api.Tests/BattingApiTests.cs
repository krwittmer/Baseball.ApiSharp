#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Baseball.ApiSharp.Models;
using Newtonsoft.Json;
using Xunit;

namespace Baseball.ApiSharp.Api.Tests
{
    [Trait("Category", "BattingApi")]
    public class BattingApiTests : ApiTestBase, IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public BattingApiTests(CustomWebApplicationFactory<Startup> factory) : base(factory) { }

        [Fact]
        public async Task BatterApiNullBatterId()
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            const string batterId = null;
            var response = await client.GetAsync($"/api/batters/{batterId}");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            // Teardown
            client.Dispose();
        }

        [Fact]
        public async Task BatterApiEmptyBatterId()
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            string batterId = string.Empty;
            var response = await client.GetAsync($"/api/batters/{batterId}");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            // Teardown
            client.Dispose();
        }

        [Fact]
        public async Task GetBatterApiResult()
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            const string batterId = "fyhrimi01";
            var response = await client.GetAsync($"/api/batters/{batterId}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            // TODO: Transition from First() to FirstAsync(), if possible in this API test context.
            var batter = JsonConvert.DeserializeObject<BatterModel[]>(jsonContent).First();
            Assert.NotNull(batter);
            Assert.Equal($"{batterId}", batter.PlayerId);

            // Teardown
            client.Dispose();
        }

        [Theory]
        [InlineData("thomafr04", 2000)]
        public void ReturnsOkForValidBatterIdAndYearId(string batterId, int yearId)
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            var response = client.GetAsync($"/api/batters/{batterId}/years/{yearId}").Result;
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = response.Content.ReadAsStringAsync().Result;
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var battingData = JsonConvert.DeserializeObject<BatterModel[]>(jsonContent);
            Assert.True(1 == battingData.Length);
            Assert.Contains(battingData, batter => batter.PlayerId == batterId);

            // Teardown
            client.Dispose();
        }
    }
}
