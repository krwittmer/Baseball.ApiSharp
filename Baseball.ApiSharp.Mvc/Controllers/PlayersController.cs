#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using System.Linq;
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Data.Lahman;
using Baseball.ApiSharp.Mvc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NUglify.Helpers;

namespace Baseball.ApiSharp.Mvc.Controllers
{
    [Route("[controller]/[action]")]
    public class PlayersController : Controller
    {
        private readonly IRepository _repository;

        public PlayersController(IRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public IActionResult SearchPlayers(string searchString)
        {
            var playerSearchResults = SearchRepository(searchString);
            return View("~/Views/Shared/Components/PlayersList/PlayersList.cshtml", playerSearchResults);
        }

        private PlayerSearchResultsViewModel SearchRepository(string searchString)
        {
            var arrayOfPlayers = new List<PlayerViewModel>();

            if (!searchString.IsNullOrWhiteSpace())
            {
                var filteredPeople = _repository.Filter<People>(m => (m.NameFirst + " " + m.NameLast).Contains(searchString));
                foreach (var people in filteredPeople)
                {
                    var batters = _repository.Filter<Batting>(b => b.PlayerId == people.PlayerId);
                    if (batters.Any())
                    {
                        var firstBatterData = batters.First();

                        short homeRuns = 0;
                        if (firstBatterData.Hr != null)
                        {
                            homeRuns = (short)firstBatterData.Hr;
                        }

                        var playerModel = new PlayerViewModel()
                        {
                            FirstName = people.NameFirst,
                            LastName = people.NameLast,
                            HomeTown = people.BirthCity,
                            FinalGame = people.FinalGame,
                            HomeRuns = homeRuns
                        };
                        arrayOfPlayers.Add(playerModel);
                    }
                }
            }

            return new PlayerSearchResultsViewModel() { Players = arrayOfPlayers };
        }
    }
}