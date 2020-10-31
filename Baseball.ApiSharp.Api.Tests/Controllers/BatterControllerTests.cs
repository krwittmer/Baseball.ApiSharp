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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Baseball.ApiSharp.Api.Tests.Controllers
{
    public class BatterControllerTests
    {
        public BatterControllerTests()
        {
            _logger = new Logger<BattersController>(new LoggerFactory());
        }

        private readonly ILogger<BattersController> _logger;

        [Fact]
        public void GetByValidBatterIdPodsesc01()
        {
            // Arrange & Act
            var mockRepo = new Mock<IRepository>();
            var controller = new BattersController(mockRepo.Object, _logger);
            var batters = new List<Batting>
            {
                new Batting
                {
                    PlayerId = "podsesc01",
                    YearId = 2005,
                    Stint = 1,
                    TeamId = "CHA",
                    LgId = "AL",
                    G = 129,
                    Ab = 507,
                    R = 80,
                    _2b = 28,
                    _3b = 1,
                    H = 147,
                    Hr = 0,
                    Rbi = 25,
                    Sb = 59,
                    Cs = 23,
                    Bb = 47,
                    So = 75,
                    Ibb = 0,
                    Hbp = 3,
                    Sh = 6,
                    Sf = 5,
                    Gidp = 7
                }
            };

            var total = 1;
            mockRepo.Setup(r => r.Filter(It.IsAny<Expression<Func<Batting, bool>>>(), out total, 0, 25))
                .Returns(batters.AsQueryable());

            var actionResult = controller.GetBatterById("podsesc01");
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);
            var results = okObjectResult.Value as ICollection<BatterModel>;
            Assert.NotNull(results);
            var firstResult = results.First();

            // Assert
            Assert.Equal("podsesc01", firstResult.PlayerId);
            Assert.Equal("CHA", firstResult.TeamId);
            Assert.Equal("AL", firstResult.LeagueId);
            Assert.Equal((short)129, firstResult.Games);
            Assert.Equal((short)507, firstResult.AtBats);
            Assert.Equal((short)147, firstResult.Hits);
            Assert.Equal((short)80, firstResult.Runs);
            Assert.Equal((short)28, firstResult.Doubles);
            Assert.Equal((short)1, firstResult.Triples);
            Assert.Equal((short)147, firstResult.Hits);
            Assert.Equal((short)0, firstResult.HomeRuns);
            Assert.Equal((short)25, firstResult.RunsBattleIn);
            Assert.Equal((short)59, firstResult.StolenBases);
            Assert.Equal((short)23, firstResult.CaughtStealing);
            Assert.Equal((short)47, firstResult.BaseOnBalls);
            Assert.Equal(75, firstResult.Strikeouts);
            Assert.Equal((short)0, firstResult.IntentionalWalks);
            Assert.Equal((short)3, firstResult.HitsByPitch);
            Assert.Equal((short)6, firstResult.SacrificeHits);
            Assert.Equal((short)5, firstResult.SacrificieFlies);
            Assert.Equal((short)7, firstResult.GroundedIntoDoublePlayers);

            _logger.Log(LogLevel.Debug, 0, "Logging execution of method GetByValidBatterId Podsesc01", null, null);
        }

        public void DoSomething(HttpContext c, IServiceProvider s)
        {
            var z = c.RequestServices;
            var y = s.GetRequiredService<ILoggerFactory>();

        }
    }
}
