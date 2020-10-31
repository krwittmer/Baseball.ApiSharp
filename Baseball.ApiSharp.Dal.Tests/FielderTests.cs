#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Linq;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization.SampleData;
using Xunit;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class FielderTests
    {
        public FielderTests()
        {
            Setup();
        }

        private LahmansDbContext _dbContext;

        private void Setup()
        {
            var helper = new TestContextHelper();
            _dbContext = new LahmansDbContext(helper.Options);
            WinningTeamSampleData.SeedData(_dbContext);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void QueryNoFielderData()
        {
            Assert.Throws<InvalidOperationException>(
                () => _dbContext.Fielding.Single(fielder => fielder.PlayerId == "dobbami99"));
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void QueryTerrenceLongFielderData()
        {
            var myFielding = _dbContext.Fielding.Single(f => f.PlayerId == "longte01");
            Assert.NotNull(myFielding);
            Assert.True("OF" == myFielding.Pos);
            Assert.True(162 == myFielding.G);
            Assert.True(158 == myFielding.Gs);
            Assert.True(4230 == myFielding.InnOuts);
            Assert.True(382 == myFielding.Po);
            Assert.True(5 == myFielding.A);
            Assert.True(8 == myFielding.E);
            Assert.True(1 == myFielding.Dp);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void QueryTerrenceLongMasterPlayerData()
        {
            var p = _dbContext.People.Single(player => player.PlayerId == "longte01");
            Assert.NotNull(p);
            Assert.True("L" == p.Bats);
            Assert.True("L" == p.Throws);
            Assert.True("Terrence" == p.NameFirst);
            Assert.True("Long" == p.NameLast);
            Assert.True(29 == p.BirthDay);
            Assert.True(2 == p.BirthMonth);
            Assert.True(1976 == p.BirthYear);
            Assert.True("Montgomery" == p.BirthCity);
            Assert.True("AL" == p.BirthState);
            Assert.True("USA" == p.BirthCountry);
            Assert.StartsWith("1999-04-14", p.Debut);
            Assert.StartsWith("2006-06-05", p.FinalGame);
            Assert.True(73 == p.Height);
            Assert.True(190 == p.Weight);
        }
    }
}
