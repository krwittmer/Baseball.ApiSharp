#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Baseball.ApiSharp.Mvc.Models.ViewModels
{
    public class PlayerSearchViewModel
    {
        // TODO: impl. models/APIs, public List<Teams> Teams { get; set; }
        public SelectList Positions { get; set; }
        public string League { get; set; }
        public string SearchString { get; set; }
    }
}
