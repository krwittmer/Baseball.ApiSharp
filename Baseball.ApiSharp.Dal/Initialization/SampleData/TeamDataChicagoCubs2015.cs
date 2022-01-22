#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Data.Lahman;

namespace Baseball.ApiSharp.Dal.Initialization.SampleData
{
	public partial class TeamDataChicagoCubs2015
	{
		public static void SeedData(LahmansDbContext dbContext)
		{
			BulkMasterPlayerInsert(dbContext);
			BulkPitchingPlayerInsert(dbContext);
			BulkBattingPlayerInsert(dbContext);
			BulkFieldingPlayerInsert(dbContext);
		}

		public static void BulkMasterPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.People.Count(m => m.PlayerId == "arrieja01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "arrieja01", Bats = "R", Throws = "R", NameFirst = "Jake", NameLast = "Arrieta", BbrefId = "arrieja01", BirthCity = "Farmington", BirthDay = 6, BirthCountry = "USA", BirthState = "MO", BirthMonth = 3, BirthYear = 1986, Debut = "2010-06-10 00:00:00", FinalGame = "2018-09-27 00:00:00", Height = 76, Weight = 225, RetroId = "arrij001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "beeleda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "beeleda01", Bats = "R", Throws = "R", NameFirst = "Dallas", NameLast = "Beeler", BbrefId = "beeleda01", BirthCity = "Tulsa", BirthDay = 12, BirthCountry = "USA", BirthState = "OK", BirthMonth = 6, BirthYear = 1989, Debut = "2014-06-28 00:00:00", FinalGame = "2015-07-28 00:00:00", Height = 77, Weight = 225, RetroId = "beeld001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "cahiltr01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "cahiltr01", Bats = "R", Throws = "R", NameFirst = "Trevor", NameLast = "Cahill", BbrefId = "cahiltr01", BirthCity = "Oceanside", BirthDay = 1, BirthCountry = "USA", BirthState = "CA", BirthMonth = 3, BirthYear = 1988, Debut = "2009-04-07 00:00:00", FinalGame = "2018-09-29 00:00:00", Height = 76, Weight = 240, RetroId = "cahit001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "cokeph01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "cokeph01", Bats = "L", Throws = "L", NameFirst = "Phil", NameLast = "Coke", BbrefId = "cokeph01", BirthCity = "Sonora", BirthDay = 19, BirthCountry = "USA", BirthState = "CA", BirthMonth = 7, BirthYear = 1982, Debut = "2008-09-01 00:00:00", FinalGame = "2016-09-26 00:00:00", Height = 73, Weight = 210, RetroId = "cokep001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "denorch01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "denorch01", Bats = "R", Throws = "R", NameFirst = "Chris", NameLast = "Denorfia", BbrefId = "denorch01", BirthCity = "Bristol", BirthDay = 15, BirthCountry = "USA", BirthState = "CT", BirthMonth = 7, BirthYear = 1980, Debut = "2005-09-07 00:00:00", FinalGame = "2015-10-04 00:00:00", Height = 72, Weight = 195, RetroId = "denoc001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "edwarca01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "edwarca01", Bats = "R", Throws = "R", NameFirst = "Carl", NameLast = "Edwards", BbrefId = "edwarca01", BirthCity = "Newberry", BirthDay = 3, BirthCountry = "USA", BirthState = "SC", BirthMonth = 9, BirthYear = 1991, Debut = "2015-09-07 00:00:00", FinalGame = "2018-09-30 00:00:00", Height = 75, Weight = 170, RetroId = "edwac001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "germego01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "germego01", Bats = "R", Throws = "R", NameFirst = "Gonzalez", NameLast = "Germen", BbrefId = "germego01", BirthCity = "Guaymate", BirthDay = 23, BirthCountry = "D.R.", BirthState = "La Romana", BirthMonth = 9, BirthYear = 1987, Debut = "2013-07-12 00:00:00", FinalGame = "2016-08-10 00:00:00", Height = 73, Weight = 200, RetroId = "germg001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "grimmju01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "grimmju01", Bats = "R", Throws = "R", NameFirst = "Justin", NameLast = "Grimm", BbrefId = "grimmju01", BirthCity = "Bristol", BirthDay = 16, BirthCountry = "USA", BirthState = "TN", BirthMonth = 8, BirthYear = 1988, Debut = "2012-06-16 00:00:00", FinalGame = "2018-09-25 00:00:00", Height = 75, Weight = 210, RetroId = "grimj002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hammeja01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hammeja01", Bats = "R", Throws = "R", NameFirst = "Jason", NameLast = "Hammel", BbrefId = "hammeja01", BirthCity = "Greenville", BirthDay = 2, BirthCountry = "USA", BirthState = "SC", BirthMonth = 9, BirthYear = 1982, Debut = "2006-04-11 00:00:00", FinalGame = "2018-09-27 00:00:00", Height = 78, Weight = 225, RetroId = "hammj002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "harenda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "harenda01", Bats = "R", Throws = "R", NameFirst = "Dan", NameLast = "Haren", BbrefId = "harenda01", BirthCity = "Monterey Park", BirthDay = 17, BirthCountry = "USA", BirthState = "CA", BirthMonth = 9, BirthYear = 1980, Debut = "2003-06-30 00:00:00", FinalGame = "2015-10-04 00:00:00", Height = 77, Weight = 215, RetroId = "hared001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hendrky01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hendrky01", Bats = "R", Throws = "R", NameFirst = "Kyle", NameLast = "Hendricks", BbrefId = "hendrky01", BirthCity = "Newport Beach", BirthDay = 7, BirthCountry = "USA", BirthState = "CA", BirthMonth = 12, BirthYear = 1989, Debut = "2014-07-10 00:00:00", FinalGame = "2018-09-28 00:00:00", Height = 75, Weight = 190, RetroId = "hendk001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hunteto02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hunteto02", Bats = "R", Throws = "R", NameFirst = "Tommy", NameLast = "Hunter", BbrefId = "hunteto02", BirthCity = "Indianapolis", BirthDay = 3, BirthCountry = "USA", BirthState = "IN", BirthMonth = 7, BirthYear = 1986, Debut = "2008-08-01 00:00:00", FinalGame = "2018-09-30 00:00:00", Height = 75, Weight = 250, RetroId = "huntt002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "jacksed01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "jacksed01", Bats = "R", Throws = "R", NameFirst = "Edwin", NameLast = "Jackson", BbrefId = "jacksed01", BirthCity = "Neu-Ulm", BirthDay = 9, BirthCountry = "Germany", BirthState = "Bavaria", BirthMonth = 9, BirthYear = 1983, Debut = "2003-09-09 00:00:00", FinalGame = "2018-09-26 00:00:00", Height = 74, Weight = 215, RetroId = "jacke001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lestejo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lestejo01", Bats = "L", Throws = "L", NameFirst = "Jon", NameLast = "Lester", BbrefId = "lestejo01", BirthCity = "Tacoma", BirthDay = 7, BirthCountry = "USA", BirthState = "WA", BirthMonth = 1, BirthYear = 1984, Debut = "2006-06-10 00:00:00", FinalGame = "2018-09-27 00:00:00", Height = 76, Weight = 240, RetroId = "lestj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "medinyo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "medinyo01", Bats = "R", Throws = "R", NameFirst = "Yoervis", NameLast = "Medina", BbrefId = "medinyo01", BirthCity = "Puerto Cabello", BirthDay = 27, BirthCountry = "Venezuela", BirthState = "Carabobo", BirthMonth = 7, BirthYear = 1988, Debut = "2013-04-16 00:00:00", FinalGame = "2015-07-26 00:00:00", Height = 75, Weight = 245, RetroId = "mediy001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "motteja01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "motteja01", Bats = "R", Throws = "R", NameFirst = "Jason", NameLast = "Motte", BbrefId = "motteja01", BirthCity = "Port Huron", BirthDay = 22, BirthCountry = "USA", BirthState = "MI", BirthMonth = 6, BirthYear = 1982, Debut = "2008-09-03 00:00:00", FinalGame = "2017-10-01 00:00:00", Height = 72, Weight = 205, RetroId = "mottj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "ramirne01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "ramirne01", Bats = "R", Throws = "R", NameFirst = "Neil", NameLast = "Ramirez", BbrefId = "ramirne01", BirthCity = "Virginia Beach", BirthDay = 25, BirthCountry = "USA", BirthState = "VA", BirthMonth = 5, BirthYear = 1989, Debut = "2014-04-25 00:00:00", FinalGame = "2018-09-27 00:00:00", Height = 76, Weight = 215, RetroId = "ramin001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "richacl01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "richacl01", Bats = "L", Throws = "L", NameFirst = "Clayton", NameLast = "Richard", BbrefId = "richacl01", BirthCity = "Lafayette", BirthDay = 12, BirthCountry = "USA", BirthState = "IN", BirthMonth = 9, BirthYear = 1983, Debut = "2008-07-23 00:00:00", FinalGame = "2018-08-24 00:00:00", Height = 77, Weight = 240, RetroId = "richc002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "roachdo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "roachdo01", Bats = "R", Throws = "R", NameFirst = "Donn", NameLast = "Roach", BbrefId = "roachdo01", BirthCity = "Las Vegas", BirthDay = 14, BirthCountry = "USA", BirthState = "NV", BirthMonth = 12, BirthYear = 1989, Debut = "2014-04-02 00:00:00", FinalGame = "2016-08-02 00:00:00", Height = 72, Weight = 195, RetroId = "roacd001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rodnefe01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rodnefe01", Bats = "R", Throws = "R", NameFirst = "Fernando", NameLast = "Rodney", BbrefId = "rodnefe01", BirthCity = "Santo Domingo", BirthDay = 18, BirthCountry = "D.R.", BirthState = "Distrito Nacional", BirthMonth = 3, BirthYear = 1977, Debut = "2002-05-04 00:00:00", FinalGame = "2018-09-29 00:00:00", Height = 71, Weight = 230, RetroId = "rodnf001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rondohe01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rondohe01", Bats = "R", Throws = "R", NameFirst = "Hector", NameLast = "Rondon", BbrefId = "rondohe01", BirthCity = "Guatire", BirthDay = 26, BirthCountry = "Venezuela", BirthState = "Miranda", BirthMonth = 2, BirthYear = 1988, Debut = "2013-04-03 00:00:00", FinalGame = "2018-09-29 00:00:00", Height = 75, Weight = 230, RetroId = "rondh001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rosscza01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rosscza01", Bats = "R", Throws = "L", NameFirst = "Zac", NameLast = "Rosscup", BbrefId = "rosscza01", BirthCity = "Clackamas", BirthDay = 9, BirthCountry = "USA", BirthState = "OR", BirthMonth = 6, BirthYear = 1988, Debut = "2013-09-03 00:00:00", FinalGame = "2018-09-29 00:00:00", Height = 74, Weight = 220, RetroId = "rossz001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rossda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rossda01", Bats = "R", Throws = "R", NameFirst = "David", NameLast = "Ross", BbrefId = "rossda01", BirthCity = "Bainbridge", BirthDay = 19, BirthCountry = "USA", BirthState = "GA", BirthMonth = 3, BirthYear = 1977, Debut = "2002-06-29 00:00:00", FinalGame = "2016-10-01 00:00:00", Height = 74, Weight = 230, RetroId = "rossd001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "russeja02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "russeja02", Bats = "L", Throws = "L", NameFirst = "James", NameLast = "Russell", BbrefId = "russeja02", BirthCity = "Cincinnati", BirthDay = 8, BirthCountry = "USA", BirthState = "OH", BirthMonth = 1, BirthYear = 1986, Debut = "2010-04-05 00:00:00", FinalGame = "2016-04-19 00:00:00", Height = 76, Weight = 205, RetroId = "russj003" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "schlibr01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "schlibr01", Bats = "R", Throws = "R", NameFirst = "Brian", NameLast = "Schlitter", BbrefId = "schlibr01", BirthCity = "Oak Park", BirthDay = 21, BirthCountry = "USA", BirthState = "IL", BirthMonth = 12, BirthYear = 1985, Debut = "2010-06-28 00:00:00", FinalGame = "2015-06-14 00:00:00", Height = 77, Weight = 240, RetroId = "schlb001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "soriara01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "soriara01", Bats = "R", Throws = "R", NameFirst = "Rafael", NameLast = "Soriano", BbrefId = "soriara01", BirthCity = "San Jose", BirthDay = 19, BirthCountry = "D.R.", BirthState = "San Pedro de Macoris", BirthMonth = 12, BirthYear = 1979, Debut = "2002-05-10 00:00:00", FinalGame = "2015-07-30 00:00:00", Height = 76, Weight = 230, RetroId = "sorir001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "stroppe01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "stroppe01", Bats = "R", Throws = "R", NameFirst = "Pedro", NameLast = "Strop", BbrefId = "stroppe01", BirthCity = "San Cristobal", BirthDay = 13, BirthCountry = "D.R.", BirthState = "San Cristobal", BirthMonth = 6, BirthYear = 1985, Debut = "2009-08-28 00:00:00", FinalGame = "2018-09-13 00:00:00", Height = 73, Weight = 220, RetroId = "strop001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "wadats01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "wadats01", Bats = "L", Throws = "L", NameFirst = "Tsuyoshi", NameLast = "Wada", BbrefId = "wadats01", BirthCity = "Izumo", BirthDay = 21, BirthCountry = "Japan", BirthState = "Shimane", BirthMonth = 2, BirthYear = 1981, Debut = "2014-07-08 00:00:00", FinalGame = "2015-09-04 00:00:00", Height = 71, Weight = 180, RetroId = "wadat001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "woodtr01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "woodtr01", Bats = "R", Throws = "L", NameFirst = "Travis", NameLast = "Wood", BbrefId = "woodtr01", BirthCity = "Little Rock", BirthDay = 6, BirthCountry = "USA", BirthState = "AR", BirthMonth = 2, BirthYear = 1987, Debut = "2010-07-01 00:00:00", FinalGame = "2017-09-25 00:00:00", Height = 71, Weight = 175, RetroId = "woodt004" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "alcanar01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "alcanar01", Bats = "B", Throws = "R", NameFirst = "Arismendy", NameLast = "Alcantara", BbrefId = "alcanar01", BirthCity = "Santo Domingo", BirthDay = 29, BirthCountry = "D.R.", BirthState = "Distrito Nacional", BirthMonth = 10, BirthYear = 1991, Debut = "2014-07-09 00:00:00", FinalGame = "2017-08-09 00:00:00", Height = 70, Weight = 170, RetroId = "alcaa001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "baezja01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "baezja01", Bats = "R", Throws = "R", NameFirst = "Javier", NameLast = "Baez", BbrefId = "baezja01", BirthCity = "Bayamon", BirthDay = 1, BirthCountry = "P.R.", BirthMonth = 12, BirthYear = 1992, Debut = "2014-08-05 00:00:00", FinalGame = "2018-10-01 00:00:00", Height = 72, Weight = 190, RetroId = "baezj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "baxtemi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "baxtemi01", Bats = "L", Throws = "R", NameFirst = "Mike", NameLast = "Baxter", BbrefId = "baxtemi01", BirthCity = "Queens", BirthDay = 7, BirthCountry = "USA", BirthState = "NY", BirthMonth = 12, BirthYear = 1984, Debut = "2010-09-06 00:00:00", FinalGame = "2015-07-08 00:00:00", Height = 72, Weight = 205, RetroId = "baxtm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "berryqu01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "berryqu01", Bats = "L", Throws = "L", NameFirst = "Quintin", NameLast = "Berry", BbrefId = "berryqu01", BirthCity = "San Diego", BirthDay = 21, BirthCountry = "USA", BirthState = "CA", BirthMonth = 11, BirthYear = 1984, Debut = "2012-05-23 00:00:00", FinalGame = "2017-10-01 00:00:00", Height = 73, Weight = 195, RetroId = "berrq001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "bryankr01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "bryankr01", Bats = "R", Throws = "R", NameFirst = "Kris", NameLast = "Bryant", BbrefId = "bryankr01", BirthCity = "Las Vegas", BirthDay = 4, BirthCountry = "USA", BirthState = "NV", BirthMonth = 1, BirthYear = 1992, Debut = "2015-04-17 00:00:00", FinalGame = "2018-10-01 00:00:00", Height = 77, Weight = 230, RetroId = "bryak001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "castiwe01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "castiwe01", Bats = "R", Throws = "R", NameFirst = "Welington", NameLast = "Castillo", BbrefId = "castiwe01", BirthCity = "San Isidro", BirthDay = 24, BirthCountry = "D.R.", BirthState = "Distrito Nacional", BirthMonth = 4, BirthYear = 1987, Debut = "2010-08-11 00:00:00", FinalGame = "2018-09-30 00:00:00", Height = 70, Weight = 220, RetroId = "castw002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "castrst01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "castrst01", Bats = "R", Throws = "R", NameFirst = "Starlin", NameLast = "Castro", BbrefId = "castrst01", BirthCity = "Monte Cristi", BirthDay = 24, BirthCountry = "D.R.", BirthState = "Monte Cristi", BirthMonth = 3, BirthYear = 1990, Debut = "2010-05-07 00:00:00", FinalGame = "2018-09-30 00:00:00", Height = 74, Weight = 230, RetroId = "casts001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "coghlch01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "coghlch01", Bats = "L", Throws = "R", NameFirst = "Chris", NameLast = "Coghlan", BbrefId = "coghlch01", BirthCity = "Rockville", BirthDay = 18, BirthCountry = "USA", BirthState = "MD", BirthMonth = 6, BirthYear = 1985, Debut = "2009-05-08 00:00:00", FinalGame = "2017-06-07 00:00:00", Height = 72, Weight = 195, RetroId = "coghc001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "fowlede01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "fowlede01", Bats = "B", Throws = "R", NameFirst = "Dexter", NameLast = "Fowler", BbrefId = "fowlede01", BirthCity = "Atlanta", BirthDay = 22, BirthCountry = "USA", BirthState = "GA", BirthMonth = 3, BirthYear = 1986, Debut = "2008-09-02 00:00:00", FinalGame = "2018-08-03 00:00:00", Height = 77, Weight = 195, RetroId = "fowld001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "herrejo03") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "herrejo03", Bats = "B", Throws = "R", NameFirst = "Jonathan", NameLast = "Herrera", BbrefId = "herrejo03", BirthCity = "Maracaibo", BirthDay = 3, BirthCountry = "Venezuela", BirthState = "Zulia", BirthMonth = 11, BirthYear = 1984, Debut = "2008-04-30 00:00:00", FinalGame = "2015-09-09 00:00:00", Height = 69, Weight = 180, RetroId = "herrj002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "jacksau01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "jacksau01", Bats = "R", Throws = "R", NameFirst = "Austin", NameLast = "Jackson", BbrefId = "jacksau01", BirthCity = "Denton", BirthDay = 1, BirthCountry = "USA", BirthState = "TX", BirthMonth = 2, BirthYear = 1987, Debut = "2010-04-05 00:00:00", FinalGame = "2018-09-30 00:00:00", Height = 73, Weight = 198, RetroId = "jacka001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lakeju01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lakeju01", Bats = "R", Throws = "R", NameFirst = "Junior", NameLast = "Lake", BbrefId = "lakeju01", BirthCity = "San Pedro de Macoris", BirthDay = 27, BirthCountry = "D.R.", BirthState = "San Pedro de Macoris", BirthMonth = 3, BirthYear = 1990, Debut = "2013-07-19 00:00:00", FinalGame = "2016-08-15 00:00:00", Height = 74, Weight = 230, RetroId = "lakej001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lasteto01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lasteto01", Bats = "L", Throws = "R", NameFirst = "Tommy", NameLast = "La Stella", BbrefId = "lasteto01", BirthCity = "Westwood", BirthDay = 31, BirthCountry = "USA", BirthState = "NJ", BirthMonth = 1, BirthYear = 1989, Debut = "2014-05-28 00:00:00", FinalGame = "2018-10-01 00:00:00", Height = 71, Weight = 180, RetroId = "lastt001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "montemi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "montemi01", Bats = "L", Throws = "R", NameFirst = "Miguel", NameLast = "Montero", BbrefId = "montemi01", BirthCity = "Caracas", BirthDay = 9, BirthCountry = "Venezuela", BirthState = "Distrito Federal", BirthMonth = 7, BirthYear = 1983, Debut = "2006-09-06 00:00:00", FinalGame = "2018-04-05 00:00:00", Height = 71, Weight = 221, RetroId = "montm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "oltmi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "oltmi01", Bats = "R", Throws = "R", NameFirst = "Mike", NameLast = "Olt", BbrefId = "oltmi01", BirthCity = "New Haven", BirthDay = 27, BirthCountry = "USA", BirthState = "CT", BirthMonth = 8, BirthYear = 1988, Debut = "2012-08-02 00:00:00", FinalGame = "2015-10-04 00:00:00", Height = 74, Weight = 210, RetroId = "olt-m001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rizzoan01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rizzoan01", Bats = "L", Throws = "L", NameFirst = "Anthony", NameLast = "Rizzo", BbrefId = "rizzoan01", BirthCity = "Fort Lauderdale", BirthDay = 8, BirthCountry = "USA", BirthState = "FL", BirthMonth = 8, BirthYear = 1989, Debut = "2011-06-09 00:00:00", FinalGame = "2018-10-01 00:00:00", Height = 75, Weight = 240, RetroId = "rizza001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "russead02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "russead02", Bats = "R", Throws = "R", NameFirst = "Addison", NameLast = "Russell", BbrefId = "russead02", BirthCity = "Pensacola", BirthDay = 23, BirthCountry = "USA", BirthState = "FL", BirthMonth = 1, BirthYear = 1994, Debut = "2015-04-21 00:00:00", FinalGame = "2018-09-19 00:00:00", Height = 72, Weight = 200, RetroId = "russa002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "schwaky01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "schwaky01", Bats = "L", Throws = "R", NameFirst = "Kyle", NameLast = "Schwarber", BbrefId = "schwaky01", BirthCity = "Middletown", BirthDay = 5, BirthCountry = "USA", BirthState = "OH", BirthMonth = 3, BirthYear = 1993, Debut = "2015-06-16 00:00:00", FinalGame = "2018-10-01 00:00:00", Height = 72, Weight = 235, RetroId = "schwk001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "solerjo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "solerjo01", Bats = "R", Throws = "R", NameFirst = "Jorge", NameLast = "Soler", BbrefId = "solerjo01", BirthCity = "La Habana", BirthDay = 25, BirthCountry = "Cuba", BirthState = "La Habana", BirthMonth = 2, BirthYear = 1992, Debut = "2014-08-27 00:00:00", FinalGame = "2018-06-15 00:00:00", Height = 76, Weight = 230, RetroId = "solej001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "szczuma01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "szczuma01", Bats = "R", Throws = "R", NameFirst = "Matt", NameLast = "Szczur", BbrefId = "szczuma01", BirthCity = "Cape May", BirthDay = 20, BirthCountry = "USA", BirthState = "NJ", BirthMonth = 7, BirthYear = 1989, Debut = "2014-08-17 00:00:00", FinalGame = "2018-06-30 00:00:00", Height = 72, Weight = 200, RetroId = "szczm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "teagata01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "teagata01", Bats = "R", Throws = "R", NameFirst = "Taylor", NameLast = "Teagarden", BbrefId = "teagata01", BirthCity = "Dallas", BirthDay = 21, BirthCountry = "USA", BirthState = "TX", BirthMonth = 12, BirthYear = 1983, Debut = "2008-07-18 00:00:00", FinalGame = "2015-07-26 00:00:00", Height = 72, Weight = 210, RetroId = "teagt001" });
			}
			dbContext.SaveChanges();
		}

		public static void BulkPitchingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Pitching.Count(m => m.PlayerId == "arrieja01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "arrieja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 22, L = 6, G = 33, Gs = 33, Cg = 4, Sho = 3, Sv = 0, Ipouts = 687, H = 150, Er = 45, Hr = 10, Bb = 48, So = 236, Baopp = 185, Era = 177, Ibb = 2, Wp = 6, Hbp = 6, Bk = 0, Bfp = 870, Gf = 0, R = 52, Sh = 4, Sf = 1, Gidp = 15 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "beeleda01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "beeleda01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 1, G = 3, Gs = 3, Cg = 0, Sho = 0, Sv = 0, Ipouts = 25, H = 14, Er = 9, Hr = 0, Bb = 7, So = 7, Baopp = 359, Era = 972, Ibb = 2, Wp = 0, Hbp = 0, Bk = 0, Bfp = 46, Gf = 0, R = 11, Sh = 0, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "cahiltr01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "cahiltr01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", W = 1, L = 0, G = 11, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 51, H = 8, Er = 4, Hr = 2, Bb = 5, So = 22, Baopp = 143, Era = 212, Ibb = 0, Wp = 1, Hbp = 1, Bk = 0, Bfp = 63, Gf = 0, R = 4, Sh = 1, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "cokeph01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "cokeph01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 0, G = 16, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 30, H = 14, Er = 7, Hr = 1, Bb = 3, So = 9, Baopp = 341, Era = 630, Ibb = 2, Wp = 0, Hbp = 0, Bk = 0, Bfp = 45, Gf = 2, R = 7, Sh = 0, Sf = 1, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "denorch01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "denorch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 0, G = 1, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 1, H = 0, Er = 0, Hr = 0, Bb = 0, So = 0, Baopp = 0, Era = 0, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 1, Gf = 1, R = 0, Sh = 0, Sf = 0, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "edwarca01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "edwarca01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 0, G = 5, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 14, H = 3, Er = 2, Hr = 0, Bb = 3, So = 4, Baopp = 188, Era = 386, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 19, Gf = 3, R = 3, Sh = 0, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "germego01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "germego01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 0, G = 6, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 18, H = 8, Er = 5, Hr = 0, Bb = 5, So = 8, Baopp = 348, Era = 750, Ibb = 2, Wp = 0, Hbp = 0, Bk = 0, Bfp = 29, Gf = 2, R = 5, Sh = 1, Sf = 0, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "grimmju01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "grimmju01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 3, L = 5, G = 62, Gs = 0, Cg = 0, Sho = 0, Sv = 3, Ipouts = 149, H = 31, Er = 11, Hr = 4, Bb = 26, So = 67, Baopp = 178, Era = 199, Ibb = 1, Wp = 8, Hbp = 1, Bk = 0, Bfp = 204, Gf = 11, R = 18, Sh = 0, Sf = 3, Gidp = 4 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hammeja01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hammeja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 10, L = 7, G = 31, Gs = 31, Cg = 0, Sho = 0, Sv = 0, Ipouts = 512, H = 158, Er = 71, Hr = 23, Bb = 40, So = 172, Baopp = 242, Era = 374, Ibb = 4, Wp = 10, Hbp = 6, Bk = 0, Bfp = 710, Gf = 0, R = 79, Sh = 4, Sf = 6, Gidp = 13 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "harenda01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "harenda01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", W = 4, L = 2, G = 11, Gs = 11, Cg = 0, Sho = 0, Sv = 0, Ipouts = 175, H = 58, Er = 26, Hr = 10, Bb = 13, So = 44, Baopp = 256, Era = 401, Ibb = 1, Wp = 3, Hbp = 1, Bk = 0, Bfp = 244, Gf = 0, R = 29, Sh = 2, Sf = 1, Gidp = 4 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hendrky01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hendrky01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 8, L = 7, G = 32, Gs = 32, Cg = 1, Sho = 1, Sv = 0, Ipouts = 540, H = 166, Er = 79, Hr = 17, Bb = 43, So = 167, Baopp = 244, Era = 395, Ibb = 1, Wp = 3, Hbp = 8, Bk = 1, Bfp = 739, Gf = 0, R = 82, Sh = 6, Sf = 0, Gidp = 15 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hunteto02") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hunteto02", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", W = 2, L = 0, G = 19, Gs = 0, Cg = 0, Sho = 0, Sv = 1, Ipouts = 47, H = 20, Er = 10, Hr = 4, Bb = 3, So = 15, Baopp = 303, Era = 574, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 69, Gf = 5, R = 10, Sh = 0, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "jacksed01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "jacksed01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 2, L = 1, G = 23, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 93, H = 30, Er = 11, Hr = 0, Bb = 12, So = 23, Baopp = 254, Era = 319, Ibb = 1, Wp = 3, Hbp = 1, Bk = 1, Bfp = 134, Gf = 11, R = 14, Sh = 1, Sf = 2, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "lestejo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "lestejo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 11, L = 12, G = 32, Gs = 32, Cg = 1, Sho = 0, Sv = 0, Ipouts = 615, H = 183, Er = 76, Hr = 16, Bb = 47, So = 207, Baopp = 240, Era = 334, Ibb = 0, Wp = 8, Hbp = 7, Bk = 0, Bfp = 828, Gf = 0, R = 83, Sh = 5, Sf = 4, Gidp = 13 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "medinyo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "medinyo01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", W = 0, L = 0, G = 5, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 27, H = 12, Er = 7, Hr = 1, Bb = 4, So = 7, Baopp = 308, Era = 700, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 43, Gf = 2, R = 7, Sh = 0, Sf = 0, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "motteja01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "motteja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 8, L = 1, G = 57, Gs = 0, Cg = 0, Sho = 0, Sv = 6, Ipouts = 145, H = 48, Er = 21, Hr = 4, Bb = 11, So = 34, Baopp = 255, Era = 391, Ibb = 5, Wp = 2, Hbp = 2, Bk = 0, Bfp = 206, Gf = 18, R = 21, Sh = 3, Sf = 2, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "ramirne01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "ramirne01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 1, L = 0, G = 19, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 42, H = 12, Er = 5, Hr = 1, Bb = 6, So = 15, Baopp = 231, Era = 321, Ibb = 0, Wp = 2, Hbp = 0, Bk = 0, Bfp = 60, Gf = 4, R = 5, Sh = 0, Sf = 2, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "richacl01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "richacl01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 4, L = 2, G = 23, Gs = 3, Cg = 0, Sho = 0, Sv = 0, Ipouts = 127, H = 47, Er = 18, Hr = 3, Bb = 7, So = 22, Baopp = 272, Era = 383, Ibb = 1, Wp = 4, Hbp = 1, Bk = 0, Bfp = 181, Gf = 0, R = 18, Sh = 0, Sf = 0, Gidp = 3 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "roachdo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "roachdo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 1, G = 1, Gs = 1, Cg = 0, Sho = 0, Sv = 0, Ipouts = 10, H = 8, Er = 4, Hr = 0, Bb = 1, So = 1, Baopp = 471, Era = 1080, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 18, Gf = 0, R = 4, Sh = 0, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "rodnefe01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "rodnefe01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", W = 2, L = 0, G = 14, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 36, H = 8, Er = 1, Hr = 1, Bb = 4, So = 15, Baopp = 186, Era = 75, Ibb = 0, Wp = 1, Hbp = 3, Bk = 0, Bfp = 50, Gf = 4, R = 4, Sh = 0, Sf = 0, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "rondohe01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "rondohe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 6, L = 4, G = 72, Gs = 0, Cg = 0, Sho = 0, Sv = 30, Ipouts = 210, H = 55, Er = 13, Hr = 4, Bb = 15, So = 69, Baopp = 212, Era = 167, Ibb = 2, Wp = 5, Hbp = 3, Bk = 1, Bfp = 281, Gf = 47, R = 19, Sh = 3, Sf = 1, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "rosscza01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "rosscza01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 2, L = 1, G = 33, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 80, H = 26, Er = 13, Hr = 5, Bb = 13, So = 29, Baopp = 252, Era = 439, Ibb = 0, Wp = 1, Hbp = 0, Bk = 0, Bfp = 118, Gf = 6, R = 13, Sh = 2, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "rossda01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "rossda01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 0, G = 2, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 6, H = 0, Er = 0, Hr = 0, Bb = 0, So = 0, Baopp = 0, Era = 0, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 6, Gf = 2, R = 0, Sh = 0, Sf = 0, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "russeja02") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "russeja02", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 0, L = 2, G = 49, Gs = 0, Cg = 0, Sho = 0, Sv = 1, Ipouts = 102, H = 42, Er = 20, Hr = 3, Bb = 9, So = 20, Baopp = 307, Era = 529, Ibb = 2, Wp = 0, Hbp = 0, Bk = 0, Bfp = 148, Gf = 8, R = 24, Sh = 1, Sf = 1, Gidp = 4 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "schlibr01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "schlibr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 1, L = 2, G = 10, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 22, H = 12, Er = 6, Hr = 2, Bb = 2, So = 4, Baopp = 364, Era = 736, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 35, Gf = 3, R = 6, Sh = 0, Sf = 0, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "soriara01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "soriara01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 2, L = 0, G = 6, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 17, H = 8, Er = 4, Hr = 2, Bb = 1, So = 4, Baopp = 333, Era = 635, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 25, Gf = 3, R = 4, Sh = 0, Sf = 0, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "stroppe01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "stroppe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 2, L = 6, G = 76, Gs = 0, Cg = 0, Sho = 0, Sv = 3, Ipouts = 204, H = 39, Er = 22, Hr = 5, Bb = 29, So = 81, Baopp = 167, Era = 291, Ibb = 6, Wp = 6, Hbp = 4, Bk = 0, Bfp = 270, Gf = 12, R = 24, Sh = 1, Sf = 3, Gidp = 4 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "wadats01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "wadats01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 1, L = 1, G = 8, Gs = 7, Cg = 0, Sho = 0, Sv = 0, Ipouts = 97, H = 30, Er = 13, Hr = 5, Bb = 11, So = 31, Baopp = 246, Era = 362, Ibb = 1, Wp = 1, Hbp = 1, Bk = 0, Bfp = 136, Gf = 0, R = 14, Sh = 1, Sf = 1, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "woodtr01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "woodtr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", W = 5, L = 4, G = 54, Gs = 9, Cg = 0, Sho = 0, Sv = 4, Ipouts = 302, H = 86, Er = 43, Hr = 11, Bb = 39, So = 118, Baopp = 229, Era = 384, Ibb = 5, Wp = 2, Hbp = 1, Bk = 0, Bfp = 419, Gf = 12, R = 48, Sh = 1, Sf = 2, Gidp = 5 });
			}
			dbContext.SaveChanges();
		}

		public static void BulkBattingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Batting.Count(m => m.PlayerId == "alcanar01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "alcanar01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 11, Ab = 26, R = 5, _2b = 0, _3b = 0, H = 2, Hr = 0, Rbi = 1, Sb = 1, Cs = 0, Bb = 5, So = 11, Ibb = 0, Hbp = 0, Sh = 1, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "arrieja01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "arrieja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 33, Ab = 79, R = 5, _2b = 1, _3b = 1, H = 12, Hr = 2, Rbi = 2, Sb = 0, Cs = 0, Bb = 1, So = 45, Ibb = 0, Hbp = 0, Sh = 3, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "baezja01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "baezja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 28, Ab = 76, R = 4, _2b = 6, _3b = 0, H = 22, Hr = 1, Rbi = 4, Sb = 1, Cs = 2, Bb = 4, So = 24, Ibb = 1, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "baxtemi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "baxtemi01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 34, Ab = 57, R = 6, _2b = 1, _3b = 0, H = 14, Hr = 0, Rbi = 2, Sb = 0, Cs = 0, Bb = 7, So = 14, Ibb = 1, Hbp = 2, Sh = 0, Sf = 0, Gidp = 3, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "beeleda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "beeleda01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 3, Ab = 3, R = 0, _2b = 1, _3b = 0, H = 1, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "berryqu01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "berryqu01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 8, Ab = 1, R = 1, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 2, Cs = 1, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "bryankr01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "bryankr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 151, Ab = 559, R = 87, _2b = 31, _3b = 5, H = 154, Hr = 26, Rbi = 99, Sb = 13, Cs = 4, Bb = 77, So = 199, Ibb = 0, Hbp = 9, Sh = 0, Sf = 5, Gidp = 7, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "cahiltr01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "cahiltr01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", G = 11, Ab = 2, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 1, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "castiwe01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "castiwe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 24, Ab = 43, R = 5, _2b = 2, _3b = 0, H = 7, Hr = 2, Rbi = 5, Sb = 0, Cs = 0, Bb = 3, So = 12, Ibb = 1, Hbp = 1, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "castrst01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "castrst01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 151, Ab = 547, R = 52, _2b = 23, _3b = 2, H = 145, Hr = 11, Rbi = 69, Sb = 5, Cs = 5, Bb = 21, So = 91, Ibb = 6, Hbp = 5, Sh = 1, Sf = 4, Gidp = 18, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "coghlch01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "coghlch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 148, Ab = 440, R = 64, _2b = 25, _3b = 6, H = 110, Hr = 16, Rbi = 41, Sb = 11, Cs = 2, Bb = 58, So = 94, Ibb = 6, Hbp = 3, Sh = 1, Sf = 1, Gidp = 8, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "cokeph01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "cokeph01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 16, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "denorch01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "denorch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 103, Ab = 212, R = 18, _2b = 11, _3b = 1, H = 57, Hr = 3, Rbi = 18, Sb = 0, Cs = 1, Bb = 15, So = 56, Ibb = 1, Hbp = 1, Sh = 2, Sf = 1, Gidp = 7, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "edwarca01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "edwarca01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 5, Ab = 1, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "fowlede01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "fowlede01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 156, Ab = 596, R = 102, _2b = 29, _3b = 8, H = 149, Hr = 17, Rbi = 46, Sb = 20, Cs = 7, Bb = 84, So = 154, Ibb = 1, Hbp = 5, Sh = 2, Sf = 3, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "germego01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "germego01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 6, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "grimmju01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "grimmju01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 62, Ab = 1, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hammeja01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hammeja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 32, Ab = 65, R = 6, _2b = 1, _3b = 0, H = 11, Hr = 0, Rbi = 4, Sb = 0, Cs = 0, Bb = 1, So = 18, Ibb = 0, Hbp = 0, Sh = 3, Sf = 1, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "harenda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "harenda01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", G = 11, Ab = 17, R = 1, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 3, So = 4, Ibb = 0, Hbp = 0, Sh = 2, Sf = 1, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hendrky01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hendrky01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 32, Ab = 60, R = 2, _2b = 1, _3b = 0, H = 3, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 1, So = 24, Ibb = 0, Hbp = 0, Sh = 3, Sf = 0, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "herrejo03") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "herrejo03", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 73, Ab = 126, R = 14, _2b = 5, _3b = 1, H = 29, Hr = 2, Rbi = 14, Sb = 3, Cs = 0, Bb = 2, So = 23, Ibb = 1, Hbp = 0, Sh = 4, Sf = 0, Gidp = 3, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hunteto02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hunteto02", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", G = 19, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "jacksau01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "jacksau01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", G = 29, Ab = 72, R = 10, _2b = 7, _3b = 0, H = 17, Hr = 1, Rbi = 10, Sb = 2, Cs = 1, Bb = 5, So = 19, Ibb = 0, Hbp = 2, Sh = 0, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "jacksed01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "jacksed01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 23, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lakeju01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lakeju01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 21, Ab = 58, R = 2, _2b = 4, _3b = 0, H = 13, Hr = 1, Rbi = 5, Sb = 4, Cs = 0, Bb = 4, So = 20, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lasteto01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lasteto01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 33, Ab = 67, R = 4, _2b = 6, _3b = 0, H = 18, Hr = 1, Rbi = 11, Sb = 2, Cs = 0, Bb = 5, So = 7, Ibb = 0, Hbp = 1, Sh = 0, Sf = 1, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lestejo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lestejo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 32, Ab = 62, R = 6, _2b = 0, _3b = 0, H = 4, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 3, So = 30, Ibb = 0, Hbp = 0, Sh = 6, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "medinyo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "medinyo01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", G = 5, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "montemi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "montemi01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 113, Ab = 347, R = 36, _2b = 11, _3b = 0, H = 86, Hr = 15, Rbi = 53, Sb = 1, Cs = 1, Bb = 49, So = 103, Ibb = 5, Hbp = 4, Sh = 0, Sf = 3, Gidp = 9, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "motteja01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "motteja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 57, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "oltmi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "oltmi01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 6, Ab = 15, R = 1, _2b = 0, _3b = 0, H = 2, Hr = 1, Rbi = 1, Sb = 0, Cs = 0, Bb = 0, So = 6, Ibb = 0, Hbp = 1, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "ramirne01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "ramirne01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 19, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "richacl01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "richacl01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 23, Ab = 14, R = 1, _2b = 2, _3b = 0, H = 2, Hr = 0, Rbi = 3, Sb = 0, Cs = 0, Bb = 1, So = 6, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rizzoan01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rizzoan01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 160, Ab = 586, R = 94, _2b = 38, _3b = 3, H = 163, Hr = 31, Rbi = 101, Sb = 17, Cs = 6, Bb = 78, So = 105, Ibb = 9, Hbp = 30, Sh = 0, Sf = 7, Gidp = 9, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "roachdo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "roachdo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 1, Ab = 1, R = 0, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rodnefe01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rodnefe01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", G = 14, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rondohe01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rondohe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 72, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rosscza01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rosscza01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 33, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rossda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rossda01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 72, Ab = 159, R = 6, _2b = 9, _3b = 0, H = 28, Hr = 1, Rbi = 9, Sb = 1, Cs = 0, Bb = 20, So = 61, Ibb = 7, Hbp = 0, Sh = 2, Sf = 1, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "russead02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "russead02", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 142, Ab = 475, R = 60, _2b = 29, _3b = 1, H = 115, Hr = 13, Rbi = 54, Sb = 4, Cs = 3, Bb = 42, So = 149, Ibb = 2, Hbp = 3, Sh = 1, Sf = 2, Gidp = 8, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "russeja02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "russeja02", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 49, Ab = 1, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "schlibr01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "schlibr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 10, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "schwaky01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "schwaky01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 69, Ab = 232, R = 52, _2b = 6, _3b = 1, H = 57, Hr = 16, Rbi = 43, Sb = 3, Cs = 3, Bb = 36, So = 77, Ibb = 1, Hbp = 4, Sh = 0, Sf = 1, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "solerjo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "solerjo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 101, Ab = 366, R = 39, _2b = 18, _3b = 1, H = 96, Hr = 10, Rbi = 47, Sb = 3, Cs = 1, Bb = 32, So = 121, Ibb = 5, Hbp = 3, Sh = 0, Sf = 3, Gidp = 9, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "soriara01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "soriara01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 6, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "stroppe01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "stroppe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 76, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "szczuma01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "szczuma01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 47, Ab = 72, R = 5, _2b = 5, _3b = 0, H = 16, Hr = 1, Rbi = 8, Sb = 2, Cs = 0, Bb = 6, So = 15, Ibb = 0, Hbp = 0, Sh = 1, Sf = 1, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "teagata01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "teagata01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 8, Ab = 15, R = 0, _2b = 0, _3b = 0, H = 3, Hr = 0, Rbi = 2, Sb = 0, Cs = 0, Bb = 0, So = 4, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "wadats01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "wadats01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 8, Ab = 8, R = 1, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 1, So = 5, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "woodtr01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "woodtr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", G = 60, Ab = 30, R = 0, _2b = 0, _3b = 0, H = 3, Hr = 0, Rbi = 2, Sb = 0, Cs = 0, Bb = 2, So = 16, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			dbContext.SaveChanges();
		}

		public static void BulkFieldingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Fielding.Count(m => m.PlayerId == "alcanar01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "alcanar01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "2B", G = 8, Gs = 6, InnOuts = 171, Po = 14, A = 18, E = 1, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "alcanar01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "alcanar01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "3B", G = 2, Gs = 1, InnOuts = 30, Po = 1, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "arrieja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "arrieja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 33, Gs = 33, InnOuts = 687, Po = 33, A = 49, E = 4, Dp = 5, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "baezja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "baezja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "1B", G = 1, Gs = 0, InnOuts = 3, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "baezja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "baezja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "2B", G = 17, Gs = 5, InnOuts = 179, Po = 13, A = 16, E = 1, Dp = 7, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "baezja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "baezja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "3B", G = 11, Gs = 6, InnOuts = 192, Po = 5, A = 19, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "baezja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "baezja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "SS", G = 8, Gs = 5, InnOuts = 135, Po = 7, A = 14, E = 0, Dp = 3, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "baxtemi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "baxtemi01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "1B", G = 2, Gs = 1, InnOuts = 33, Po = 16, A = 1, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "baxtemi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "baxtemi01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 11, Gs = 8, InnOuts = 238, Po = 15, A = 0, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "beeleda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "beeleda01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 3, Gs = 3, InnOuts = 25, Po = 1, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "berryqu01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "berryqu01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 5, Gs = 0, InnOuts = 27, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bryankr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bryankr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "1B", G = 1, Gs = 1, InnOuts = 18, Po = 2, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bryankr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bryankr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "3B", G = 144, Gs = 136, InnOuts = 3628, Po = 81, A = 249, E = 17, Dp = 21, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bryankr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bryankr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 19, Gs = 10, InnOuts = 294, Po = 20, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "cahiltr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "cahiltr01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", Pos = "P", G = 11, Gs = 0, InnOuts = 51, Po = 1, A = 4, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "castiwe01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "castiwe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "C", G = 9, Gs = 8, InnOuts = 192, Po = 56, A = 0, E = 2, Dp = 1, Pb = 1, Sb = 1, Cs = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "castrst01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "castrst01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "2B", G = 38, Gs = 29, InnOuts = 774, Po = 47, A = 85, E = 6, Dp = 20, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "castrst01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "castrst01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "SS", G = 109, Gs = 104, InnOuts = 2829, Po = 143, A = 323, E = 18, Dp = 58, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "coghlch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "coghlch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "1B", G = 5, Gs = 0, InnOuts = 39, Po = 19, A = 0, E = 0, Dp = 3, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "coghlch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "coghlch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "2B", G = 15, Gs = 11, InnOuts = 236, Po = 14, A = 20, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "coghlch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "coghlch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "3B", G = 3, Gs = 1, InnOuts = 30, Po = 1, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "coghlch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "coghlch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 119, Gs = 107, InnOuts = 2696, Po = 164, A = 9, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "cokeph01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "cokeph01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 16, Gs = 0, InnOuts = 30, Po = 2, A = 3, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "denorch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "denorch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 75, Gs = 45, InnOuts = 1293, Po = 88, A = 5, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "denorch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "denorch01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 1, Gs = 0, InnOuts = 1, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "edwarca01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "edwarca01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 5, Gs = 0, InnOuts = 14, Po = 1, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "fowlede01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "fowlede01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 152, Gs = 149, InnOuts = 3973, Po = 337, A = 5, E = 4, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "germego01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "germego01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 6, Gs = 0, InnOuts = 18, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "grimmju01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "grimmju01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 62, Gs = 0, InnOuts = 149, Po = 2, A = 0, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hammeja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hammeja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 31, Gs = 31, InnOuts = 512, Po = 8, A = 23, E = 2, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "harenda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "harenda01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", Pos = "P", G = 11, Gs = 11, InnOuts = 175, Po = 2, A = 3, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hendrky01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hendrky01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 32, Gs = 32, InnOuts = 540, Po = 17, A = 29, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "herrejo03") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "herrejo03", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "2B", G = 29, Gs = 16, InnOuts = 522, Po = 39, A = 46, E = 2, Dp = 11, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "herrejo03") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "herrejo03", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "3B", G = 16, Gs = 9, InnOuts = 264, Po = 6, A = 18, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "herrejo03") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "herrejo03", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "SS", G = 1, Gs = 0, InnOuts = 6, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hunteto02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hunteto02", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", Pos = "P", G = 19, Gs = 0, InnOuts = 47, Po = 2, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "jacksau01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "jacksau01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 28, Gs = 12, InnOuts = 449, Po = 31, A = 1, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "jacksed01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "jacksed01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 23, Gs = 0, InnOuts = 93, Po = 2, A = 4, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lakeju01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lakeju01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 15, Gs = 12, InnOuts = 343, Po = 21, A = 2, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lasteto01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lasteto01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "2B", G = 14, Gs = 11, InnOuts = 264, Po = 12, A = 33, E = 0, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lasteto01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lasteto01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "3B", G = 12, Gs = 6, InnOuts = 156, Po = 3, A = 3, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lestejo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lestejo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 32, Gs = 32, InnOuts = 615, Po = 10, A = 17, E = 3, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "medinyo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "medinyo01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", Pos = "P", G = 5, Gs = 0, InnOuts = 27, Po = 2, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "montemi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "montemi01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "C", G = 109, Gs = 90, InnOuts = 2475, Po = 820, A = 55, E = 12, Dp = 3, Pb = 3, Sb = 71, Cs = 18, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "motteja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "motteja01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 57, Gs = 0, InnOuts = 145, Po = 1, A = 5, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "oltmi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "oltmi01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "3B", G = 6, Gs = 3, InnOuts = 84, Po = 2, A = 5, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ramirne01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ramirne01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 19, Gs = 0, InnOuts = 42, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "richacl01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "richacl01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 23, Gs = 3, InnOuts = 127, Po = 5, A = 13, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rizzoan01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rizzoan01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "1B", G = 160, Gs = 160, InnOuts = 4291, Po = 1330, A = 126, E = 9, Dp = 102, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "roachdo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "roachdo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 1, Gs = 1, InnOuts = 10, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rodnefe01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rodnefe01", YearId = 2015, Stint = 2, TeamId = "CHN", LgId = "NL", Pos = "P", G = 14, Gs = 0, InnOuts = 36, Po = 1, A = 3, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rondohe01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rondohe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 72, Gs = 0, InnOuts = 210, Po = 8, A = 10, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rosscza01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rosscza01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 33, Gs = 0, InnOuts = 80, Po = 1, A = 5, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rossda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rossda01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "C", G = 59, Gs = 46, InnOuts = 1207, Po = 397, A = 36, E = 1, Dp = 3, Pb = 4, Sb = 49, Cs = 17, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rossda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rossda01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 2, Gs = 0, InnOuts = 6, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "russead02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "russead02", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "2B", G = 86, Gs = 84, InnOuts = 2238, Po = 151, A = 226, E = 9, Dp = 47, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "russead02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "russead02", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "SS", G = 61, Gs = 53, InnOuts = 1414, Po = 67, A = 139, E = 4, Dp = 29, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "russeja02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "russeja02", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 49, Gs = 0, InnOuts = 102, Po = 4, A = 6, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "schlibr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "schlibr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 10, Gs = 0, InnOuts = 22, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "schwaky01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "schwaky01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "C", G = 21, Gs = 15, InnOuts = 408, Po = 110, A = 7, E = 4, Dp = 1, Pb = 2, Sb = 14, Cs = 3, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "schwaky01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "schwaky01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 43, Gs = 38, InnOuts = 929, Po = 45, A = 1, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "solerjo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "solerjo01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 95, Gs = 93, InnOuts = 2477, Po = 144, A = 4, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "soriara01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "soriara01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 6, Gs = 0, InnOuts = 17, Po = 0, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "stroppe01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "stroppe01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 76, Gs = 0, InnOuts = 204, Po = 2, A = 6, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "szczuma01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "szczuma01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "OF", G = 33, Gs = 12, InnOuts = 433, Po = 24, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "teagata01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "teagata01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "C", G = 6, Gs = 3, InnOuts = 102, Po = 30, A = 3, E = 0, Dp = 0, Pb = 0, Sb = 2, Cs = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "wadats01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "wadats01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 8, Gs = 7, InnOuts = 97, Po = 1, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "woodtr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "woodtr01", YearId = 2015, Stint = 1, TeamId = "CHN", LgId = "NL", Pos = "P", G = 54, Gs = 9, InnOuts = 302, Po = 3, A = 7, E = 0, Dp = 1, });
			}
			dbContext.SaveChanges();
		}
	}
}

