#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Initialization.SampleData;
using Baseball.ApiSharp.Dal.Tests;
using Xunit;

namespace Baseball.ApiSharp.Models.Tests
{
    public class AllTimeBattersModelMapperTests
    {
        public AllTimeBattersModelMapperTests()
        {
            Setup();
        }

        private LahmansDbContext _dbContext;

        private void Setup()
        {
            var helper = new TestContextHelper();
            _dbContext = new LahmansDbContext(helper.Options);
            AllTimeBestPlayerData.SeedData(_dbContext);
        }

        [Fact]
        public void MapWillieMaysMasterPlayerDataTest()
        {
            var maysBatterData = (from mays in _dbContext.Batting where mays.PlayerId == "mayswi01" select mays)
                .First();
            var maysBatterModelData = Mapper.MapObject<BatterModel>(maysBatterData);
            Assert.NotNull(maysBatterModelData);
        }
    }
}
