#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using Baseball.ApiSharp.Api.Interfaces;
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
    public class PitchersController : PaginationControllerBase, IPitchersController
    {
        private readonly ILogger<PitchersController> _logger;
        private readonly IRepository _repository;

        public PitchersController(IRepository repository, ILogger<PitchersController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("{pitcherId}", Order = 10)]
        public IActionResult GetPitcherById(string pitcherId, [FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 25)
        {
            _logger.LogInformation("Get pitching data for pitching id: " + pitcherId);
            var pitchers = _repository.Filter<Pitching>(p => p.PlayerId == pitcherId, out var total, pageNumber, pageSize);
            _logger.LogDebug("Filtered pitching models (total): " + total);
            AddHeaderPaginationMetaData(total, pageNumber, pageSize);
            IActionResult results = PostProcessResults(pitchers);
            _repository.Dispose();
            return results;
        }

        private IActionResult PostProcessResults(IQueryable<Pitching> pitchers)
        {
            var pitchersResults = Mapper.Map<PitcherModel>(pitchers.AsQueryable());

            var factory = HttpContext?.RequestServices?.GetRequiredService<ILoggerFactory>();
            var helper = new TagRelationshipManager(_repository, factory);
            // TODO: helper.AppendTags(pitchersResults);

            return Ok(pitchersResults);
        }
    }
}