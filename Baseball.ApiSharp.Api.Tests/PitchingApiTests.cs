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
    [Trait("Category", "PitchingApi")]
    public class PitchingApiTests : ApiTestBase, IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public PitchingApiTests(CustomWebApplicationFactory<Startup> factory) : base(factory) { }

        [Fact(Skip = "TODO: Resolve HUT-integration testing")]
        public async Task GetPitcherApiResult()
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            const string pitcherId = "cobbty01";
            var response = await client.GetAsync($"/api/pitchers/{pitcherId}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var pitcher = JsonConvert.DeserializeObject<PitcherModel[]>(jsonContent).First();
            Assert.NotNull(pitcher);
            Assert.Equal($"{pitcherId}", pitcher.PlayerId);

            // Teardown
            client.Dispose();
        }
    }
}
