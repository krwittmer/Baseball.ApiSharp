using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Park
    {
        public Park()
        {
            Homegames = new HashSet<Homegame>();
        }

        public int Id { get; set; }
        public string Parkalias { get; set; }
        public string Parkkey { get; set; }
        public string Parkname { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Homegame> Homegames { get; set; }
    }
}
