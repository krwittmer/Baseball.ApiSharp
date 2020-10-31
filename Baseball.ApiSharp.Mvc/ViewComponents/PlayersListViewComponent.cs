#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using System.Threading.Tasks;
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Mvc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Baseball.ApiSharp.Mvc.ViewComponents
{
    public class PlayersListViewComponent : ViewComponent
    {
        private readonly IRepository _repo;

        public PlayersListViewComponent(IRepository repository)
        {
            _repo = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewArg = new PlayerSearchResultsViewModel() {Players = new List<PlayerViewModel>()};
            return await Task.Run<IViewComponentResult>(() => View("PlayersList", viewArg));
        }
    }
}