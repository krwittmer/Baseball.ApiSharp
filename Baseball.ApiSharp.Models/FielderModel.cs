#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

namespace Baseball.ApiSharp.Models
{

    public class FielderModel : ModelBase
    {
        public int PlayerForeignKey { get; set; }

        public PlayerModel Player { get; set; }

        /// <summary>Pos</summary>
        public string Position { get; set; }

        /// <summary>G</summary>
        public short? Games { get; set; }

        /// <summary>GS</summary>
        public short? GamesStarted { get; set; }

        /// <summary>InnOuts: Time played in the field expressed as outs</summary>
        public short? InnOuts { get; set; }

        /// <summary>PO</summary>
        public short? Putouts { get; set; }

        /// <summary>A</summary>
        public short? Assists { get; set; }

        /// <summary>E</summary>
        public short? Errors { get; set; }

        /// <summary>DP</summary>
        public short? DoublePlays { get; set; }

        /// <summary>PB</summary>
        public short? PassedBalls { get; set; }

        /// <summary>WP</summary>
        public short? WildPitches { get; set; }

        /// <summary>SB</summary>
        public short? OpponentStolenBases { get; set; }

        /// <summary>CS</summary>
        public short? OpponentsCaughtStealing { get; set; }

        /// <summary>ZR</summary>
        public double? ZoneRating { get; set; }
    }
}
