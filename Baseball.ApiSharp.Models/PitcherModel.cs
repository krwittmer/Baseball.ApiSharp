#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

#pragma warning disable 1591 
using Newtonsoft.Json;

namespace Baseball.ApiSharp.Models {

    [JsonObject(Title="Pitcher")]
    public class PitcherModel : ModelBase {

        // TODO: Name "ForeignKey" name (instead, reference as "Player")

        public int PlayerForeignKey { get; set; }

        public PlayerModel Player { get; set; }

        /// <summary>W</summary>
        public short? Wins { get; set;  }

        /// <summary>L</summary>
        public short? Losses { get; set; }

        /// <summary>G</summary>
        public short? Games { get; set; }

        /// <summary>GS</summary>
        public short? GamesStarted { get; set; }

        /// <summary>CG</summary>
        public short? CompletedGames { get; set; }

        /// <summary>SHO</summary>
        public short? Shutouts { get; set; }

        /// <summary>SV</summary>
        public short? Saves { get; set; }

        /// <summary>IPOuts</summary>
        public double? OutsPitched { get; set; }

        /// <summary>H</summary>
        public short? Hits { get; set;  }

        /// <summary>ER</summary>
        public short? EarnedRuns { get; set; }

        /// <summary>HR</summary>
        public short? Homeruns { get; set; }

        /// <summary>BB</summary>
        public short? Walks { get; set; }

        /// <summary>SO</summary>
        public short? Strikeouts { get; set; }

        /// <summary>BAOpp</summary>
        public double? OpponentsBattingAverage { get; set; }

        /// <summary>ERA</summary>
        public double? EarnedRunAverage { get; set; }

        /// <summary>IBB</summary>
        public short? IntentionalWalks { get; set; }

        /// <summary>WP</summary>
        public short? WildPitches { get; set; }

        /// <summary>HBP</summary>
        public short? BattersHitByPitch { get; set; }

        /// <summary>BFP</summary>
        public short? BattersFacedByPitcher { get; set; }

        /// <summary>BK</summary>
        public short? Balks { get; set; }

        /// <summary>GF</summary>
        public short? GamesFinished { get; set; }

        /// <summary>R</summary>
        public short? RunsAllowed { get; set;  }

        /// <summary>SH</summary>
        public short? SacrificesByOpposingBatters { get; set; }

        /// <summary>SF</summary>
        public short? SacrificesFliesByOpposingBatters { get; set; }

        /// <summary>GIDP</summary>
        public short? GroundedIntoDoublePlaysByOpposingBatter { get; set; }
    }
}
