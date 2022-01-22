using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Managershalf
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public short YearId { get; set; }
        public string TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public string LgId { get; set; }
        public short? Inseason { get; set; }
        public short Half { get; set; }
        public short? G { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }
        public short? TeamRank { get; set; }

        public virtual League Lg { get; set; }
        public virtual Person Player { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
    }
}
