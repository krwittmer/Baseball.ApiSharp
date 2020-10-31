#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

#pragma warning disable 1591
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;

/*
  Visit https://stackoverflow.com/questions/41908957/get-all-registered-routes-in-asp-net-core for more details.
 */
namespace Baseball.ApiSharp.Api.Controllers
{
    [Route("monitor")]
    public class MonitorController : Controller
    {
        private readonly ILogger<MonitorController> _logger;
        private readonly IActionDescriptorCollectionProvider _provider;

        // TODO: the provider argument comes as a null (which is a different behavior then experienced in .NET 2.x)
        public MonitorController(IActionDescriptorCollectionProvider provider, ILogger<MonitorController> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        [HttpGet("routes")]
        public IActionResult GetRoutes()
        {
            var routes = _provider?.ActionDescriptors.Items.Select(x => new
            {
                Action = x.RouteValues["Action"],
                Controller = x.RouteValues["Controller"],
                x.AttributeRouteInfo.Name,
                x.AttributeRouteInfo.Template
            }).ToList();
            _logger.LogInformation("Returning the list of (registered) routes.");
            return Ok(routes);
        }
    }
}