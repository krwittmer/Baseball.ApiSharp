using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class CollegePlaying
    {
        public string PlayerId { get; set; }
        public string SchoolId { get; set; }
        public short? YearId { get; set; }
    }
}
