#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

namespace Baseball.ApiSharp.Models {

    public class BatterModel : ModelBase
    {
        public int PlayerForeignKey { get; set; }

        public PlayerModel Player { get; set; }

        /// <summary>G</summary>
        public short Games { get; set; } 

        /// <summary>AB</summary>
        public short AtBats { get; set; }

        /// <summary>R</summary>
        public short Runs { get; set; }

        /// <summary>H</summary>
        public short Hits { get; set; }

        /// <summary>2B</summary>
        public short Doubles { get; set; }

        /// <summary>3B</summary>
        public short Triples { get; set; }

        /// <summary>HR</summary>
        public short HomeRuns { get; set; }

        /// <summary>RBI</summary>
        public short RunsBattleIn { get; set; }

        /// <summary>SB</summary>
        public short StolenBases { get; set; }

        /// <summary>CS</summary>
        public short CaughtStealing { get; set; }

        /// <summary>BB</summary>
        public short BaseOnBalls { get; set; }

        /// <summary>SO</summary>
        public int Strikeouts { get; set; }

        /// <summary>IBB</summary>
        public short IntentionalWalks { get; set; }

        /// <summary>HBP</summary>
        public short HitsByPitch { get; set; }

        /// <summary>SH</summary>
        public short SacrificeHits { get; set; }

        /// <summary>SF</summary>
        public short SacrificieFlies { get; set; } 

        /// <summary>GIDP</summary>
        public short GroundedIntoDoublePlayers { get; set; }
    }
}
