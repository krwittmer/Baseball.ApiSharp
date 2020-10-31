#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Api.Controllers;
using Baseball.ApiSharp.Dal.Repos;
using Microsoft.Extensions.Logging;
using Moq;

namespace Baseball.ApiSharp.Api.Tests.Controllers
{
    public class PlayerIdControllerTests
    {
        private readonly ILogger<PlayerIdsController> _logger;

        public PlayerIdControllerTests()
        {
            _logger = new Logger<PlayerIdsController>(new LoggerFactory());
        }

        public void GetPlayerTest()
        {
            // Arrange & Act
            var mockRepo = new Mock<IRepository>();
            var controller = new PlayerIdsController(mockRepo.Object, _logger);

            // TODO:

        }

    }
}
