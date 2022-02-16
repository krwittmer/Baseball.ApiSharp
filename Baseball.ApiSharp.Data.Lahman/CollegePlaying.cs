using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Collegeplaying
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public string SchoolId { get; set; }
        public short? YearId { get; set; }

        public virtual Person Player { get; set; }
        public virtual School School { get; set; }
    }
}
