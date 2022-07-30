#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Data.Lahman;
using Baseball.ApiSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Baseball.ApiSharp.Api.Controllers
{
    [Route("api/playerIds")]
    public class PlayerIdsController : PaginationControllerBase
    {
        private readonly ILogger<PlayerIdsController> _logger;
        private readonly IReadRepository _repository;

        public PlayerIdsController(IReadRepository repository, ILogger<PlayerIdsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("{playerNameSearchPattern}", Order = 1)]
        public IActionResult Get(string playerNameSearchPattern)
        {
            _logger.LogInformation("Searching over player data with search pattern string {0}.", playerNameSearchPattern);
            var matchingResult = QueryPlayerIds(playerNameSearchPattern);
            return Ok(Mapper.Map<PlayerIdModel>(matchingResult));
        }

        [HttpGet("{playerNameSearchPattern}/page/{pageIndex}", Order = 101)]
        public IActionResult GetPagedPlayerIds(string playerNameSearchPattern, int pageIndex)
        {
            _logger.LogInformation("Searching over player data with search pattern string {0}.", playerNameSearchPattern);

            var matchingResults = QueryPlayerIds(playerNameSearchPattern);
            var pagedCollection = new PagedCollection<Person>(matchingResults, pageIndex, 16).List;
            var pagedModelResults = Mapper.MapObjects<PlayerIdModel, Person>(pagedCollection.ToList());

            // TODO: Investigate how to handcraft Uris returned as part of HATEOS.
            // TODO: Also, as part of a HATEOS response, consider relative Swagger Uris.
            return Ok(pagedModelResults);
        }

        private IQueryable<Person> QueryPlayerIds(string nameSearchPattern)
        {
            var people = _repository.All<Person>().ToArray();
            return _repository.Filter<Person>(m => (m.NameFirst + " " + m.NameLast).Contains(nameSearchPattern));
        }
    }
}
