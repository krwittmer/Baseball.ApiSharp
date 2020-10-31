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
    public class PitchersTests
    {
        public PitchersTests()
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
        public void QueryJonLesterMasterPlayerData()
        {
            var p = _dbContext.People.Single(player => player.PlayerId == "lestejo01");
            Assert.NotNull(p);
            Assert.Equal("L", p.Bats);
            Assert.Equal("L", p.Throws);
            Assert.Equal("Jon", p.NameFirst);
            Assert.Equal("Lester", p.NameLast);
            Assert.Equal("lestejo01", p.BbrefId);
            Assert.Equal("Tacoma", p.BirthCity);
            Assert.Equal("WA", p.BirthState);
            Assert.Equal("USA", p.BirthCountry);
            Assert.True(1 == p.BirthMonth);
            Assert.True(7 == p.BirthDay);
            Assert.True(1984 == p.BirthYear);
            Assert.StartsWith("2006-06-10", p.Debut);
            Assert.StartsWith("2018-09-27", p.FinalGame);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void QueryJonLesterPitchingData()
        {
            var pi = _dbContext.Pitching.Single(pitcher => pitcher.PlayerId == "lestejo01");
            Assert.NotNull(pi);
            Assert.Equal("lestejo01", pi.PlayerId);
            Assert.Equal(2015, pi.YearId);
            Assert.Equal(1, pi.Stint);
            Assert.Equal("CHN", pi.TeamId);
            Assert.Equal("NL", pi.LgId);
            Assert.True(11 == pi.W);
            Assert.True(12 == pi.L);
            Assert.True(32 == pi.G);
            Assert.True(32 == pi.Gs);
            Assert.True(1 == pi.Cg);
            Assert.True(pi.Sho == 0);
            Assert.True(pi.Sv == 0);
            Assert.True(pi.Ipouts == 615);
            Assert.True(pi.H == 183);
            Assert.True(pi.Er == 76);
            Assert.True(pi.Hr == 16);
            Assert.True(pi.Bb == 47);
            Assert.True(pi.So == 207);
            Assert.Equal(240, pi.Baopp);
            Assert.Equal(334, pi.Era);
            Assert.True(0 == pi.Ibb);
            Assert.True(8 == pi.Wp);
            Assert.True(7 == pi.Hbp);
            Assert.True(0 == pi.Bk);
            Assert.True(828 == pi.Bfp);
            Assert.True(0 == pi.Gf);
            Assert.True(83 == pi.R);
            Assert.True(5 == pi.Sh);
            Assert.True(4 == pi.Sf);
            Assert.True(13 == pi.Gidp);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void QueryNoPitchingData()
        {
            Assert.Throws<InvalidOperationException>(
                () => _dbContext.Pitching.Single(pitcher => pitcher.PlayerId == "dobbami99"));
        }
    }
}
