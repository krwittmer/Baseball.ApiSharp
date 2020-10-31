using System.Net;
using System.Threading.Tasks;
using Baseball.ApiSharp.Models;
using Newtonsoft.Json;
using RestSharp;
using Xunit;

namespace Baseball.ApiSharp.Api.Tests.Tags
{
    public class BattingTagRestSharpIntegrationTests : RestSharpClientTest
    {
        [Fact]
        public async void EmptyAddTagTest()
        {
            var client = GetClient();

            var batterId = "collied02";
            var batting = await GetBattingModels(client, $"api/batters/{batterId}");
            var firstBatter = batting[0];

            await UpdateBattingModelWithTags(firstBatter, new TagModel[0], client);

            batting = await GetBattingModels(client, $"api/batters/{batterId}");
            firstBatter = batting[0];
            Assert.True(firstBatter.Tags.Length == 0);
        }

        private async Task<string> UpdateBattingModelWithTags(BatterModel batting1, TagModel[] tags, RestClient client)
        {
            batting1.Tags = tags; 
            var putRequest = new RestRequest
            {
                Resource = $"api/batters/{batting1.PlayerId}/tags",
                Method = Method.PUT
            };
            putRequest.AddHeader("Accept", "application/json");
            putRequest.AddJsonBody(batting1);
            var putResponse = await client.ExecuteTaskAsync(putRequest);
            var updatedContent = putResponse.Content;
            return updatedContent;
        }

        private async Task<BatterModel[]> GetBattingModels(RestClient client, string resourcePath)
        {
            var request = new RestRequest
            {
                Resource = resourcePath,
                Method = Method.GET
            };
            request.AddHeader("Accept", "application/json");
            var response = await client.ExecuteTaskAsync(request);

            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Content);
            var jsonContent = response.Content;
            Assert.False(string.IsNullOrWhiteSpace(jsonContent));
            var batting = JsonConvert.DeserializeObject<BatterModel[]>(jsonContent);
            return batting;
        }
    }
}
