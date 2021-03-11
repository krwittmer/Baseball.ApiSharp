#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

namespace Baseball.ApiSharp.Mvc.Models.ViewModels
{
    public class PlayerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string HomeTown { get; set; }

        public string FinalGame { get; set; }
        public int CareerHomeRuns { get; set; }
        public int CareerWins { get; set; }
    }
}
