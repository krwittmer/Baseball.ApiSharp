using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Teamshalf
    {
        public int Id { get; set; }
        public short YearId { get; set; }
        public string LgId { get; set; }
        public string TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public string Half { get; set; }
        public string DivId { get; set; }
        public int? DivId1 { get; set; }
        public string DivWin { get; set; }
        public short? TeamRank { get; set; }
        public short? G { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }

        public virtual Division DivId1Navigation { get; set; }
        public virtual League Lg { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
    }
}
