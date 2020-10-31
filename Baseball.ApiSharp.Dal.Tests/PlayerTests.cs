#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization.SampleData;
using Xunit;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class PlayersTests
    {
        public PlayersTests()
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
        public void QueryForMasterPlayerData()
        {
            var myPlayer = _dbContext.People.Single(m => m.PlayerId == "arrieja01");
            Assert.NotNull(myPlayer);
            Assert.True("R" == myPlayer.Bats);
            Assert.True("R" == myPlayer.Throws);
            Assert.Equal("Jake", myPlayer.NameFirst);
            Assert.Equal("Arrieta", myPlayer.NameLast);
            Assert.True(6 == myPlayer.BirthDay);
            Assert.True(3 == myPlayer.BirthMonth);
            Assert.True(1986 == myPlayer.BirthYear);
            Assert.True("Farmington" == myPlayer.BirthCity);
            Assert.True("MO" == myPlayer.BirthState);
            Assert.True("USA" == myPlayer.BirthCountry);
            Assert.StartsWith("2010-06-10", myPlayer.Debut);
            Assert.StartsWith("2018-09-27", myPlayer.FinalGame);
            Assert.True(76 == myPlayer.Height);
            Assert.True(225 == myPlayer.Weight);
        }
    }

}
