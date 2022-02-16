using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Appearance
    {
        public int Id { get; set; }
        public short YearId { get; set; }
        public string TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public string LgId { get; set; }
        public string PlayerId { get; set; }
        public short? GAll { get; set; }
        public short? Gs { get; set; }
        public short? GBatting { get; set; }
        public short? GDefense { get; set; }
        public short? GP { get; set; }
        public short? GC { get; set; }
        public short? G1b { get; set; }
        public short? G2b { get; set; }
        public short? G3b { get; set; }
        public short? GSs { get; set; }
        public short? GLf { get; set; }
        public short? GCf { get; set; }
        public short? GRf { get; set; }
        public short? GOf { get; set; }
        public short? GDh { get; set; }
        public short? GPh { get; set; }
        public short? GPr { get; set; }

        public virtual League Lg { get; set; }
        public virtual Person Player { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
    }
}
