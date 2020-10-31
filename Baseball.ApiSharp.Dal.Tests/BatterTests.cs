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
    public class BatterTests
    {
        public BatterTests()
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
        public void QueryKirkGibsonBatterData()
        {
            var b = _dbContext.Batting.Single(batter => batter.PlayerId == "gibsoki01");
            Assert.NotNull(b);
            Assert.Equal(1984, b.YearId);
            Assert.Equal(1, b.Stint);
            Assert.Equal("DET", b.TeamId);
            Assert.Equal("AL", b.LgId);
            Assert.True(531 == b.Ab);
            Assert.Equal((short)92, b.R);
            Assert.Equal((short)150, b.H);
            Assert.Equal((short)23, b._2b);
            Assert.Equal((short)10, b._3b);
            Assert.Equal((short)27, b.Hr);
            Assert.Equal((short)91, b.Rbi);
            Assert.Equal((short)29, b.Sb);
            Assert.Equal((short)9, b.Cs);
            Assert.Equal((short)63, b.Bb);
            Assert.Equal((short)103, b.So);
            Assert.Equal((short)6, b.Ibb);
            Assert.Equal((short)8, b.Hbp);
            Assert.Equal((short)3, b.Sh);
            Assert.Equal((short)6, b.Sf);
            Assert.Equal((short)4, b.Gidp);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void QueryKirkGibsonMasterPlayerData()
        {
            var p = _dbContext.People.Single(player => player.PlayerId == "gibsoki01");
            Assert.NotNull(p);
            Assert.Equal("L", p.Bats);
            Assert.Equal("L", p.Throws);
            Assert.Equal("Kirk", p.NameFirst);
            Assert.Equal("Gibson", p.NameLast);
            Assert.Equal("gibsoki01", p.BbrefId);
            Assert.Equal("Pontiac", p.BirthCity);
            Assert.Equal("MI", p.BirthState);
            Assert.Equal("USA", p.BirthCountry);
            Assert.True(5 == p.BirthMonth);
            Assert.True(28 == p.BirthDay);
            Assert.True(1957 == p.BirthYear);
            Assert.StartsWith("1979-09-08", p.Debut);
            Assert.StartsWith("1995-08-10", p.FinalGame);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void QueryNoBatterData()
        {
            Assert.Throws<InvalidOperationException>(
                () => _dbContext.Batting.Single(batter => batter.PlayerId == "dobbami99"));
        }

    }
}
