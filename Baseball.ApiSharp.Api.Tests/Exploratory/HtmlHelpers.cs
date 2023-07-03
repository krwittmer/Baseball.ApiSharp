using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace Baseball.ApiSharp.Api.Tests.Exploratory
{
    public class HtmlHelpers
    {
        public static async Task<string> GetResponseAsync(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
