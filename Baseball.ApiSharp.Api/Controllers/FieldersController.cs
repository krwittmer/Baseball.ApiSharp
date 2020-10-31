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
    public class FieldersController : PaginationControllerBase, IFieldersController
    {
        private readonly IRepository _repository;
        private readonly ILogger<FieldersController> _logger;

        public FieldersController(IRepository repository, ILogger<FieldersController> logger)
        {
            this._repository = repository;
            this._logger = logger;
        }

        [HttpGet("{fielderId}", Order = 10)]
        public IActionResult GetFielderById(string fielderId, [FromQuery] int pageNumber = 0,
            [FromQuery] int pageSize = 25)
        {
            _logger.LogInformation("Getting fielder data for specified player id: " + fielderId);
            var fielders =
                _repository.Filter<Fielding>(f => f.PlayerId == fielderId, out int total, pageNumber, pageSize);
            _logger.LogDebug("Filtered fielding models (total): " + total);
            AddHeaderPaginationMetaData(total, pageSize, pageNumber);
            IActionResult results = PostProcessResults(fielders);
            _repository.Dispose();
            return results;
        }

        [HttpGet("{fielderId}/years/{yearId}", Order = 20)]
        public IActionResult GetFielderByIdAndYear(string fielderId, int yearId)
        {
            _logger.LogInformation("Getting fielder data for specified player id: " + fielderId);
            var fielders =
                _repository.Filter<Fielding>(b => b.PlayerId == fielderId && b.YearId == yearId, out var total);
            _logger.LogDebug("Filtered pitching models (total): " + total);
            _logger.LogInformation("Getting fielder data for specified player id: " + fielderId);
            IActionResult results = PostProcessResults(fielders);
            _repository.Dispose();
            return results;
        }

        private IActionResult PostProcessResults(IQueryable<Fielding> fielders)
        {
            var fielderResults = Mapper.Map<FielderModel>(fielders.AsQueryable());

            var factory = HttpContext?.RequestServices?.GetRequiredService<ILoggerFactory>();
            var helper = new TagRelationshipManager(_repository, factory);
            // TODO: helper.AppendTags(fielderResults);

            return Ok(fielderResults);
        }
    }
}