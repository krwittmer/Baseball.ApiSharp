#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Dal.EfStructures;

namespace Baseball.ApiSharp.Dal.Initialization.SampleData
{
    public static class WinningTeamSampleData
    {
        public static void SeedData(LahmansDbContext dbContext)
        {
            TeamDataChicagoCubs2015.SeedData(dbContext);
            TeamDataChicagoWhiteSox2005.SeedData(dbContext);
            TeamDataOakland2002.SeedData(dbContext);
            TeamDataSeattleMariners2001.SeedData(dbContext);
            TeamDataDetroitTigers1984.SeedData(dbContext);
        }
    }
}
