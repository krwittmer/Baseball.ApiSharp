﻿using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Battingpost
    {
        public int Id { get; set; }
        public short YearId { get; set; }
        public string Round { get; set; }
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public string LgId { get; set; }
        public short? G { get; set; }
        public short? Ab { get; set; }
        public short? R { get; set; }
        public short? H { get; set; }
        public short? _2b { get; set; }
        public short? _3b { get; set; }
        public short? Hr { get; set; }
        public short? Rbi { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public short? Bb { get; set; }
        public short? So { get; set; }
        public short? Ibb { get; set; }
        public short? Hbp { get; set; }
        public short? Sh { get; set; }
        public short? Sf { get; set; }
        public short? Gidp { get; set; }

        public virtual League Lg { get; set; }
        public virtual Person Player { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
    }
}
