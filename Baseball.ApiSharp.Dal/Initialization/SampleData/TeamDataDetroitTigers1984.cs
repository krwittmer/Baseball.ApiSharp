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
	public partial class TeamDataDetroitTigers1984
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
			if (dbContext.People.Count(m => m.PlayerId == "abbotgl01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "abbotgl01", Bats = "R", Throws = "R", NameFirst = "Glenn", NameLast = "Abbott", BbrefId = "abbotgl01", BirthCity = "Little Rock", BirthDay = 16, BirthCountry = "USA", BirthState = "AR", BirthMonth = 2, BirthYear = 1951, Debut = "1973-07-29 00:00:00", FinalGame = "1984-08-08 00:00:00", Height = 78, Weight = 200, RetroId = "abbog001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "bairdo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "bairdo01", Bats = "R", Throws = "R", NameFirst = "Doug", NameLast = "Bair", BbrefId = "bairdo01", BirthCity = "Defiance", BirthDay = 22, BirthCountry = "USA", BirthState = "OH", BirthMonth = 8, BirthYear = 1949, Debut = "1976-09-13 00:00:00", FinalGame = "1990-10-03 00:00:00", Height = 72, Weight = 170, RetroId = "baird001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "berenju01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "berenju01", Bats = "R", Throws = "R", NameFirst = "Juan", NameLast = "Berenguer", BbrefId = "berenju01", BirthCity = "Aguadulce", BirthDay = 30, BirthCountry = "Panama", BirthState = "Cocle", BirthMonth = 11, BirthYear = 1954, Debut = "1978-08-17 00:00:00", FinalGame = "1992-10-04 00:00:00", Height = 71, Weight = 186, RetroId = "berej001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hernawi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hernawi01", Bats = "L", Throws = "L", NameFirst = "Willie", NameLast = "Hernandez", BbrefId = "hernawi01", BirthCity = "Aguada", BirthDay = 14, BirthCountry = "P.R.", BirthMonth = 11, BirthYear = 1954, Debut = "1977-04-09 00:00:00", FinalGame = "1989-08-18 00:00:00", Height = 75, Weight = 180, RetroId = "hernw001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lopezau01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lopezau01", Bats = "R", Throws = "R", NameFirst = "Aurelio", NameLast = "Lopez", BbrefId = "lopezau01", BirthCity = "Tecamachalco", BirthDay = 21, BirthCountry = "Mexico", BirthState = "Puebla", BirthMonth = 9, BirthYear = 1948, DeathMonth = 9, DeathDay = 22, DeathCountry = "Mexico", DeathState = "San Luis Potosi", DeathCity = "Matehuala", Debut = "1974-09-01 00:00:00", FinalGame = "1987-06-17 00:00:00", Height = 72, Weight = 185, RetroId = "lopea001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "masonro01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "masonro01", Bats = "R", Throws = "R", NameFirst = "Roger", NameLast = "Mason", BbrefId = "masonro01", BirthCity = "Bellaire", BirthDay = 18, BirthCountry = "USA", BirthState = "MI", BirthMonth = 9, BirthYear = 1957, Debut = "1984-09-04 00:00:00", FinalGame = "1994-08-11 00:00:00", Height = 78, Weight = 215, RetroId = "masor001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "mongesi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "mongesi01", Bats = "B", Throws = "L", NameFirst = "Sid", NameLast = "Monge", BbrefId = "mongesi01", BirthCity = "Agua Prieta", BirthDay = 11, BirthCountry = "Mexico", BirthState = "Sonora", BirthMonth = 4, BirthYear = 1951, Debut = "1975-09-12 00:00:00", FinalGame = "1984-09-30 00:00:00", Height = 74, Weight = 185, RetroId = "mongs001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "morrija02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "morrija02", Bats = "R", Throws = "R", NameFirst = "Jack", NameLast = "Morris", BbrefId = "morrija02", BirthCity = "St. Paul", BirthDay = 16, BirthCountry = "USA", BirthState = "MN", BirthMonth = 5, BirthYear = 1955, Debut = "1977-07-26 00:00:00", FinalGame = "1994-08-07 00:00:00", Height = 75, Weight = 195, RetroId = "morrj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "onealra01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "onealra01", Bats = "R", Throws = "R", NameFirst = "Randy", NameLast = "O'Neal", BbrefId = "o'neara01", BirthCity = "Ashland", BirthDay = 30, BirthCountry = "USA", BirthState = "KY", BirthMonth = 8, BirthYear = 1960, Debut = "1984-09-12 00:00:00", FinalGame = "1990-10-02 00:00:00", Height = 74, Weight = 195, RetroId = "onear001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "petryda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "petryda01", Bats = "R", Throws = "R", NameFirst = "Dan", NameLast = "Petry", BbrefId = "petryda01", BirthCity = "Palo Alto", BirthDay = 13, BirthCountry = "USA", BirthState = "CA", BirthMonth = 11, BirthYear = 1958, Debut = "1979-07-08 00:00:00", FinalGame = "1991-10-05 00:00:00", Height = 76, Weight = 185, RetroId = "petrd001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rozemda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rozemda01", Bats = "R", Throws = "R", NameFirst = "Dave", NameLast = "Rozema", BbrefId = "rozemda01", BirthCity = "Grand Rapids", BirthDay = 5, BirthCountry = "USA", BirthState = "MI", BirthMonth = 8, BirthYear = 1956, Debut = "1977-04-11 00:00:00", FinalGame = "1986-04-30 00:00:00", Height = 76, Weight = 185, RetroId = "rozed001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "scherbi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "scherbi01", Bats = "L", Throws = "L", NameFirst = "Bill", NameLast = "Scherrer", BbrefId = "scherbi01", BirthCity = "Tonawanda", BirthDay = 20, BirthCountry = "USA", BirthState = "NY", BirthMonth = 1, BirthYear = 1958, Debut = "1982-09-07 00:00:00", FinalGame = "1988-07-28 00:00:00", Height = 76, Weight = 170, RetroId = "scheb001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "wilcomi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "wilcomi01", Bats = "R", Throws = "R", NameFirst = "Milt", NameLast = "Wilcox", BbrefId = "wilcomi01", BirthCity = "Honolulu", BirthDay = 20, BirthCountry = "USA", BirthState = "HI", BirthMonth = 4, BirthYear = 1950, Debut = "1970-09-05 00:00:00", FinalGame = "1986-06-12 00:00:00", Height = 74, Weight = 185, RetroId = "wilcm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "willica01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "willica01", Bats = "L", Throws = "R", NameFirst = "Carl", NameLast = "Willis", BbrefId = "willica01", BirthCity = "Danville", BirthDay = 28, BirthCountry = "USA", BirthState = "VA", BirthMonth = 12, BirthYear = 1960, Debut = "1984-06-09 00:00:00", FinalGame = "1995-05-03 00:00:00", Height = 76, Weight = 210, RetroId = "willc001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "allenro02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "allenro02", Bats = "R", Throws = "R", NameFirst = "Rod", NameLast = "Allen", BbrefId = "allenro02", BirthCity = "Los Angeles", BirthDay = 5, BirthCountry = "USA", BirthState = "CA", BirthMonth = 10, BirthYear = 1959, Debut = "1983-04-07 00:00:00", FinalGame = "1988-10-02 00:00:00", Height = 73, Weight = 185, RetroId = "aller001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "bakerdo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "bakerdo01", Bats = "B", Throws = "R", NameFirst = "Doug", NameLast = "Baker", BbrefId = "bakerdo01", BirthCity = "Fullerton", BirthDay = 3, BirthCountry = "USA", BirthState = "CA", BirthMonth = 4, BirthYear = 1961, Debut = "1984-07-02 00:00:00", FinalGame = "1990-04-12 00:00:00", Height = 69, Weight = 165, RetroId = "baked001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "bergmda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "bergmda01", Bats = "L", Throws = "L", NameFirst = "Dave", NameLast = "Bergman", BbrefId = "bergmda01", BirthCity = "Evanston", BirthDay = 6, BirthCountry = "USA", BirthState = "IL", BirthMonth = 6, BirthYear = 1953, DeathMonth = 2, DeathDay = 2, DeathCountry = "USA", DeathState = "MI", DeathCity = "Detroit", Debut = "1975-08-26 00:00:00", FinalGame = "1992-10-04 00:00:00", Height = 73, Weight = 185, RetroId = "bergd001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "brookto01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "brookto01", Bats = "R", Throws = "R", NameFirst = "Tom", NameLast = "Brookens", BbrefId = "brookto01", BirthCity = "Chambersburg", BirthDay = 10, BirthCountry = "USA", BirthState = "PA", BirthMonth = 8, BirthYear = 1953, Debut = "1979-07-10 00:00:00", FinalGame = "1990-09-30 00:00:00", Height = 70, Weight = 165, RetroId = "broot001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "castima02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "castima02", Bats = "R", Throws = "R", NameFirst = "Marty", NameLast = "Castillo", BbrefId = "castima02", BirthCity = "Long Beach", BirthDay = 16, BirthCountry = "USA", BirthState = "CA", BirthMonth = 1, BirthYear = 1957, Debut = "1981-08-19 00:00:00", FinalGame = "1985-10-05 00:00:00", Height = 73, Weight = 190, RetroId = "castm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "earlsc01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "earlsc01", Bats = "R", Throws = "R", NameFirst = "Scott", NameLast = "Earl", BbrefId = "earlsc01", BirthCity = "Seymour", BirthDay = 18, BirthCountry = "USA", BirthState = "IN", BirthMonth = 9, BirthYear = 1960, Debut = "1984-09-10 00:00:00", FinalGame = "1984-09-30 00:00:00", Height = 71, Weight = 165, RetroId = "earls001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "evansda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "evansda01", Bats = "L", Throws = "R", NameFirst = "Darrell", NameLast = "Evans", BbrefId = "evansda01", BirthCity = "Pasadena", BirthDay = 26, BirthCountry = "USA", BirthState = "CA", BirthMonth = 5, BirthYear = 1947, Debut = "1969-04-20 00:00:00", FinalGame = "1989-10-01 00:00:00", Height = 74, Weight = 200, RetroId = "evand001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "garbeba01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "garbeba01", Bats = "R", Throws = "R", NameFirst = "Barbaro", NameLast = "Garbey", BbrefId = "garbeba01", BirthCity = "Santiago de Cuba", BirthDay = 4, BirthCountry = "Cuba", BirthState = "Santiago de Cuba", BirthMonth = 12, BirthYear = 1956, Debut = "1984-04-03 00:00:00", FinalGame = "1988-10-02 00:00:00", Height = 70, Weight = 170, RetroId = "garbb001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "gibsoki01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "gibsoki01", Bats = "L", Throws = "L", NameFirst = "Kirk", NameLast = "Gibson", BbrefId = "gibsoki01", BirthCity = "Pontiac", BirthDay = 28, BirthCountry = "USA", BirthState = "MI", BirthMonth = 5, BirthYear = 1957, Debut = "1979-09-08 00:00:00", FinalGame = "1995-08-10 00:00:00", Height = 75, Weight = 215, RetroId = "gibsk001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "grubbjo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "grubbjo01", Bats = "L", Throws = "R", NameFirst = "Johnny", NameLast = "Grubb", BbrefId = "grubbjo01", BirthCity = "Richmond", BirthDay = 4, BirthCountry = "USA", BirthState = "VA", BirthMonth = 8, BirthYear = 1948, Debut = "1972-09-10 00:00:00", FinalGame = "1987-09-28 00:00:00", Height = 75, Weight = 175, RetroId = "grubj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "herndla01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "herndla01", Bats = "R", Throws = "R", NameFirst = "Larry", NameLast = "Herndon", BbrefId = "herndla01", BirthCity = "Sunflower", BirthDay = 3, BirthCountry = "USA", BirthState = "MS", BirthMonth = 11, BirthYear = 1953, Debut = "1974-09-04 00:00:00", FinalGame = "1988-10-02 00:00:00", Height = 75, Weight = 190, RetroId = "hernl001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "johnsho01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "johnsho01", Bats = "B", Throws = "R", NameFirst = "Howard", NameLast = "Johnson", BbrefId = "johnsho01", BirthCity = "Clearwater", BirthDay = 29, BirthCountry = "USA", BirthState = "FL", BirthMonth = 11, BirthYear = 1960, Debut = "1982-04-14 00:00:00", FinalGame = "1995-10-01 00:00:00", Height = 71, Weight = 178, RetroId = "johnh001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "jonesru01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "jonesru01", Bats = "L", Throws = "L", NameFirst = "Ruppert", NameLast = "Jones", BbrefId = "jonesru01", BirthCity = "Dallas", BirthDay = 12, BirthCountry = "USA", BirthState = "TX", BirthMonth = 3, BirthYear = 1955, Debut = "1976-08-01 00:00:00", FinalGame = "1987-10-04 00:00:00", Height = 70, Weight = 170, RetroId = "joner002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "kuntzru01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "kuntzru01", Bats = "R", Throws = "R", NameFirst = "Rusty", NameLast = "Kuntz", BbrefId = "kuntzru01", BirthCity = "Orange", BirthDay = 4, BirthCountry = "USA", BirthState = "CA", BirthMonth = 2, BirthYear = 1955, Debut = "1979-09-01 00:00:00", FinalGame = "1985-04-24 00:00:00", Height = 75, Weight = 190, RetroId = "kuntr001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lagami01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lagami01", Bats = "L", Throws = "L", NameFirst = "Mike", NameLast = "Laga", BbrefId = "lagami01", BirthCity = "Ridgewood", BirthDay = 14, BirthCountry = "USA", BirthState = "NJ", BirthMonth = 6, BirthYear = 1960, Debut = "1982-09-01 00:00:00", FinalGame = "1990-10-03 00:00:00", Height = 74, Weight = 210, RetroId = "lagam001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lemonch01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lemonch01", Bats = "R", Throws = "R", NameFirst = "Chet", NameLast = "Lemon", BbrefId = "lemonch01", BirthCity = "Jackson", BirthDay = 12, BirthCountry = "USA", BirthState = "MS", BirthMonth = 2, BirthYear = 1955, Debut = "1975-09-09 00:00:00", FinalGame = "1990-10-03 00:00:00", Height = 72, Weight = 190, RetroId = "lemoc001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lowrydw01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lowrydw01", Bats = "L", Throws = "R", NameFirst = "Dwight", NameLast = "Lowry", BbrefId = "lowrydw01", BirthCity = "Lumberton", BirthDay = 23, BirthCountry = "USA", BirthState = "NC", BirthMonth = 10, BirthYear = 1957, DeathMonth = 7, DeathDay = 10, DeathCountry = "USA", DeathState = "NY", DeathCity = "Jamestown", Debut = "1984-04-03 00:00:00", FinalGame = "1988-04-23 00:00:00", Height = 75, Weight = 210, RetroId = "lowrd001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "parrila02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "parrila02", Bats = "R", Throws = "R", NameFirst = "Lance", NameLast = "Parrish", BbrefId = "parrila02", BirthCity = "Clairton", BirthDay = 15, BirthCountry = "USA", BirthState = "PA", BirthMonth = 6, BirthYear = 1956, Debut = "1977-09-05 00:00:00", FinalGame = "1995-09-23 00:00:00", Height = 75, Weight = 210, RetroId = "parrl001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "simmone01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "simmone01", Bats = "B", Throws = "R", NameFirst = "Nelson", NameLast = "Simmons", BbrefId = "simmone01", BirthCity = "Washington", BirthDay = 27, BirthCountry = "USA", BirthState = "DC", BirthMonth = 6, BirthYear = 1963, Debut = "1984-09-04 00:00:00", FinalGame = "1987-05-08 00:00:00", Height = 73, Weight = 185, RetroId = "simmn001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "trammal01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "trammal01", Bats = "R", Throws = "R", NameFirst = "Alan", NameLast = "Trammell", BbrefId = "trammal01", BirthCity = "Garden Grove", BirthDay = 21, BirthCountry = "USA", BirthState = "CA", BirthMonth = 2, BirthYear = 1958, Debut = "1977-09-09 00:00:00", FinalGame = "1996-09-29 00:00:00", Height = 72, Weight = 165, RetroId = "trama001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "whitalo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "whitalo01", Bats = "L", Throws = "R", NameFirst = "Lou", NameLast = "Whitaker", BbrefId = "whitalo01", BirthCity = "Brooklyn", BirthDay = 12, BirthCountry = "USA", BirthState = "NY", BirthMonth = 5, BirthYear = 1957, Debut = "1977-09-09 00:00:00", FinalGame = "1995-10-01 00:00:00", Height = 71, Weight = 160, RetroId = "whitl001" });
			}
			dbContext.SaveChanges();
		}

		public static void BulkPitchingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Pitching.Count(m => m.PlayerId == "abbotgl01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "abbotgl01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 3, L = 4, G = 13, Gs = 8, Cg = 1, Sho = 0, Sv = 0, Ipouts = 132, H = 62, Er = 29, Hr = 9, Bb = 8, So = 8, Baopp = 326, Era = 593, Ibb = 1, Wp = 1, Hbp = 2, Bk = 0, Bfp = 205, Gf = 2, R = 39, Sh = 3, Sf = 2, Gidp = 5 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "bairdo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "bairdo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 5, L = 3, G = 47, Gs = 1, Cg = 0, Sho = 0, Sv = 4, Ipouts = 281, H = 82, Er = 39, Hr = 10, Bb = 36, So = 57, Baopp = 238, Era = 375, Ibb = 2, Wp = 3, Hbp = 0, Bk = 0, Bfp = 388, Gf = 12, R = 42, Sh = 3, Sf = 4, Gidp = 12 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "berenju01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "berenju01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 11, L = 10, G = 31, Gs = 27, Cg = 2, Sho = 1, Sv = 0, Ipouts = 505, H = 146, Er = 65, Hr = 14, Bb = 79, So = 118, Baopp = 233, Era = 348, Ibb = 2, Wp = 7, Hbp = 5, Bk = 2, Bfp = 720, Gf = 0, R = 75, Sh = 2, Sf = 6, Gidp = 14 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hernawi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hernawi01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 9, L = 3, G = 80, Gs = 0, Cg = 0, Sho = 0, Sv = 32, Ipouts = 421, H = 96, Er = 30, Hr = 6, Bb = 36, So = 112, Baopp = 194, Era = 192, Ibb = 8, Wp = 2, Hbp = 4, Bk = 0, Bfp = 548, Gf = 68, R = 30, Sh = 9, Sf = 3, Gidp = 9 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "lopezau01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "lopezau01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 10, L = 1, G = 71, Gs = 0, Cg = 0, Sho = 0, Sv = 14, Ipouts = 413, H = 109, Er = 45, Hr = 16, Bb = 52, So = 94, Baopp = 221, Era = 294, Ibb = 6, Wp = 3, Hbp = 2, Bk = 1, Bfp = 559, Gf = 41, R = 51, Sh = 6, Sf = 6, Gidp = 9 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "masonro01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "masonro01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 1, L = 1, G = 5, Gs = 2, Cg = 0, Sho = 0, Sv = 1, Ipouts = 66, H = 23, Er = 11, Hr = 1, Bb = 10, So = 15, Baopp = 271, Era = 450, Ibb = 0, Wp = 2, Hbp = 0, Bk = 0, Bfp = 97, Gf = 2, R = 11, Sh = 0, Sf = 2, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "mongesi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "mongesi01", YearId = 1984, Stint = 2, TeamId = "DET", LgId = "AL", W = 1, L = 0, G = 19, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 108, H = 40, Er = 17, Hr = 5, Bb = 12, So = 19, Baopp = 282, Era = 425, Ibb = 0, Wp = 1, Hbp = 2, Bk = 0, Bfp = 159, Gf = 6, R = 21, Sh = 0, Sf = 3, Gidp = 5 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "morrija02") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "morrija02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 19, L = 11, G = 35, Gs = 35, Cg = 9, Sho = 1, Sv = 0, Ipouts = 721, H = 221, Er = 96, Hr = 20, Bb = 87, So = 148, Baopp = 241, Era = 360, Ibb = 7, Wp = 14, Hbp = 2, Bk = 0, Bfp = 1015, Gf = 0, R = 108, Sh = 5, Sf = 3, Gidp = 16 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "onealra01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "onealra01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 2, L = 1, G = 4, Gs = 3, Cg = 0, Sho = 0, Sv = 0, Ipouts = 56, H = 16, Er = 7, Hr = 0, Bb = 6, So = 12, Baopp = 222, Era = 338, Ibb = 0, Wp = 1, Hbp = 0, Bk = 0, Bfp = 78, Gf = 0, R = 7, Sh = 0, Sf = 0, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "petryda01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "petryda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 18, L = 8, G = 35, Gs = 35, Cg = 7, Sho = 2, Sv = 0, Ipouts = 700, H = 231, Er = 84, Hr = 21, Bb = 66, So = 144, Baopp = 259, Era = 324, Ibb = 4, Wp = 7, Hbp = 3, Bk = 0, Bfp = 968, Gf = 0, R = 94, Sh = 5, Sf = 2, Gidp = 15 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "rozemda01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "rozemda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 7, L = 6, G = 29, Gs = 16, Cg = 0, Sho = 0, Sv = 0, Ipouts = 303, H = 110, Er = 42, Hr = 13, Bb = 18, So = 48, Baopp = 274, Era = 374, Ibb = 3, Wp = 3, Hbp = 2, Bk = 1, Bfp = 425, Gf = 6, R = 49, Sh = 2, Sf = 2, Gidp = 16 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "scherbi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "scherbi01", YearId = 1984, Stint = 2, TeamId = "DET", LgId = "AL", W = 1, L = 0, G = 18, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 57, H = 14, Er = 4, Hr = 1, Bb = 8, So = 16, Baopp = 206, Era = 189, Ibb = 1, Wp = 0, Hbp = 0, Bk = 0, Bfp = 77, Gf = 2, R = 4, Sh = 1, Sf = 0, Gidp = 3 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "wilcomi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "wilcomi01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 17, L = 8, G = 33, Gs = 33, Cg = 0, Sho = 0, Sv = 0, Ipouts = 581, H = 183, Er = 86, Hr = 13, Bb = 66, So = 119, Baopp = 252, Era = 400, Ibb = 5, Wp = 3, Hbp = 8, Bk = 2, Bfp = 814, Gf = 0, R = 99, Sh = 5, Sf = 9, Gidp = 23 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "willica01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "willica01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", W = 0, L = 2, G = 10, Gs = 2, Cg = 0, Sho = 0, Sv = 0, Ipouts = 48, H = 25, Er = 13, Hr = 1, Bb = 5, So = 4, Baopp = 362, Era = 731, Ibb = 2, Wp = 0, Hbp = 0, Bk = 0, Bfp = 74, Gf = 4, R = 13, Sh = 0, Sf = 0, Gidp = 4 });
			}
			dbContext.SaveChanges();
		}

		public static void BulkBattingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Batting.Count(m => m.PlayerId == "abbotgl01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "abbotgl01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 13, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "allenro02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "allenro02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 15, Ab = 27, R = 6, _2b = 1, _3b = 0, H = 8, Hr = 0, Rbi = 3, Sb = 1, Cs = 0, Bb = 2, So = 8, Ibb = 0, Hbp = 1, Sh = 1, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "bairdo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "bairdo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 47, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "bakerdo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "bakerdo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 43, Ab = 108, R = 15, _2b = 4, _3b = 1, H = 20, Hr = 0, Rbi = 12, Sb = 3, Cs = 0, Bb = 7, So = 22, Ibb = 0, Hbp = 1, Sh = 2, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "berenju01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "berenju01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 31, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "bergmda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "bergmda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 120, Ab = 271, R = 42, _2b = 8, _3b = 5, H = 74, Hr = 7, Rbi = 44, Sb = 3, Cs = 4, Bb = 33, So = 40, Ibb = 2, Hbp = 3, Sh = 3, Sf = 6, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "brookto01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "brookto01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 113, Ab = 224, R = 32, _2b = 11, _3b = 4, H = 55, Hr = 5, Rbi = 26, Sb = 6, Cs = 6, Bb = 19, So = 33, Ibb = 0, Hbp = 1, Sh = 8, Sf = 1, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "castima02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "castima02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 70, Ab = 141, R = 16, _2b = 5, _3b = 2, H = 33, Hr = 4, Rbi = 17, Sb = 1, Cs = 0, Bb = 10, So = 33, Ibb = 0, Hbp = 0, Sh = 4, Sf = 0, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "earlsc01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "earlsc01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 14, Ab = 35, R = 3, _2b = 0, _3b = 1, H = 4, Hr = 0, Rbi = 1, Sb = 1, Cs = 0, Bb = 0, So = 9, Ibb = 0, Hbp = 0, Sh = 2, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "evansda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "evansda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 131, Ab = 401, R = 60, _2b = 11, _3b = 1, H = 93, Hr = 16, Rbi = 63, Sb = 2, Cs = 2, Bb = 77, So = 70, Ibb = 10, Hbp = 0, Sh = 1, Sf = 4, Gidp = 7, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "garbeba01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "garbeba01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 110, Ab = 327, R = 45, _2b = 17, _3b = 1, H = 94, Hr = 5, Rbi = 52, Sb = 6, Cs = 7, Bb = 17, So = 35, Ibb = 2, Hbp = 2, Sh = 0, Sf = 2, Gidp = 8, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "gibsoki01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "gibsoki01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 149, Ab = 531, R = 92, _2b = 23, _3b = 10, H = 150, Hr = 27, Rbi = 91, Sb = 29, Cs = 9, Bb = 63, So = 103, Ibb = 6, Hbp = 8, Sh = 3, Sf = 6, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "grubbjo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "grubbjo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 86, Ab = 176, R = 25, _2b = 5, _3b = 0, H = 47, Hr = 8, Rbi = 17, Sb = 1, Cs = 0, Bb = 36, So = 36, Ibb = 5, Hbp = 2, Sh = 1, Sf = 1, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hernawi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hernawi01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 80, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "herndla01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "herndla01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 125, Ab = 407, R = 52, _2b = 18, _3b = 5, H = 114, Hr = 7, Rbi = 43, Sb = 6, Cs = 2, Bb = 32, So = 63, Ibb = 1, Hbp = 2, Sh = 1, Sf = 3, Gidp = 8, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "johnsho01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "johnsho01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 116, Ab = 355, R = 43, _2b = 14, _3b = 1, H = 88, Hr = 12, Rbi = 50, Sb = 10, Cs = 6, Bb = 40, So = 67, Ibb = 1, Hbp = 1, Sh = 4, Sf = 2, Gidp = 6, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "jonesru01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "jonesru01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 79, Ab = 215, R = 26, _2b = 12, _3b = 1, H = 61, Hr = 12, Rbi = 37, Sb = 2, Cs = 4, Bb = 21, So = 47, Ibb = 0, Hbp = 0, Sh = 0, Sf = 1, Gidp = 5, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "kuntzru01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "kuntzru01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 84, Ab = 140, R = 32, _2b = 12, _3b = 0, H = 40, Hr = 2, Rbi = 22, Sb = 2, Cs = 2, Bb = 25, So = 28, Ibb = 1, Hbp = 1, Sh = 0, Sf = 2, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lagami01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lagami01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 9, Ab = 11, R = 1, _2b = 0, _3b = 0, H = 6, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 1, So = 2, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lemonch01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lemonch01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 141, Ab = 509, R = 77, _2b = 34, _3b = 6, H = 146, Hr = 20, Rbi = 76, Sb = 5, Cs = 5, Bb = 51, So = 83, Ibb = 9, Hbp = 7, Sh = 2, Sf = 4, Gidp = 16, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lopezau01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lopezau01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 71, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lowrydw01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lowrydw01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 32, Ab = 45, R = 8, _2b = 2, _3b = 0, H = 11, Hr = 2, Rbi = 7, Sb = 0, Cs = 0, Bb = 3, So = 11, Ibb = 0, Hbp = 0, Sh = 4, Sf = 0, Gidp = 3, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "masonro01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "masonro01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 5, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "mongesi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "mongesi01", YearId = 1984, Stint = 2, TeamId = "DET", LgId = "AL", G = 19, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "morrija02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "morrija02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 35, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "onealra01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "onealra01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 4, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "parrila02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "parrila02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 147, Ab = 578, R = 75, _2b = 16, _3b = 2, H = 137, Hr = 33, Rbi = 98, Sb = 2, Cs = 3, Bb = 41, So = 120, Ibb = 6, Hbp = 2, Sh = 2, Sf = 6, Gidp = 12, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "petryda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "petryda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 35, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rozemda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rozemda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 29, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "scherbi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "scherbi01", YearId = 1984, Stint = 2, TeamId = "DET", LgId = "AL", G = 18, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "simmone01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "simmone01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 9, Ab = 30, R = 4, _2b = 2, _3b = 0, H = 13, Hr = 0, Rbi = 3, Sb = 1, Cs = 0, Bb = 2, So = 5, Ibb = 1, Hbp = 0, Sh = 0, Sf = 0, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "trammal01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "trammal01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 139, Ab = 555, R = 85, _2b = 34, _3b = 5, H = 174, Hr = 14, Rbi = 69, Sb = 19, Cs = 13, Bb = 60, So = 63, Ibb = 2, Hbp = 3, Sh = 6, Sf = 2, Gidp = 8, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "whitalo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "whitalo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 143, Ab = 558, R = 90, _2b = 25, _3b = 1, H = 161, Hr = 13, Rbi = 56, Sb = 6, Cs = 5, Bb = 62, So = 63, Ibb = 5, Hbp = 0, Sh = 4, Sf = 5, Gidp = 9, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "wilcomi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "wilcomi01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 33, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "willica01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "willica01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", G = 10, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			dbContext.SaveChanges();
		}

		public static void BulkFieldingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Fielding.Count(m => m.PlayerId == "abbotgl01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "abbotgl01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 13, Gs = 8, InnOuts = 132, Po = 4, A = 8, E = 2, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "allenro02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "allenro02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 2, Gs = 0, InnOuts = 6, Po = 2, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bairdo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bairdo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 47, Gs = 1, InnOuts = 281, Po = 12, A = 11, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bakerdo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bakerdo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "2B", G = 5, Gs = 4, InnOuts = 118, Po = 10, A = 7, E = 1, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bakerdo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bakerdo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "SS", G = 39, Gs = 27, InnOuts = 765, Po = 46, A = 79, E = 4, Dp = 18, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "berenju01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "berenju01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 31, Gs = 27, InnOuts = 505, Po = 11, A = 15, E = 2, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bergmda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bergmda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "1B", G = 114, Gs = 67, InnOuts = 2037, Po = 657, A = 75, E = 8, Dp = 63, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bergmda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bergmda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 2, Gs = 1, InnOuts = 21, Po = 1, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "brookto01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "brookto01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "2B", G = 26, Gs = 19, InnOuts = 437, Po = 28, A = 48, E = 4, Dp = 14, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "brookto01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "brookto01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "3B", G = 68, Gs = 22, InnOuts = 891, Po = 32, A = 63, E = 3, Dp = 10, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "brookto01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "brookto01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "SS", G = 28, Gs = 22, InnOuts = 576, Po = 38, A = 76, E = 5, Dp = 11, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "castima02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "castima02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "3B", G = 33, Gs = 14, InnOuts = 412, Po = 12, A = 26, E = 2, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "castima02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "castima02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "C", G = 36, Gs = 28, InnOuts = 762, Po = 149, A = 11, E = 5, Dp = 2, Pb = 5, Sb = 16, Cs = 10, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "earlsc01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "earlsc01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "2B", G = 14, Gs = 8, InnOuts = 234, Po = 23, A = 24, E = 2, Dp = 9, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "evansda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "evansda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "1B", G = 47, Gs = 43, InnOuts = 1076, Po = 324, A = 44, E = 1, Dp = 33, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "evansda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "evansda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "3B", G = 19, Gs = 14, InnOuts = 327, Po = 7, A = 18, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "garbeba01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "garbeba01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "1B", G = 65, Gs = 51, InnOuts = 1237, Po = 391, A = 42, E = 5, Dp = 50, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "garbeba01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "garbeba01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "2B", G = 3, Gs = 0, InnOuts = 18, Po = 2, A = 2, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "garbeba01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "garbeba01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "3B", G = 20, Gs = 14, InnOuts = 336, Po = 7, A = 14, E = 7, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "garbeba01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "garbeba01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 10, Gs = 2, InnOuts = 114, Po = 11, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "gibsoki01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "gibsoki01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 139, Gs = 128, InnOuts = 3534, Po = 245, A = 4, E = 12, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "grubbjo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "grubbjo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 36, Gs = 25, InnOuts = 584, Po = 47, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hernawi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hernawi01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 80, Gs = 0, InnOuts = 421, Po = 5, A = 14, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "herndla01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "herndla01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 117, Gs = 98, InnOuts = 2689, Po = 199, A = 7, E = 3, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "johnsho01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "johnsho01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "1B", G = 1, Gs = 0, InnOuts = 9, Po = 1, A = 0, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "johnsho01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "johnsho01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "3B", G = 108, Gs = 98, InnOuts = 2426, Po = 58, A = 143, E = 12, Dp = 16, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "johnsho01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "johnsho01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 1, Gs = 0, InnOuts = 12, Po = 1, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "johnsho01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "johnsho01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "SS", G = 9, Gs = 1, InnOuts = 72, Po = 3, A = 7, E = 2, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "jonesru01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "jonesru01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 73, Gs = 58, InnOuts = 1454, Po = 150, A = 4, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "kuntzru01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "kuntzru01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 67, Gs = 35, InnOuts = 1028, Po = 74, A = 2, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lagami01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lagami01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "1B", G = 4, Gs = 1, InnOuts = 33, Po = 12, A = 1, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lemonch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lemonch01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 140, Gs = 135, InnOuts = 3623, Po = 427, A = 6, E = 2, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lopezau01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lopezau01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 71, Gs = 0, InnOuts = 413, Po = 6, A = 11, E = 2, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lowrydw01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lowrydw01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "C", G = 31, Gs = 11, InnOuts = 405, Po = 87, A = 8, E = 0, Dp = 2, Pb = 0, Sb = 8, Cs = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "masonro01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "masonro01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 5, Gs = 2, InnOuts = 66, Po = 5, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "mongesi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "mongesi01", YearId = 1984, Stint = 2, TeamId = "DET", LgId = "AL", Pos = "P", G = 19, Gs = 0, InnOuts = 108, Po = 0, A = 2, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "morrija02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "morrija02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 35, Gs = 35, InnOuts = 721, Po = 29, A = 32, E = 3, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "onealra01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "onealra01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 4, Gs = 3, InnOuts = 56, Po = 2, A = 1, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "parrila02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "parrila02", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "C", G = 127, Gs = 123, InnOuts = 3225, Po = 720, A = 67, E = 7, Dp = 11, Pb = 11, Sb = 44, Cs = 38, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "petryda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "petryda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 35, Gs = 35, InnOuts = 700, Po = 38, A = 34, E = 1, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rozemda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rozemda01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 29, Gs = 16, InnOuts = 303, Po = 17, A = 10, E = 0, Dp = 3, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "scherbi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "scherbi01", YearId = 1984, Stint = 2, TeamId = "DET", LgId = "AL", Pos = "P", G = 18, Gs = 0, InnOuts = 57, Po = 0, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "simmone01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "simmone01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 5, Gs = 4, InnOuts = 111, Po = 8, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "trammal01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "trammal01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "SS", G = 114, Gs = 112, InnOuts = 2979, Po = 180, A = 314, E = 10, Dp = 71, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "whitalo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "whitalo01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "2B", G = 142, Gs = 131, InnOuts = 3585, Po = 290, A = 405, E = 15, Dp = 83, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "wilcomi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "wilcomi01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 33, Gs = 33, InnOuts = 581, Po = 20, A = 28, E = 3, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "willica01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "willica01", YearId = 1984, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 10, Gs = 2, InnOuts = 48, Po = 1, A = 2, E = 0, Dp = 1, });
			}
			dbContext.SaveChanges();
		}
	}
}

