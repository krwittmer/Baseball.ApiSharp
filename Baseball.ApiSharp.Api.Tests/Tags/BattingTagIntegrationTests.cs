#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Baseball.ApiSharp.Models;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace Baseball.ApiSharp.Api.Tests.Tags
{
    [Trait("Category", "BattingTagApi")]
    public class BattingTagIntegrationTests : ApiTestBase, IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        public BattingTagIntegrationTests(CustomWebApplicationFactory<Startup> factory) : base(factory)
        {
        }

        protected override HttpClient CreateHttpClient()
        {
            return _factory.WithWebHostBuilder(builder => { builder.ConfigureTestServices(services => { }); })
                .CreateClient();
        }

        private async Task UpdateBattingModelWithTags(BatterModel batter, string tags, HttpClient client)
        {
            var resourcePath = $"api/batters/{batter.PlayerId}/tags";
            Debug.WriteLine($"Preparing to update tag data for batters using {resourcePath}");
            var model = new TagsModel
            {
                SimpleTagData = tags
            };

            var serializedTag = JsonConvert.SerializeObject(model);
            HttpContent httpContext = new StringContent(serializedTag, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(resourcePath, httpContext);
            var stringResult = await response.Content.ReadAsStringAsync();
            Debug.WriteLine($"Response string after put {stringResult}");
        }

        private async Task<BatterModel[]> GetBattingModels(HttpClient client, string resourcePath)
        {
            var response = await client.GetAsync(resourcePath);

            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Content);
            var jsonContent = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var batting = JsonConvert.DeserializeObject<BatterModel[]>(jsonContent);
            return batting;
        }

        [Fact]
        public async Task SimpleTagApiTest()
        {
            // Arrange
            var client = CreateHttpClient();

            // Act
            const string batterId = "collied02";
            var batting = await GetBattingModels(client, $"api/batters/{batterId}");
            var firstBatter = batting[0];

            const string dummyTagValue = "dummyTag";
            await UpdateBattingModelWithTags(firstBatter, dummyTagValue, client);
            batting = await GetBattingModels(client, $"api/batters/{batterId}");
            firstBatter = batting[0];

            // Assert
            Assert.True(firstBatter.Tags.Length != 0);
            Assert.Contains(firstBatter.Tags, t => t.TagValue == dummyTagValue);

            // Teardown
            client.Dispose();
        }

        [Fact]
        public async Task MultiTagApiTest()
        {
            // Arrange
            var client = CreateHttpClient();

            // Act
            const string batterId = "collied02";
            var batting = await GetBattingModels(client, $"api/batters/{batterId}");
            var firstBatter = batting[0];

            const string dummyTag1 = "dummyTag1";
            const string dummyTag2 = "dummyTag2";
            const string dummyTag3 = "dummyTag3";
            string dummyTagValues = string.Concat(dummyTag1, "|", dummyTag2, "|", dummyTag3);
            await UpdateBattingModelWithTags(firstBatter, dummyTagValues, client);
            batting = await GetBattingModels(client, $"api/batters/{batterId}");
            firstBatter = batting[0];

            // Assert
            Assert.True(firstBatter.Tags.Length == 3);
            Assert.Contains(firstBatter.Tags, t => t.TagValue == dummyTag1);

            // Teardown
            client.Dispose();
        }
    }
}