using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Allstarfull
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public short? YearId { get; set; }
        public short GameNum { get; set; }
        public string GameId { get; set; }
        public string TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public string LgId { get; set; }
        public short? Gp { get; set; }
        public short? StartingPos { get; set; }

        public virtual League Lg { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
    }
}
