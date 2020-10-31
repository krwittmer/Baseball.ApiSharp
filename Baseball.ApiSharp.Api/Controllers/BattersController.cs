#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Linq;
using System.Threading.Tasks;
using Baseball.ApiSharp.Api.Interfaces;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.ExtendedSchema;
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Data.Lahman;
using Baseball.ApiSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Baseball.ApiSharp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BattersController : PaginationControllerBase, IBattersController
    {
        private readonly ILogger<BattersController> _logger;
        private readonly IRepository _repository;

        public BattersController(IRepository repository, ILogger<BattersController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("{batterId}", Order = 10)]
        public IActionResult GetBatterById(string batterId, [FromQuery] int pageNumber = 0,
            [FromQuery] int pageSize = 25)
        {
            _logger.LogInformation("Getting batter data for specified player id: " + batterId);
            var batters =
                _repository.Filter<Batting>(b => b.PlayerId == batterId, out var total, pageNumber, pageSize);
            _logger.LogDebug("Filtered batting models (total): " + total);
            _logger.LogInformation("Getting batting data for specified player id: " + batterId);
            AddHeaderPaginationMetaData(total, pageSize, pageNumber);
            IActionResult results = PostProcessResults(batters);
            _repository.Dispose();
            return results;
        }

        [HttpGet("{batterId}/years/{yearId}", Order = 20)]
        public IActionResult GetBatterByIdAndYear(string batterId, int yearId)
        {
            _logger.LogInformation("Getting batter data for specified player id: " + batterId);
            var batters = _repository.Filter<Batting>(b => b.PlayerId == batterId && b.YearId == yearId, out var total);
            _logger.LogDebug("Filtered batting models (total): " + total);
            _logger.LogInformation("Getting batting data for specified player id: " + batterId);
            IActionResult results = PostProcessResults(batters);
            _repository.Dispose();
            return results;
        }

        [HttpGet("teams/{teamId}/years/{yearId}", Order = 100)]
        public IActionResult GetBattersByTeamAndYear(string teamId, int yearId)
        {
            _logger.LogInformation("Retrieved batters for team id {0} and year id {1}", teamId, yearId);
            var batters = _repository.Filter<Batting>(b => b.TeamId == teamId && b.YearId == yearId);
            IActionResult results = PostProcessResults(batters);
            _repository.Dispose();
            return results;
        }

        // Go like this: /api/batters/batterId/tags/
        // Or, have it be like this: /api/batters/batterId/tags/tagId
        // TODO: TagModel should only be concerned with tagging.
        // TODO: apply the spirit of SRP for tags

        [HttpGet("tags/{tagValue}", Order = 200)]
        public IActionResult GetBattersByTag(string tagValue)
        {
            var context = _repository.GetContext() as LahmansDbContext;
            if (context == null) throw new ApplicationException("Null database context");

            var factory = HttpContext?.RequestServices?.GetRequiredService<ILoggerFactory>();
            var manager = new TagRelationshipManager(_repository, factory);
            var batters = manager.GetBattersByTag(tagValue);
            return Ok(batters);
        }

        [HttpPut("{batterId}/tags", Order = 200)]
        public async Task<IActionResult> UpdateBatterTags(string batterId, [FromBody] TagsModel model)
        {
            _logger.LogInformation($"Entered API to update batting data tag for {batterId}");

            var factory = HttpContext?.RequestServices?.GetRequiredService<ILoggerFactory>();
            var manager = new TagRelationshipManager(_repository, factory);
            var tags = TagTransformer.Transform(model);
            var updateResults = await manager.UpdateTags(batterId, tags);
            return Ok(updateResults);
        }

        private IActionResult PostProcessResults(IQueryable<Batting> batters)
        {
            var batterResults = Mapper.Map<BatterModel>(batters.AsQueryable());

            var factory = HttpContext?.RequestServices?.GetRequiredService<ILoggerFactory>();
            var helper = new TagRelationshipManager(_repository, factory);
            helper.AppendTags(batterResults);

            return Ok(batterResults);
        }
    }
}