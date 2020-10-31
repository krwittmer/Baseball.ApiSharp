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
    public class PitcherControllersTest
    {
        public PitcherControllersTest()
        {
            _logger = new Logger<PitchersController>(new LoggerFactory());
        }

        private readonly ILogger<PitchersController> _logger;

        [Fact]
        public void GetByValidPitcherIdRuthba01()
        {
            // Arrange & Act
            var mockRepo = new Mock<IRepository>();
            var controller = new PitchersController(mockRepo.Object, _logger);
            var pitchers = new List<Pitching>
            {
                new Pitching
                {
                    PlayerId = "ruthba01",
                    YearId = 1917,
                    Stint = 1,
                    TeamId = "BOS",
                    LgId = "AL",
                    W = 24,
                    L = 13,
                    G = 41,
                    Gs = 38,
                    Cg = 35,
                    Sho = 6,
                    Sv = 2,
                    Ipouts = 979,
                    H = 244,
                    Er = 73,
                    Hr = 2,
                    Bb = 108,
                    So = 128,
                    Baopp = 0.21,
                    Era = 2.01,
                    Wp = 5,
                    Hbp = 11,
                    Bk = 0,
                    Bfp = 1313,
                    Gf = 2,
                    R = 91
                }
            };

            var total = 1;
            mockRepo.Setup(r => r.Filter(It.IsAny<Expression<Func<Pitching, bool>>>(), out total, 0, 25))
                .Returns(pitchers.AsQueryable());

            var actionResult = controller.GetPitcherById("ruthba01");
            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);
            var results = okObjectResult.Value as ICollection<PitcherModel>;
            Assert.NotNull(results);
            var firstResult = results.First();

            // Assert
            Assert.Equal("ruthba01", firstResult.PlayerId);
            Assert.Equal(1917, firstResult.YearId);
            Assert.True(24 == firstResult.Wins);
        }
    }
}
