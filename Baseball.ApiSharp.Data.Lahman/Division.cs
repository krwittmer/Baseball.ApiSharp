using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Division
    {
        public Division()
        {
            Teams = new HashSet<Team>();
            Teamshalves = new HashSet<Teamshalf>();
        }

        public int Id { get; set; }
        public string DivId { get; set; }
        public string LgId { get; set; }
        public string Division1 { get; set; }
        public string Active { get; set; }

        public virtual League Lg { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Teamshalf> Teamshalves { get; set; }
    }
}
