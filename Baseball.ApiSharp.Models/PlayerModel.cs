#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Models {

    public class PlayerModel { 

        public string PlayerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set ;}

        public string GivenName { get; set; }

        public int? Weight { get; set; }

        public int? Height { get; set; }

        public char Bats { get; set; }

        public char Throws { get; set; }

        public IDictionary<string, string> PlayerData = new SortedDictionary<string, string>();
 
        public DateTime BirthDate { get; internal set; }
        public DateTime DebutGameDate { get; set; }
        public DateTime LastGameDate { get; set; }
    }
}
