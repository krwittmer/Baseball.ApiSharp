#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                // TODO: consider to change from m.NameFirst + " " + m.NameLast to nameGiven
                var filteredPeople = _repository.Filter<Person>(m => (m.NameFirst + " " + m.NameLast).Contains(searchString));
                foreach (var people in filteredPeople)
                {
                    bool hasValue;
                    var playerModel = new PlayerViewModel()
                    {
                        FirstName = people.NameFirst,
                        LastName = people.NameLast,
                        HomeTown = people.BirthCity,
                        FinalGame = people.FinalGame,
                        PlayerData = new Dictionary<string, string>()
                    };
                    arrayOfPlayers.Add(playerModel);

                    var pitchingData = _repository.Filter<Pitching>(b => b.PlayerId == people.PlayerId);
                    var hasPitchingData = pitchingData.Count() > 0;
                    if (hasPitchingData)
                    {
                        var sumWins = pitchingData.Sum(p => p.W);
                        hasValue = sumWins.HasValue;
                        if (hasValue)
                        {
                            int careerWins = sumWins.Value;
                            if (careerWins > 0)
                            {
                                playerModel.PlayerData.Add("Career Wins", careerWins.ToString());
                            }
                            if (!PlayerViewModel.BindFields.Contains("Career Wins"))
                            {
                                PlayerViewModel.BindFields.Add("Career Wins");
                            }
                        }

                        var sumEra = pitchingData.Sum(p => p.Era);
                        hasValue = sumEra.HasValue;
                        if (hasValue)
                        {
                            double careerEra = sumEra.Value;
                            playerModel.PlayerData.Add("ERA", careerEra.ToString());
                            if (!PlayerViewModel.BindFields.Contains("ERA"))
                            {
                                PlayerViewModel.BindFields.Add("ERA");
                            }
                        }

                        var sumStrikeouts = pitchingData.Sum(p => p.So);
                        hasValue = sumEra.HasValue;
                        if (hasValue)
                        {
                            double careerStrikeouts = sumStrikeouts.Value;
                            playerModel.PlayerData.Add("Strikeouts (P)", careerStrikeouts.ToString());
                            if (!PlayerViewModel.BindFields.Contains("Strikeouts (P)"))
                            {
                                PlayerViewModel.BindFields.Add("Strikeouts (P)");
                            }
                        }

                    }

                    if (!playerModel.PlayerData.ContainsKey("Career Wins"))
                    {
                        playerModel.PlayerData.Add("Career Wins", "N/A");
                    }
                    if (!playerModel.PlayerData.ContainsKey("ERA"))
                    {
                        playerModel.PlayerData.Add("ERA", "N/A");
                    }
                    if (!playerModel.PlayerData.ContainsKey("Strikeouts (P)"))
                    {
                        playerModel.PlayerData.Add("Strikeouts (P)", "N/A");
                    }

                    var battingData = _repository.Filter<Batting>(b => b.PlayerId == people.PlayerId);

                    var sumHomeRuns = battingData.Sum(b => b.Hr);
                    hasValue = sumHomeRuns.HasValue;
                    if (hasValue)
                    {
                        int careerHomeRuns = sumHomeRuns.Value;
                        playerModel.PlayerData.Add("Career Home Runs", careerHomeRuns.ToString());
                        if (!PlayerViewModel.BindFields.Contains("Career Home Runs"))
                        {
                            PlayerViewModel.BindFields.Add("Career Home Runs");
                        }
                    }

                    var sumAB = battingData.Sum(p => p.Ab);
                    hasValue = sumAB.HasValue;
                    if (hasValue)
                    {
                        playerModel.PlayerData.Add("Career At Bats", sumAB.ToString());
                        if (!PlayerViewModel.BindFields.Contains("Career At Bats"))
                        {
                            PlayerViewModel.BindFields.Add("Career At Bats");
                        }
                    }

                    var sumR = battingData.Sum(p => p.R);
                    hasValue = sumR.HasValue;
                    if (hasValue)
                    {
                        playerModel.PlayerData.Add("Career Runs", sumR.ToString());
                        if (!PlayerViewModel.BindFields.Contains("Career Runs"))
                        {
                            PlayerViewModel.BindFields.Add("Career Runs");
                        }
                    }

                    var sumRbi = battingData.Sum(p => p.Rbi);
                    hasValue = sumRbi.HasValue;
                    if (hasValue)
                    {
                        playerModel.PlayerData.Add("Runs Batted In", sumRbi.ToString());
                        if (!PlayerViewModel.BindFields.Contains("Runs Batted In"))
                        {
                            PlayerViewModel.BindFields.Add("Runs Batted In");
                        }
                    }

                    var sumWalks = battingData.Sum(p => p.Bb);
                    hasValue = sumWalks.HasValue;
                    if (hasValue)
                    {
                        playerModel.PlayerData.Add("Walks", sumWalks.ToString());
                        if (!PlayerViewModel.BindFields.Contains("Walks"))
                        {
                            PlayerViewModel.BindFields.Add("Walks");
                        }
                    }

                    var sumStrikeOuts = battingData.Sum(p => p.So);
                    hasValue = sumStrikeOuts.HasValue;
                    if (hasValue)
                    {
                        playerModel.PlayerData.Add("Strikeouts", sumStrikeOuts.ToString());
                        if (!PlayerViewModel.BindFields.Contains("Strikeouts"))
                        {
                            PlayerViewModel.BindFields.Add("Strikeouts");
                        }
                    }

                    int fieldCount = PlayerViewModel.BindFields.Count;
                    Trace.WriteLine($"Field count inspected {fieldCount}");
                    int dataCount = playerModel.PlayerData.Count;
                    Trace.WriteLine($"Data count inspected {fieldCount}");
                }
            }

            return new PlayerSearchResultsViewModel() { Players = arrayOfPlayers };
        }

    }
}