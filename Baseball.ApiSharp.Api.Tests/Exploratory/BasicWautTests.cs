﻿using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Baseball.ApiSharp.Api.Tests.Exploratory
{
    public class BasicWautTests : IClassFixture<WebApplicationFactory<Baseball.ApiSharp.Api.Startup>>
    {
        private readonly WebApplicationFactory<Baseball.ApiSharp.Api.Startup> _factory;

        public BasicWautTests(WebApplicationFactory<Baseball.ApiSharp.Api.Startup> factory)
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
