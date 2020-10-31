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
    [Trait("Category", "FieldingApi")]

    public class FieldingApiTests : ApiTestBase, IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public FieldingApiTests(CustomWebApplicationFactory<Startup> factory) : base(factory) { }

        [Fact]
        public async Task GetFielderApiResult()
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            const string fielderId = "ruthba01";
            var response = await client.GetAsync($"/api/fielders/{fielderId}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var fielder = JsonConvert.DeserializeObject<FielderModel[]>(jsonContent).First();
            Assert.NotNull(fielder);
            Assert.Equal($"{fielderId}", fielder.PlayerId);

            // Teardown
            client.Dispose();
        }

        [Theory]
        [InlineData("thomafr04")]
        public async Task ReturnsOkForValidFielderIdWithPagination(string fielderId)
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            int pageSize = 5;
            var response = await client.GetAsync($"/api/fielders/{fielderId}?pageNumber=1&pageSize={pageSize}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var fieldingData = JsonConvert.DeserializeObject<BatterModel[]>(jsonContent);
            Assert.True(pageSize == fieldingData.Length);
            Assert.Contains(fieldingData, fielder => fielder.PlayerId == fielderId);

            // Teardown
            client.Dispose();
        }

        [Theory]
        [InlineData("thomafr04", 1999, 49)]
        [InlineData("thomafr04", 2000, 30)]
        public async Task ReturnsOkForValidFielderIdAndYear(string fielderId, int year, short expectedGames)
        {
            // Arrange
            var client = CreateHttpClient();

            //Act
            var response = await client.GetAsync($"/api/fielders/{fielderId}/years/{year}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var fieldingData = JsonConvert.DeserializeObject<BatterModel[]>(jsonContent);
            Assert.Contains(fieldingData, fielder => fielder.PlayerId == fielderId);

            var fielderData = fieldingData.First();
            var actualGames = fielderData.Games;
            Assert.Equal(expectedGames, actualGames);

            // Teardown
            client.Dispose();
        }
    }
}
