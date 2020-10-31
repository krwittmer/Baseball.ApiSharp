#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using Baseball.ApiSharp.Data.Lahman;
using Xunit;

namespace Baseball.ApiSharp.Models.Tests
{
    public class PlayerModelMapperTests
    {
        [Fact]
        public void MapAnthonyRizoMasterPlayerDataTest()
        {
            var anthonyRizoMasterPlayerData = new People
            {
                PlayerId = "rizzoan01",
                Bats = "L",
                Throws = "L",
                NameFirst = "Anthony",
                NameLast = "Rizzo",
                BbrefId = "rizzoan01",
                BirthCity = "Fort Lauderdale",
                BirthDay = 8,
                BirthCountry = "USA",
                BirthState = "FL",
                BirthMonth = 8,
                BirthYear = 1989,
                Weight = 225,
                Height = 76,
                Debut = "2011-06-09",
                FinalGame = "2016-10-02",
                RetroId = "rizza001"
            };

            var playerModel = Mapper.MapObject<PlayerModel>(anthonyRizoMasterPlayerData);
            Assert.Equal("rizzoan01", playerModel.PlayerId);
            Assert.Equal('L', playerModel.Bats);
            Assert.Equal('L', playerModel.Throws);
            Assert.Equal("Anthony", playerModel.FirstName);
            Assert.Equal("Rizzo", playerModel.LastName);
            Assert.True(225 == playerModel.Weight);
            Assert.True(76 == playerModel.Height);
            Assert.Equal(new DateTime(1989, 8, 8), playerModel.BirthDate);
            Assert.Equal(new DateTime(2011, 6, 9), playerModel.DebutGameDate);
            Assert.Equal(new DateTime(2016, 10, 2), playerModel.LastGameDate);
        }
    }
}