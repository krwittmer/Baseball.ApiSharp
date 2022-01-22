using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Awardssharemanager
    {
        public int Id { get; set; }
        public string AwardId { get; set; }
        public short YearId { get; set; }
        public string LgId { get; set; }
        public string PlayerId { get; set; }
        public short? PointsWon { get; set; }
        public short? PointsMax { get; set; }
        public short? VotesFirst { get; set; }

        public virtual League Lg { get; set; }
        public virtual Person Player { get; set; }
    }
}
