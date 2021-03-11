#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;

namespace Baseball.ApiSharp.Mvc.Models.ViewModels
{
    public class BatterSearchResultsViewModel
    {
        public IEnumerable<BatterViewModel> Batters { get; set; }
    }
}