#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Data.Lahman;
using Xunit;

namespace Baseball.ApiSharp.Models.Tests
{
    public class BatterModelMapTests
    {
        [Fact]
        public void MapAnthonyRizoMasterPlayerDataTest()
        {
            var schwarberMasterData = new People
            {
                PlayerId = "schwaky01",
                Bats = "L",
                Throws = "R",
                NameFirst = "Kyle",
                NameLast = "Schwarber",
                BbrefId = "schwaky01",
                BirthCity = "Middletown",
                BirthDay = 5,
                BirthCountry = "USA",
                BirthState = "OH",
                BirthMonth = 3,
                BirthYear = 1993,
                Debut = "2015-06-16",
                FinalGame = "2016-04-07",
                RetroId = "schwk001"
            };

            var schwarberBatterData = new Batting
            {
                PlayerId = "schwaky01",
                YearId = 2015,
                Stint = 1,
                TeamId = "CHN",
                LgId = "NL",
                G = 69,
                Ab = 232,
                R = 57,
                _2b = 6,
                _3b = 1,
                H = 52,
                Hr = 16,
                Rbi = 43,
                Sb = 3,
                Cs = 3,
                Bb = 36,
                So = 77,
                Ibb = 1,
                Hbp = 4,
                Sh = 0,
                Sf = 1,
                Gidp = 4
            };

            var battingModel = Mapper.MapObject<BatterModel>(schwarberBatterData);
            Assert.Equal("schwaky01", battingModel.PlayerId);
            Assert.True(69 == battingModel.Games);
            Assert.True(232 == battingModel.AtBats);
            Assert.True(57 == battingModel.Runs);
            Assert.True(1 == battingModel.Triples);
            Assert.True(6 == battingModel.Doubles);
            Assert.True(16 == battingModel.HomeRuns);
            Assert.True(43 == battingModel.RunsBattleIn);
            Assert.True(3 == battingModel.StolenBases);
            Assert.True(36 == battingModel.BaseOnBalls);
            Assert.True(3 == battingModel.CaughtStealing);
            Assert.True(52 == battingModel.Hits);
            Assert.True(4 == battingModel.GroundedIntoDoublePlayers);
            Assert.True(4 == battingModel.HitsByPitch);
            Assert.True(1 == battingModel.IntentionalWalks);
            Assert.True(0 == battingModel.SacrificeHits);
            Assert.True(1 == battingModel.SacrificieFlies);
        }
    }
}
