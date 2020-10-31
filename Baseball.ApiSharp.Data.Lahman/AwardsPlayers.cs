using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class AwardsPlayers
    {
        public string PlayerId { get; set; }
        public string AwardId { get; set; }
        public short YearId { get; set; }
        public string LgId { get; set; }
        public string Tie { get; set; }
        public string Notes { get; set; }
    }
}
