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
    [Trait("Category", "PlayerApi")]
    public class PlayerIdTests : ApiTestBase, IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public PlayerIdTests(CustomWebApplicationFactory<Startup> factory) : base(factory) { }

        [Theory(Skip = "TODO: Resolve HUT-integration testing")]
        [InlineData("Willie%20Mays", "mayswi01")]
        [InlineData("Hank%20Aaron", "aaronha01")]
        [InlineData("Babe%20Ruth", "ruthba01")]
        public async Task ReturnsOkForPlayersWhoAreGreatBatters(string playerName, string playerId)
        {
            // Arrange
            var client = CreateHttpClient();

            // Act
            var response = await client.GetAsync($"/api/playerids/{playerName}");

            // Asserts
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var playerData = JsonConvert.DeserializeObject<PlayerIdModel[]>(jsonContent);
            var batter = playerData.First();
            Assert.NotNull(batter);
            Assert.Equal(playerId, batter.PlayerId);

            // Teardown
            client.Dispose();
        }

        [Theory(Skip = "TODO: Resolve HUT-integration testing")]
        [InlineData("John", 5)]
        [InlineData("Mike", 9)]
        public async Task ReturnsOkForPlayersWhoAreGreatBatterWithPaging(string playerName, int playerMatchCount)
        {
            // Arrange
            var client = CreateHttpClient();

            // Act
            var response = await client.GetAsync($"/api/playerids/{playerName}/page/0");

            // Asserts
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var playerData = JsonConvert.DeserializeObject<PlayerIdModel[]>(jsonContent);
            Assert.True(playerMatchCount == playerData.Length);

            // Teardown
            client.Dispose();
        }

        [Theory(Skip = "TODO: Resolve HUT-integration testing")]
        [InlineData("Stan%20Musial", "musiast01")]
        [InlineData("Ty%20Cobb", "cobbty01")]
        [InlineData("Lou%20Gehrig", "gehrilo01")]
        public void ReturnsOkMoreGreatBattersBlocking(string playerName, string playerId)
        {
            // Arrange
            var client = CreateHttpClient();

            // Act
            var response = client.GetAsync($"/api/playerids/{playerName}").Result;

            // Asserts
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = response.Content.ReadAsStringAsync().Result;
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var playerData = JsonConvert.DeserializeObject<PlayerIdModel[]>(jsonContent);
            Assert.True(1 == playerData.Length);
            Assert.Contains(playerData, batter => batter.PlayerId == playerId);

            // Teardown
            client.Dispose();
        }

        [Theory(Skip = "TODO: Resolve HUT-integration testing")]
        [InlineData("Mark%20Buehrle", "buehrma01")]
        [InlineData("Eddie%20Collins", "collied02")]
        [InlineData("Frank%20Thomas", "thomafr04")]
        public async void ReturnsOkForWhiteSoxPlayers(string playerName, string playerId)
        {
            // Arrange
            var client = CreateHttpClient();

            // Act
            var response = client.GetAsync($"/api/playerids/{playerName}").Result;

            // Asserts
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var playerData = JsonConvert.DeserializeObject<PlayerIdModel[]>(jsonContent);
            var batter = playerData.First();
            Assert.NotNull(batter);
            Assert.Equal(playerId, batter.PlayerId);

            // Teardown
            client.Dispose();
        }
    }
}
