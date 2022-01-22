#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using Baseball.ApiSharp.Data.Lahman;
using Omu.ValueInjecter;
using Serilog;

namespace Baseball.ApiSharp.Models
{
    public class Mapper
    {
        public static readonly MapperInstance MapperObject;

        static Mapper()
        {
            MapperObject = new MapperInstance();
            MasterToPlayerModel();
            MasterToPlayerIdModel();            
            BattingToBattingModel();
            FieldingToFieldingModel();
            PitcherToPitchingModel();
            TeamsToTeamModeling();
        }

        public static T MapObject<T>(object source)
        {
            Log.Debug("Starting to copy/map object: " + source);

            if (source == null)
                return default;
            var mappedObjected = MapperObject.Map<T>(source);

            Log.Debug("Mapped objected is: " + source);
            return mappedObjected;
        }

        public static ICollection<T> Map<T>(IQueryable<object> sourceObjects)
        {
            Log.Debug("Starting to copy/map a collection of {0} objects.", sourceObjects.Count());
            return MapObjects<T,object>(sourceObjects.ToList());
        }

        public static ICollection<T> MapObjects<T,S>(IList<S> sourceObjects)
        {
            if (sourceObjects == null)
                return null;
            ICollection<T> copiedObjects = new List<T>();
            var enumerator = sourceObjects.GetEnumerator();
            while (enumerator.MoveNext())
                copiedObjects.Add(MapperObject.Map<T>(enumerator.Current));
            enumerator.Dispose();
            return copiedObjects;
        }

        private static void MasterToPlayerModel()
        {
            MapperObject.AddMap<Person, PlayerModel>(src =>
            {
                var res = new PlayerModel
                {
                    PlayerId = src.PlayerId,
                    FirstName = src.NameFirst,
                    LastName = src.NameLast,
                    GivenName = src.NameGiven,
                    Height = src.Height,
                    Weight = src.Weight,
                    Bats = src.Bats != null && src.Bats.Length == 1 ? src.Bats[0] : ' ',
                    Throws = src.Bats != null && src.Bats.Length == 1 ? src.Bats[0] : ' ',
                    DebutGameDate = DateTime.Parse(src.Debut),
                    LastGameDate = DateTime.Parse(src.FinalGame)
                };

                if (src.BirthYear.HasValue && src.BirthMonth.HasValue && src.BirthDay.HasValue)
                {
                    var playerTimeStamp = new DateTime(src.BirthYear.Value, src.BirthMonth.Value, src.BirthDay.Value);
                    res.BirthDate = playerTimeStamp;
                }

                return res;
            });
        }

        private static void MasterToPlayerIdModel()
        {
            MapperObject.AddMap<Person, PlayerIdModel>(src =>
            {
                var res = new PlayerIdModel
                {
                    PlayerId = src.PlayerId,
                    FirstName = src.NameFirst,
                    LastName = src.NameLast,
                    GivenName = src.NameGiven
                };

                return res;
            });
        }

        private static void BattingToBattingModel()
        {
            MapperObject.AddMap<Batting, BatterModel>(src =>
            {
                var res = new BatterModel
                {
                    PlayerId = src.PlayerId,
                    TeamId = src.TeamId,
                    LeagueId = src.LgId,
                    AtBats = src.Ab ?? 0,
                    BaseOnBalls = src.Bb ?? 0,
                    CaughtStealing = src.Cs ?? 0,
                    StolenBases = src.Sb ?? 0,
                    Strikeouts = src.So ?? 0,
                    Doubles = src._2b ?? 0,
                    Triples = src._3b ?? 0,
                    Runs = src.R ?? 0,
                    Games = src.G ?? 0,
                    Hits = src.H ?? 0,
                    HitsByPitch = src.Hbp ?? 0,
                    GroundedIntoDoublePlayers = src.Gidp ?? 0,
                    RunsBattleIn = src.Rbi ?? 0,
                    SacrificeHits = src.Sh ?? 0,
                    SacrificieFlies = src.Sf ?? 0,
                    IntentionalWalks = src.Ibb ?? 0,
                    HomeRuns = src.Hr ?? 0
                };

                return res;
            });
        }

        private static void FieldingToFieldingModel()
        {
            MapperObject.AddMap<Fielding, FielderModel>(src =>
            {
                var res = new FielderModel
                {
                    PlayerId = src.PlayerId,
                    TeamId = src.TeamId,
                    LeagueId = src.LgId,
                    Assists = src.A,
                    DoublePlays = src.Dp,
                    Errors = src.E,
                    Games = src.G,
                    GamesStarted = src.Gs,
                    InnOuts = src.InnOuts,
                    OpponentsCaughtStealing = src.Cs,
                    OpponentStolenBases = src.Sb,
                    PassedBalls = src.Pb,
                    Position = src.Pos,
                    Putouts = src.Po,
                    WildPitches = src.Wp,
                    ZoneRating = src.Zr
                };

                return res;
            });
        }

        private static void TeamsToTeamModeling()
        {
            MapperObject.AddMap<Team, TeamModel>(src =>
                {
                    var res = new TeamModel
                    {
                        LgId = src.LgId,
                        YearId = src.YearId,
                        TeamId = src.TeamId,
                        FranchiseId = src.FranchId,
                        AtBats = src.Ab,
                        CaughtStealing = src.Cs,
                        WorldSeriesWinners = src.Wswin,
                        Wins = src.W,
                        Losses = src.L,
                        DivisionWinners = src.DivWin,
                        LeagueChampions = src.LgWin,
                        HitsByBatters = src.Hbp,
                        BattersHitByPitch = src.Hbp,
                        Doubles = src._2b,
                        Triples = src._3b,
                        WalksByBatters = src.Bb,
                        StrikeoutsByBatters = src.So,
                        SacrificeFlies = src.Sf,
                        OpponentsRunsScored = src.Ra,
                        EarnedRunsAllowed = src.Er,
                        EarnedRunAverage = src.Era,
                        CompleteGames = src.Cg,
                        Shutouts = src.Sho,
                        Saves = src.Sv,
                        OutsPitches = src.Ipouts,
                        HitsAllowed = src.Ha,
                        HomeRunsAllowed = src.Hra,
                        WalksAllowed = src.Bba,
                        StrikeoutsByPitchers = src.Soa,
                        Errors = src.E,
                        DoublePlays = src.Dp,
                        FieldingPercentage = src.Fp,
                    };

                    return res;
                }
            );
        }

        private static void PitcherToPitchingModel()
        {
            MapperObject.AddMap<Pitching, PitcherModel>(src =>
            {
                var res = new PitcherModel
                {
                    PlayerId = src.PlayerId,
                    TeamId = src.TeamId,
                    LeagueId = src.LgId,
                    YearId = src.YearId,
                    Balks = src.Bk,
                    BattersFacedByPitcher = src.Bfp,
                    BattersHitByPitch = src.Hbp,
                    CompletedGames = src.Cg,
                    EarnedRunAverage = src.Era,
                    EarnedRuns = src.Er,
                    Games = src.G,
                    GamesStarted = src.Gs,
                    GamesFinished = src.Gf,
                    GroundedIntoDoublePlaysByOpposingBatter = src.Gidp,
                    Hits = src.H,
                    Homeruns = src.Hr,
                    Losses = src.L,
                    OpponentsBattingAverage = src.Baopp,
                    OutsPitched = src.Ipouts,
                    RunsAllowed = src.R,
                    Saves = src.Sv,
                    SacrificesByOpposingBatters = src.Sh,
                    SacrificesFliesByOpposingBatters = src.Sf,
                    Shutouts = src.Sho,
                    Strikeouts = src.So,
                    Walks = src.W,
                    WildPitches = src.Wp,
                    Wins = src.W
                };

                return res;
            });
        }
    }
}