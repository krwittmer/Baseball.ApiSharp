﻿using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Pitchingpost
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public short YearId { get; set; }
        public string Round { get; set; }
        public string TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public string LgId { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }
        public short? G { get; set; }
        public short? Gs { get; set; }
        public short? Cg { get; set; }
        public short? Sho { get; set; }
        public short? Sv { get; set; }
        public int? Ipouts { get; set; }
        public short? H { get; set; }
        public short? Er { get; set; }
        public short? Hr { get; set; }
        public short? Bb { get; set; }
        public short? So { get; set; }
        public double? Baopp { get; set; }
        public double? Era { get; set; }
        public short? Ibb { get; set; }
        public short? Wp { get; set; }
        public short? Hbp { get; set; }
        public short? Bk { get; set; }
        public short? Bfp { get; set; }
        public short? Gf { get; set; }
        public short? R { get; set; }
        public short? Sh { get; set; }
        public short? Sf { get; set; }
        public short? Gidp { get; set; }

        public virtual League Lg { get; set; }
        public virtual Person Player { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
    }
}
