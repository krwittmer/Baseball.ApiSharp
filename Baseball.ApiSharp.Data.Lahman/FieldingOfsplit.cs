﻿using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Fieldingofsplit
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public short YearId { get; set; }
        public short Stint { get; set; }
        public string TeamId { get; set; }
        public int? TeamId1 { get; set; }
        public string LgId { get; set; }
        public string Pos { get; set; }
        public short? G { get; set; }
        public short? Gs { get; set; }
        public short? InnOuts { get; set; }
        public short? Po { get; set; }
        public short? A { get; set; }
        public short? E { get; set; }
        public short? Dp { get; set; }
        public short? Pb { get; set; }
        public short? Wp { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public double? Zr { get; set; }

        public virtual League Lg { get; set; }
        public virtual Person Player { get; set; }
        public virtual Team TeamId1Navigation { get; set; }
    }
}
