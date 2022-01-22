#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

namespace Baseball.ApiSharp.Models {
    public class PlayerIdModel
    {
        public string PlayerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string GivenName { get; set; }
    }
}