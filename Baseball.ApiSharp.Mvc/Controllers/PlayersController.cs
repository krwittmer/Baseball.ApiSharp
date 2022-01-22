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
                // change from m.NameFirst + " " + m.NameLast to nameGiven
                var filteredPeople = _repository.Filter<Person>(m => (m.NameFirst + " " + m.NameLast).Contains(searchString));
                foreach (var people in filteredPeople)
                {
                    int careerHomeRuns = 0;
                    var batters = _repository.Filter<Batting>(b => b.PlayerId == people.PlayerId);
                    var sumHomeRuns = batters.Sum(b => b.Hr);
                    bool hasValue = sumHomeRuns.HasValue;
                    if (hasValue)
                    {
                        careerHomeRuns = sumHomeRuns.Value;
                    }

                    int careerWins = 0;
                    var pitchers = _repository.Filter<Pitching>(b => b.PlayerId == people.PlayerId);
                    var sumWins = pitchers.Sum(p => p.W);
                    hasValue = sumWins.HasValue;
                    if (hasValue)
                    {
                        careerWins = sumWins.Value;
                    }

                    var playerModel = new PlayerViewModel()
                    {
                        FirstName = people.NameFirst,
                        LastName = people.NameLast,
                        HomeTown = people.BirthCity,
                        FinalGame = people.FinalGame,
                        CareerHomeRuns = careerHomeRuns,
                        CareerWins = careerWins
                    };
                    arrayOfPlayers.Add(playerModel);

                }
            }

            return new PlayerSearchResultsViewModel() { Players = arrayOfPlayers };
        }
    }
}