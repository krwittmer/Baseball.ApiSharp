using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class School
    {
        public School()
        {
            Collegeplayings = new HashSet<Collegeplaying>();
        }

        public string SchoolId { get; set; }
        public string NameFull { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Collegeplaying> Collegeplayings { get; set; }
    }
}
