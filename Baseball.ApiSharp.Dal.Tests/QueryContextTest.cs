#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using Xunit;

namespace Baseball.ApiSharp.Dal.Tests
{
    /**
     * The following unit tests require MySQL to be running in the background with
     * the Lahman DB schema initialized. If MySQL is not running as a service, use
     * this command to launch the database server:
     *
     *  mysqld --standalone --console
     *
     * And you can use this command to skip over the integration-based unit tests below.
     *
     * dotnet test --filter Category!=QueryDbIntegrations
     *
     */
    [Trait("Category", "QueryDbIntegrations")]
    public class QueryContextTest
    {
        [Fact]
        public void QueryFirstPeople()
        {
            var builder = new DbContextBuilder();
            var context = builder.Build();
            var firstPlayer = context.People.First();
            Assert.NotNull(firstPlayer);
        }

        [Fact]
        public void QueryFirstBatter()
        {
            var builder = new DbContextBuilder();
            var context = builder.Build();
            var firstBatter = context.Batting.First();
            Assert.NotNull(firstBatter);
        }

        [Fact]
        public void QueryFirstPitcher()
        {
            var builder = new DbContextBuilder();
            var context = builder.Build();
            var firstPitcher = context.Pitching.First();
            Assert.NotNull(firstPitcher);
        }

        [Fact]
        public void QueryFirstFielder()
        {
            var builder = new DbContextBuilder();
            var context = builder.Build();
            var firstFielder = context.Fielding.First();
            Assert.NotNull(firstFielder);
        }
    }
}
