﻿using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Parks
    {
        public int Id { get; set; }
        public string Parkalias { get; set; }
        public string Parkkey { get; set; }
        public string Parkname { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
