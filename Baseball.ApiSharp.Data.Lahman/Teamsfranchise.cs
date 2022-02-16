using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Teamsfranchise
    {
        public Teamsfranchise()
        {
            Teams = new HashSet<Team>();
        }

        public string FranchId { get; set; }
        public string FranchName { get; set; }
        public string Active { get; set; }
        public string Naassoc { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
