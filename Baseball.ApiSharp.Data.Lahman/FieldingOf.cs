﻿using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class FieldingOf
    {
        public string PlayerId { get; set; }
        public short YearId { get; set; }
        public short Stint { get; set; }
        public short? Glf { get; set; }
        public short? Gcf { get; set; }
        public short? Grf { get; set; }
    }
}
