#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;

namespace Baseball.ApiSharp.Models
{
    public class TeamModel
    {
        /// <summary>yearID</summary>
        public short? YearId { get; set; }

        /// <summary>lgID</summary>
        public string LgId { get; set; }

        /// <summary>teamID</summary>
        public string TeamId { get; set; }

        /// <summary>franchID</summary>
        public string FranchiseId { get; set; }

        /// <summary>divID</summary>
        public string DivisionId { get; set; }

        public short? Stint { get; set; }

        /// <summary>Rank</summary>
        public short? Rank { get; set; }

        /// <summary>G</summary>
        public short? GamesPlayed { get; set; }

        /// <summary>Ghome</summary>
        public short? GamesPlayedAtHome { get; set; }

        /// <summary>W</summary>
        public short? Wins { get; set; }

        /// <summary>L</summary>
        public short? Losses { get; set; }

        /// <summary>WCWin</summary>
        public string WildCardWinners { get; set; }

        /// <summary>DivWin</summary>
        public string DivisionWinners { get; set; }

        /// <summary>LgWin</summary>
        public string LeagueChampions { get; set; }

        /// <summary>WsWin</summary>
        public string WorldSeriesWinners { get; set; }

        /// <summary>R</summary>
        public short? RunsScored { get; set; }

        /// <summary>AB</summary>
        public short? AtBats { get; set; }

        /// <summary>H</summary>
        public short? HitsByBatters { get; set; }

        /// <summary>2B</summary>
        public short? Doubles { get; set; }

        /// <summary>3B</summary>
        public short? Triples { get; set; }

        /// <summary>HR</summary>
        public short? HomeRunsByBatters { get; set; }

        /// <summary>BB</summary>
        public short? WalksByBatters { get; set; }

        /// <summary>SO</summary>
        public short? StrikeoutsByBatters { get; set; }

        /// <summary>SB</summary>
        public short? StolenBases { get; set; }

        /// <summary>CS</summary>
        public short? CaughtStealing { get; set; }

        /// <summary>HBP</summary>
        public short? BattersHitByPitch { get; set; }

        /// <summary>SF</summary>
        public short? SacrificeFlies { get; set; }

        /// <summary>RA</summary>
        public short? OpponentsRunsScored { get; set; }

        /// <summary>ER</summary>
        public short? EarnedRunsAllowed { get; set; }

        /// <summary>ERA</summary>
        public double? EarnedRunAverage { get; set; }

        /// <summary>CG</summary>
        public short? CompleteGames { get; set; }

        /// <summary>SHO</summary>
        public short? Shutouts { get; set; }

        /// <summary>SV</summary>
        public short? Saves { get; set; }

        /// <summary>IPOuts</summary>
        public int? OutsPitches { get; set; }

        /// <summary>HA</summary>
        public short? HitsAllowed { get; set; }

        /// <summary>HRA</summary>
        public short? HomeRunsAllowed { get; set; }

        /// <summary>BBA</summary>
        public short? WalksAllowed { get; set; }

        /// <summary>SOA</summary>
        public short? StrikeoutsByPitchers { get; set; }

        /// <summary>E</summary>
        public int? Errors { get; set; }

        /// <summary>DP</summary>
        public int? DoublePlays { get; set; }

        /// <summary>FP</summary>
        public double? FieldingPercentage { get; set; }

        /// <summary>name</summary>
        public string TeamFullName { get; set; }

        /// <summary>park</summary>
        public string TeamsHomeBallpark { get; set; }

        public ICollection<PlayerModel> Players { get; set; }
    }
}