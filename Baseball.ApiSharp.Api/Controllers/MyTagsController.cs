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
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;
using Baseball.ApiSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Baseball.ApiSharp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTagsController : ControllerBase
    {
        private readonly ILogger<MyTagsController> _logger;
        private readonly IRepository _repository;

        public MyTagsController(IRepository repository, ILogger<MyTagsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET: api/SimpleTagData
        [HttpGet]
        public IActionResult Get([FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 25)
        {
            int total;
            var tags = _repository.Filter<Tag>(t => !string.IsNullOrEmpty(t.TagValue), out total, pageNumber, pageSize);
            return Ok(Mapper.Map<TagModel>(tags));
        }

        /// <summary>
        /// Enter tag id to try out this API!
        /// </summary>
        /// <remarks>Query database by tag id and return the associated historial pitching data.</remarks>>
        [HttpGet("{tagId}", Order = 10)]
        public IActionResult GetTagById(string tagId, [FromQuery] int pageNumber = 0,
            [FromQuery] int pageSize = 25)
        {
            _logger.LogInformation("Getting Tag data for specified player id: " + tagId);
            var tagPlayer =
                _repository.Filter<Tag>(t => t.TagId == tagId, out int total, pageNumber, pageSize);
            _logger.LogDebug("Filtered Tag models (total): " + total);
            return Ok(Mapper.Map<TagModel>(tagPlayer.AsQueryable()));
        }

        [HttpGet("/all/{tagId}", Order = 50)]
        public IActionResult GetAllByMatchingTag(string tagId)
        {
            var batterController = HttpContext.RequestServices.GetRequiredService<IBattersController>();
            var batters = batterController.GetBattersByTag(tagId);

            // Implement for batters, fielders, pitchers and teams.
            var pitcherController = HttpContext.RequestServices.GetRequiredService<IPitchersController>();
            // TODO: var pitchers = pitcherController.GetPitchersByTag(tagId);

            var fielderController = HttpContext.RequestServices.GetRequiredService<IFieldersController>();
            // TODO: var fielders = fielderController.GetFieldersByTag(tagId);

            return Ok(new { Batters = batters, /* Pitchers = pitchers, Fielders = fielders */ });
        }

        // POST: api/SimpleTagData
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TagModel model)
        {
            if (model == null)
                return new BadRequestObjectResult(ModelState);

            if (!ModelState.IsValid)
                return new BadRequestObjectResult(ModelState);

            try
            {
                var tagData = Mapper.MapObject<Tag>(model);
                await _repository.Create(tagData);
            }
            catch (Exception e)
            {
                _logger.LogError(1, e, "Failed to create tag in DB repository");
                throw;
            }

            return CreatedAtRoute(new { id = model.TagId }, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
