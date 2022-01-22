using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Awardsmanager
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public string AwardId { get; set; }
        public short YearId { get; set; }
        public string LgId { get; set; }
        public string Tie { get; set; }
        public string Notes { get; set; }

        public virtual League Lg { get; set; }
        public virtual Person Player { get; set; }
    }
}
