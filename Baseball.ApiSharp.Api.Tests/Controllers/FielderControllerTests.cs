#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Baseball.ApiSharp.Api.Controllers;
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Data.Lahman;
using Baseball.ApiSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Baseball.ApiSharp.Api.Tests.Controllers
{
    public class FielderControllerTests
    {
        public FielderControllerTests()
        {
            _logger = new Logger<FieldersController>(new LoggerFactory());
        }

        private readonly ILogger<FieldersController> _logger;

        [Fact]
        public void GetByValidFielderIdMayswi01()
        {
            // Arrange & Act
            var mockRepo = new Mock<IRepository>();
            var controller = new FieldersController(mockRepo.Object, _logger);
            var fielders = new List<Fielding>
            {
                new Fielding
                {
                    PlayerId = "mayswi01",
                    YearId = 1970,
                    Stint = 1,
                    TeamId = "SFN",
                    LgId = "NL",
                    Pos = "OF",
                    G = 129,
                    Gs = 117,
                    InnOuts = 3120,
                    Po = 269,
                    A = 6,
                    E = 7,
                    Dp = 3
                }
            };

            var total = 1;
            mockRepo.Setup(r => r.Filter(It.IsAny<Expression<Func<Fielding, bool>>>(), out total, 0, 25))
                .Returns(fielders.AsQueryable());

            var actionResult = controller.GetFielderById("mayswi01");
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);
            var results = okObjectResult.Value as ICollection<FielderModel>;
            Assert.NotNull(results);
            var firstResult = results.First();

            // Assert
            Assert.Equal("mayswi01", firstResult.PlayerId);
            Assert.Equal("SFN", firstResult.TeamId);
            Assert.Equal("NL", firstResult.LeagueId);
            Assert.Equal("OF", firstResult.Position);
            Assert.NotNull(firstResult.Games);
            Assert.Equal((short) 129, firstResult.Games);
            Assert.Equal((short) 117, firstResult.GamesStarted);
            Assert.Equal((short) 3120, firstResult.InnOuts);
            Assert.Equal((short) 269, firstResult.Putouts);
            Assert.Equal((short) 6, firstResult.Assists);
            Assert.Equal((short) 7, firstResult.Errors);
            Assert.Equal((short) 3, firstResult.DoublePlays);

            _logger.Log(LogLevel.Debug, 0, "Logging execution of method GetByValidFielderIdMayswi01", null, null);
        }
    }
}