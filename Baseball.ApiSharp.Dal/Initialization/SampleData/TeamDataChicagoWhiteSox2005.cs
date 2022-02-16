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
	public partial class TeamDataChicagoWhiteSox2005
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
			if (dbContext.People.Count(m => m.PlayerId == "adkinjo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "adkinjo01", Bats = "L", Throws = "R", NameFirst = "Jon", NameLast = "Adkins", BbrefId = "adkinjo01", BirthCity = "Huntington", BirthDay = 30, BirthCountry = "USA", BirthState = "WV", BirthMonth = 8, BirthYear = 1977, Debut = "2003-08-14 00:00:00", FinalGame = "2008-09-27 00:00:00", Height = 72, Weight = 200, RetroId = "adkij001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "bajenje01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "bajenje01", Bats = "R", Throws = "R", NameFirst = "Jeff", NameLast = "Bajenaru", BbrefId = "bajenje01", BirthCity = "Pomona", BirthDay = 21, BirthCountry = "USA", BirthState = "CA", BirthMonth = 3, BirthYear = 1978, Debut = "2004-09-04 00:00:00", FinalGame = "2006-08-07 00:00:00", Height = 73, Weight = 190, RetroId = "bajej001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "buehrma01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "buehrma01", Bats = "L", Throws = "L", NameFirst = "Mark", NameLast = "Buehrle", BbrefId = "buehrma01", BirthCity = "St. Charles", BirthDay = 23, BirthCountry = "USA", BirthState = "MO", BirthMonth = 3, BirthYear = 1979, Debut = "2000-07-16 00:00:00", FinalGame = "2015-10-04 00:00:00", Height = 74, Weight = 240, RetroId = "buehm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "contrjo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "contrjo01", Bats = "R", Throws = "R", NameFirst = "Jose", NameLast = "Contreras", BbrefId = "contrjo01", BirthCity = "Las Martinas", BirthDay = 6, BirthCountry = "Cuba", BirthState = "Pinar del Rio", BirthMonth = 12, BirthYear = 1971, Debut = "2003-03-31 00:00:00", FinalGame = "2013-05-27 00:00:00", Height = 76, Weight = 255, RetroId = "contj002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "cottsne01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "cottsne01", Bats = "L", Throws = "L", NameFirst = "Neal", NameLast = "Cotts", BbrefId = "cottsne01", BirthCity = "Lebanon", BirthDay = 25, BirthCountry = "USA", BirthState = "IL", BirthMonth = 3, BirthYear = 1980, Debut = "2003-08-12 00:00:00", FinalGame = "2015-10-03 00:00:00", Height = 74, Weight = 200, RetroId = "cottn001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "garcifr02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "garcifr02", Bats = "R", Throws = "R", NameFirst = "Freddy", NameLast = "Garcia", BbrefId = "garcifr03", BirthCity = "Caracas", BirthDay = 6, BirthCountry = "Venezuela", BirthState = "Distrito Federal", BirthMonth = 10, BirthYear = 1976, Debut = "1999-04-07 00:00:00", FinalGame = "2013-09-24 00:00:00", Height = 76, Weight = 250, RetroId = "garcf002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "garlajo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "garlajo01", Bats = "R", Throws = "R", NameFirst = "Jon", NameLast = "Garland", BbrefId = "garlajo01", BirthCity = "Valencia", BirthDay = 27, BirthCountry = "USA", BirthState = "CA", BirthMonth = 9, BirthYear = 1979, Debut = "2000-07-04 00:00:00", FinalGame = "2013-06-05 00:00:00", Height = 78, Weight = 210, RetroId = "garlj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hermadu01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hermadu01", Bats = "R", Throws = "R", NameFirst = "Dustin", NameLast = "Hermanson", BbrefId = "hermadu01", BirthCity = "Springfield", BirthDay = 21, BirthCountry = "USA", BirthState = "OH", BirthMonth = 12, BirthYear = 1972, Debut = "1995-05-08 00:00:00", FinalGame = "2006-09-24 00:00:00", Height = 75, Weight = 195, RetroId = "hermd001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hernaor01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hernaor01", Bats = "R", Throws = "R", NameFirst = "Orlando", NameLast = "Hernandez", BbrefId = "hernaor01", BirthCity = "Villa Clara", BirthDay = 11, BirthCountry = "Cuba", BirthMonth = 10, BirthYear = 1965, Debut = "1998-06-03 00:00:00", FinalGame = "2007-09-30 00:00:00", Height = 74, Weight = 210, RetroId = "herno001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "jenksbo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "jenksbo01", Bats = "R", Throws = "R", NameFirst = "Bobby", NameLast = "Jenks", BbrefId = "jenksbo01", BirthCity = "Mission Hills", BirthDay = 14, BirthCountry = "USA", BirthState = "CA", BirthMonth = 3, BirthYear = 1981, Debut = "2005-07-06 00:00:00", FinalGame = "2011-07-07 00:00:00", Height = 76, Weight = 275, RetroId = "jenkb001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "marteda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "marteda01", Bats = "L", Throws = "L", NameFirst = "Damaso", NameLast = "Marte", BbrefId = "marteda01", BirthCity = "Santo Domingo", BirthDay = 14, BirthCountry = "D.R.", BirthState = "Distrito Nacional", BirthMonth = 2, BirthYear = 1975, Debut = "1999-06-30 00:00:00", FinalGame = "2010-07-07 00:00:00", Height = 74, Weight = 215, RetroId = "martd004" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "mccarbr01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "mccarbr01", Bats = "R", Throws = "R", NameFirst = "Brandon", NameLast = "McCarthy", BbrefId = "mccarbr01", BirthCity = "Glendale", BirthDay = 7, BirthCountry = "USA", BirthState = "CA", BirthMonth = 7, BirthYear = 1983, Debut = "2005-05-22 00:00:00", FinalGame = "2018-06-24 00:00:00", Height = 80, Weight = 225, RetroId = "mccab001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "politcl01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "politcl01", Bats = "R", Throws = "R", NameFirst = "Cliff", NameLast = "Politte", BbrefId = "politcl01", BirthCity = "Kirkwood", BirthDay = 27, BirthCountry = "USA", BirthState = "MO", BirthMonth = 2, BirthYear = 1974, Debut = "1998-04-02 00:00:00", FinalGame = "2006-07-15 00:00:00", Height = 71, Weight = 185, RetroId = "polic001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "sandeda01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "sandeda01", Bats = "L", Throws = "L", NameFirst = "David", NameLast = "Sanders", BbrefId = "sandeda01", BirthCity = "Oklahoma City", BirthDay = 29, BirthCountry = "USA", BirthState = "OK", BirthMonth = 8, BirthYear = 1979, Debut = "2003-04-23 00:00:00", FinalGame = "2005-09-10 00:00:00", Height = 72, Weight = 200, RetroId = "sandd002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "takatsh01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "takatsh01", Bats = "R", Throws = "R", NameFirst = "Shingo", NameLast = "Takatsu", BbrefId = "takatsh01", BirthCity = "Hiroshima", BirthDay = 25, BirthCountry = "Japan", BirthState = "Hiroshima", BirthMonth = 11, BirthYear = 1968, Debut = "2004-04-09 00:00:00", FinalGame = "2005-10-02 00:00:00", Height = 72, Weight = 180, RetroId = "takas001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "vizcalu01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "vizcalu01", Bats = "R", Throws = "R", NameFirst = "Luis", NameLast = "Vizcaino", BbrefId = "vizcalu01", BirthCity = "Bani", BirthDay = 6, BirthCountry = "D.R.", BirthState = "Peravia", BirthMonth = 8, BirthYear = 1974, Debut = "1999-07-23 00:00:00", FinalGame = "2009-06-19 00:00:00", Height = 73, Weight = 170, RetroId = "vizcl001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "walkeke01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "walkeke01", Bats = "L", Throws = "L", NameFirst = "Kevin", NameLast = "Walker", BbrefId = "walkeke02", BirthCity = "Irving", BirthDay = 20, BirthCountry = "USA", BirthState = "TX", BirthMonth = 9, BirthYear = 1976, Debut = "2000-04-14 00:00:00", FinalGame = "2005-07-09 00:00:00", Height = 76, Weight = 190, RetroId = "walkk001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "anderbr03") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "anderbr03", Bats = "R", Throws = "R", NameFirst = "Brian", NameLast = "Anderson", BbrefId = "anderbr03", BirthCity = "Tucson", BirthDay = 11, BirthCountry = "USA", BirthState = "AZ", BirthMonth = 3, BirthYear = 1982, Debut = "2005-08-16 00:00:00", FinalGame = "2009-10-04 00:00:00", Height = 74, Weight = 220, RetroId = "andeb003" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "blumge01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "blumge01", Bats = "B", Throws = "R", NameFirst = "Geoff", NameLast = "Blum", BbrefId = "blumge01", BirthCity = "Redwood City", BirthDay = 26, BirthCountry = "USA", BirthState = "CA", BirthMonth = 4, BirthYear = 1973, Debut = "1999-08-09 00:00:00", FinalGame = "2012-07-17 00:00:00", Height = 75, Weight = 220, RetroId = "blumg001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "borchjo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "borchjo01", Bats = "B", Throws = "R", NameFirst = "Joe", NameLast = "Borchard", BbrefId = "borchjo01", BirthCity = "Panorama City", BirthDay = 25, BirthCountry = "USA", BirthState = "CA", BirthMonth = 11, BirthYear = 1978, Debut = "2002-09-02 00:00:00", FinalGame = "2007-08-05 00:00:00", Height = 76, Weight = 230, RetroId = "borcj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "burkeja02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "burkeja02", Bats = "R", Throws = "R", NameFirst = "Jamie", NameLast = "Burke", BbrefId = "burkeja02", BirthCity = "Roseburg", BirthDay = 24, BirthCountry = "USA", BirthState = "OR", BirthMonth = 9, BirthYear = 1971, Debut = "2001-05-09 00:00:00", FinalGame = "2010-06-06 00:00:00", Height = 72, Weight = 195, RetroId = "burkj003" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "casanra01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "casanra01", Bats = "B", Throws = "R", NameFirst = "Raul", NameLast = "Casanova", BbrefId = "casanra01", BirthCity = "Humacao", BirthDay = 23, BirthCountry = "P.R.", BirthMonth = 8, BirthYear = 1972, Debut = "1996-05-24 00:00:00", FinalGame = "2008-06-08 00:00:00", Height = 72, Weight = 200, RetroId = "casar001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "credejo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "credejo01", Bats = "R", Throws = "R", NameFirst = "Joe", NameLast = "Crede", BbrefId = "credejo01", BirthCity = "Jefferson City", BirthDay = 26, BirthCountry = "USA", BirthState = "MO", BirthMonth = 4, BirthYear = 1978, Debut = "2000-09-12 00:00:00", FinalGame = "2009-09-13 00:00:00", Height = 75, Weight = 195, RetroId = "credj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "dyeje01", Bats = "R", Throws = "R", NameFirst = "Jermaine", NameLast = "Dye", BbrefId = "dyeje01", BirthCity = "Oakland", BirthDay = 28, BirthCountry = "USA", BirthState = "CA", BirthMonth = 1, BirthYear = 1974, Debut = "1996-05-17 00:00:00", FinalGame = "2009-10-04 00:00:00", Height = 76, Weight = 210, RetroId = "dye-j001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "evereca01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "evereca01", Bats = "B", Throws = "R", NameFirst = "Carl", NameLast = "Everett", BbrefId = "evereca01", BirthCity = "Tampa", BirthDay = 3, BirthCountry = "USA", BirthState = "FL", BirthMonth = 6, BirthYear = 1971, Debut = "1993-07-01 00:00:00", FinalGame = "2006-07-25 00:00:00", Height = 72, Weight = 181, RetroId = "everc001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "gloadro01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "gloadro01", Bats = "L", Throws = "L", NameFirst = "Ross", NameLast = "Gload", BbrefId = "gloadro01", BirthCity = "Brooklyn", BirthDay = 5, BirthCountry = "USA", BirthState = "NY", BirthMonth = 4, BirthYear = 1976, Debut = "2000-08-31 00:00:00", FinalGame = "2011-09-24 00:00:00", Height = 73, Weight = 190, RetroId = "gloar001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "harriwi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "harriwi01", Bats = "L", Throws = "R", NameFirst = "Willie", NameLast = "Harris", BbrefId = "harriwi02", BirthCity = "Cairo", BirthDay = 22, BirthCountry = "USA", BirthState = "GA", BirthMonth = 6, BirthYear = 1978, Debut = "2001-09-02 00:00:00", FinalGame = "2012-06-24 00:00:00", Height = 69, Weight = 195, RetroId = "harrw001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "iguchta01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "iguchta01", Bats = "R", Throws = "R", NameFirst = "Tadahito", NameLast = "Iguchi", BbrefId = "iguchta01", BirthCity = "Tanashi", BirthDay = 4, BirthCountry = "Japan", BirthState = "Tokyo", BirthMonth = 12, BirthYear = 1974, Debut = "2005-04-04 00:00:00", FinalGame = "2008-09-28 00:00:00", Height = 70, Weight = 185, RetroId = "iguct001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "konerpa01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "konerpa01", Bats = "R", Throws = "R", NameFirst = "Paul", NameLast = "Konerko", BbrefId = "konerpa01", BirthCity = "Providence", BirthDay = 5, BirthCountry = "USA", BirthState = "RI", BirthMonth = 3, BirthYear = 1976, Debut = "1997-09-08 00:00:00", FinalGame = "2014-09-28 00:00:00", Height = 74, Weight = 220, RetroId = "konep001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lopezpe01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lopezpe01", Bats = "R", Throws = "R", NameFirst = "Pedro", NameLast = "Lopez", BbrefId = "lopezpe01", BirthCity = "Moca", BirthDay = 28, BirthCountry = "D.R.", BirthState = "Espaillat", BirthMonth = 4, BirthYear = 1984, Debut = "2005-05-01 00:00:00", FinalGame = "2007-09-30 00:00:00", Height = 73, Weight = 190, RetroId = "lopep001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "ozunapa01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "ozunapa01", Bats = "R", Throws = "R", NameFirst = "Pablo", NameLast = "Ozuna", BbrefId = "ozunapa01", BirthCity = "Santo Domingo", BirthDay = 25, BirthCountry = "D.R.", BirthState = "Distrito Nacional", BirthMonth = 8, BirthYear = 1974, Debut = "2000-04-23 00:00:00", FinalGame = "2008-09-28 00:00:00", Height = 71, Weight = 200, RetroId = "ozunp001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "perezti01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "perezti01", Bats = "L", Throws = "L", NameFirst = "Timo", NameLast = "Perez", BbrefId = "perezti01", BirthCity = "Bani", BirthDay = 8, BirthCountry = "D.R.", BirthState = "Peravia", BirthMonth = 4, BirthYear = 1975, Debut = "2000-09-01 00:00:00", FinalGame = "2007-09-29 00:00:00", Height = 69, Weight = 180, RetroId = "peret004" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "pierzaj01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "pierzaj01", Bats = "L", Throws = "R", NameFirst = "A. J.", NameLast = "Pierzynski", BbrefId = "pierza.01", BirthCity = "Bridgehampton", BirthDay = 30, BirthCountry = "USA", BirthState = "NY", BirthMonth = 12, BirthYear = 1976, Debut = "1998-09-09 00:00:00", FinalGame = "2016-09-10 00:00:00", Height = 75, Weight = 250, RetroId = "piera001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "podsesc01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "podsesc01", Bats = "L", Throws = "L", NameFirst = "Scott", NameLast = "Podsednik", BbrefId = "podsesc01", BirthCity = "West", BirthDay = 18, BirthCountry = "USA", BirthState = "TX", BirthMonth = 3, BirthYear = 1976, Debut = "2001-07-06 00:00:00", FinalGame = "2012-10-03 00:00:00", Height = 72, Weight = 185, RetroId = "podss001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rowanaa01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rowanaa01", Bats = "R", Throws = "R", NameFirst = "Aaron", NameLast = "Rowand", BbrefId = "rowanaa01", BirthCity = "Portland", BirthDay = 29, BirthCountry = "USA", BirthState = "OR", BirthMonth = 8, BirthYear = 1977, Debut = "2001-06-16 00:00:00", FinalGame = "2011-08-30 00:00:00", Height = 72, Weight = 210, RetroId = "rowaa001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "thomafr04") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "thomafr04", Bats = "R", Throws = "R", NameFirst = "Frank", NameLast = "Thomas", BbrefId = "thomafr04", BirthCity = "Columbus", BirthDay = 27, BirthCountry = "USA", BirthState = "GA", BirthMonth = 5, BirthYear = 1968, Debut = "1990-08-02 00:00:00", FinalGame = "2008-08-29 00:00:00", Height = 77, Weight = 240, RetroId = "thomf001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "uribeju01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "uribeju01", Bats = "R", Throws = "R", NameFirst = "Juan", NameLast = "Uribe", BbrefId = "uribeju01", BirthCity = "Palenque", BirthDay = 22, BirthCountry = "D.R.", BirthMonth = 3, BirthYear = 1979, Debut = "2001-04-08 00:00:00", FinalGame = "2016-07-30 00:00:00", Height = 72, Weight = 245, RetroId = "uribj002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "widgech01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "widgech01", Bats = "R", Throws = "R", NameFirst = "Chris", NameLast = "Widger", BbrefId = "widgech01", BirthCity = "Wilmington", BirthDay = 21, BirthCountry = "USA", BirthState = "DE", BirthMonth = 5, BirthYear = 1971, Debut = "1995-06-23 00:00:00", FinalGame = "2006-09-15 00:00:00", Height = 75, Weight = 195, RetroId = "widgc001" });
			}
			dbContext.SaveChanges();
		}

		public static void BulkPitchingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Pitching.Count(m => m.PlayerId == "adkinjo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "adkinjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 0, L = 1, G = 5, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 25, H = 13, Er = 8, Hr = 0, Bb = 4, So = 1, Baopp = 351, Era = 864, Ibb = 2, Wp = 0, Hbp = 1, Bk = 0, Bfp = 42, Gf = 4, R = 8, Sh = 0, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "bajenje01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "bajenje01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 0, L = 0, G = 4, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 13, H = 4, Er = 3, Hr = 2, Bb = 0, So = 3, Baopp = 222, Era = 623, Ibb = 0, Wp = 1, Hbp = 0, Bk = 0, Bfp = 18, Gf = 3, R = 3, Sh = 0, Sf = 0, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "buehrma01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "buehrma01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 16, L = 8, G = 33, Gs = 33, Cg = 3, Sho = 1, Sv = 0, Ipouts = 710, H = 240, Er = 82, Hr = 20, Bb = 40, So = 149, Baopp = 262, Era = 312, Ibb = 4, Wp = 2, Hbp = 4, Bk = 2, Bfp = 971, Gf = 0, R = 99, Sh = 7, Sf = 4, Gidp = 29 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "contrjo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "contrjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 15, L = 7, G = 32, Gs = 32, Cg = 1, Sho = 0, Sv = 0, Ipouts = 614, H = 177, Er = 82, Hr = 23, Bb = 75, So = 154, Baopp = 232, Era = 361, Ibb = 2, Wp = 20, Hbp = 9, Bk = 2, Bfp = 857, Gf = 0, R = 91, Sh = 7, Sf = 2, Gidp = 15 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "cottsne01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "cottsne01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 4, L = 0, G = 69, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 181, H = 38, Er = 13, Hr = 1, Bb = 29, So = 58, Baopp = 179, Era = 194, Ibb = 5, Wp = 3, Hbp = 4, Bk = 0, Bfp = 248, Gf = 10, R = 15, Sh = 0, Sf = 3, Gidp = 6 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "garcifr02") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "garcifr02", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 14, L = 8, G = 33, Gs = 33, Cg = 2, Sho = 0, Sv = 0, Ipouts = 684, H = 225, Er = 98, Hr = 26, Bb = 60, So = 146, Baopp = 259, Era = 387, Ibb = 2, Wp = 20, Hbp = 3, Bk = 1, Bfp = 943, Gf = 0, R = 102, Sh = 5, Sf = 5, Gidp = 25 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "garlajo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "garlajo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 18, L = 10, G = 32, Gs = 32, Cg = 3, Sho = 3, Sv = 0, Ipouts = 663, H = 212, Er = 86, Hr = 26, Bb = 47, So = 115, Baopp = 255, Era = 350, Ibb = 3, Wp = 2, Hbp = 7, Bk = 0, Bfp = 901, Gf = 0, R = 93, Sh = 9, Sf = 8, Gidp = 24 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hermadu01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hermadu01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 2, L = 4, G = 57, Gs = 0, Cg = 0, Sho = 0, Sv = 34, Ipouts = 172, H = 46, Er = 13, Hr = 4, Bb = 17, So = 33, Baopp = 222, Era = 204, Ibb = 4, Wp = 3, Hbp = 1, Bk = 0, Bfp = 228, Gf = 45, R = 17, Sh = 3, Sf = 0, Gidp = 7 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hernaor01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hernaor01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 9, L = 9, G = 24, Gs = 22, Cg = 0, Sho = 0, Sv = 1, Ipouts = 385, H = 137, Er = 73, Hr = 18, Bb = 50, So = 91, Baopp = 275, Era = 512, Ibb = 1, Wp = 3, Hbp = 12, Bk = 2, Bfp = 568, Gf = 1, R = 77, Sh = 3, Sf = 5, Gidp = 11 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "jenksbo01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "jenksbo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 1, L = 1, G = 32, Gs = 0, Cg = 0, Sho = 0, Sv = 6, Ipouts = 118, H = 34, Er = 12, Hr = 3, Bb = 15, So = 50, Baopp = 225, Era = 275, Ibb = 3, Wp = 4, Hbp = 1, Bk = 0, Bfp = 168, Gf = 18, R = 15, Sh = 1, Sf = 0, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "marteda01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "marteda01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 3, L = 4, G = 66, Gs = 0, Cg = 0, Sho = 0, Sv = 4, Ipouts = 136, H = 45, Er = 19, Hr = 5, Bb = 33, So = 54, Baopp = 256, Era = 377, Ibb = 4, Wp = 1, Hbp = 3, Bk = 1, Bfp = 213, Gf = 15, R = 21, Sh = 1, Sf = 0, Gidp = 4 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "mccarbr01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "mccarbr01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 3, L = 2, G = 12, Gs = 10, Cg = 0, Sho = 0, Sv = 0, Ipouts = 201, H = 62, Er = 30, Hr = 13, Bb = 17, So = 48, Baopp = 242, Era = 403, Ibb = 0, Wp = 1, Hbp = 2, Bk = 1, Bfp = 277, Gf = 0, R = 30, Sh = 1, Sf = 1, Gidp = 6 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "politcl01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "politcl01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 7, L = 1, G = 68, Gs = 0, Cg = 0, Sho = 0, Sv = 1, Ipouts = 202, H = 42, Er = 15, Hr = 7, Bb = 21, So = 57, Baopp = 181, Era = 200, Ibb = 4, Wp = 1, Hbp = 3, Bk = 0, Bfp = 262, Gf = 14, R = 15, Sh = 2, Sf = 4, Gidp = 6 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "sandeda01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "sandeda01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 0, L = 0, G = 2, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 6, H = 3, Er = 3, Hr = 1, Bb = 1, So = 1, Baopp = 375, Era = 1350, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 10, Gf = 0, R = 3, Sh = 0, Sf = 1, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "takatsh01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "takatsh01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 1, L = 2, G = 31, Gs = 0, Cg = 0, Sho = 0, Sv = 8, Ipouts = 86, H = 30, Er = 19, Hr = 9, Bb = 16, So = 32, Baopp = 270, Era = 597, Ibb = 1, Wp = 1, Hbp = 0, Bk = 0, Bfp = 130, Gf = 20, R = 19, Sh = 2, Sf = 1, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "vizcalu01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "vizcalu01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 6, L = 5, G = 65, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 210, H = 74, Er = 29, Hr = 8, Bb = 29, So = 43, Baopp = 275, Era = 373, Ibb = 6, Wp = 3, Hbp = 2, Bk = 0, Bfp = 305, Gf = 20, R = 30, Sh = 4, Sf = 1, Gidp = 7 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "walkeke01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "walkeke01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", W = 0, L = 1, G = 9, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 21, H = 10, Er = 7, Hr = 1, Bb = 5, So = 5, Baopp = 333, Era = 900, Ibb = 1, Wp = 0, Hbp = 0, Bk = 0, Bfp = 35, Gf = 3, R = 7, Sh = 0, Sf = 0, Gidp = 1 });
			}
			dbContext.SaveChanges();
		}

		public static void BulkBattingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Batting.Count(m => m.PlayerId == "adkinjo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "adkinjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 5, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "anderbr03") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "anderbr03", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 13, Ab = 34, R = 3, _2b = 1, _3b = 0, H = 6, Hr = 2, Rbi = 3, Sb = 1, Cs = 0, Bb = 0, So = 12, Ibb = 0, Hbp = 0, Sh = 1, Sf = 0, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "bajenje01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "bajenje01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 4, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "blumge01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "blumge01", YearId = 2005, Stint = 2, TeamId = "CHA", LgId = "AL", G = 31, Ab = 95, R = 6, _2b = 2, _3b = 1, H = 19, Hr = 1, Rbi = 3, Sb = 0, Cs = 1, Bb = 4, So = 15, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "borchjo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "borchjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 7, Ab = 12, R = 0, _2b = 2, _3b = 0, H = 5, Hr = 0, Rbi = 0, Sb = 0, Cs = 1, Bb = 0, So = 4, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "buehrma01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "buehrma01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 33, Ab = 3, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "burkeja02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "burkeja02", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 1, Ab = 1, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "casanra01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "casanra01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 6, Ab = 5, R = 0, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "contrjo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "contrjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 32, Ab = 3, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 1, So = 2, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "cottsne01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "cottsne01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 69, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "credejo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "credejo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 132, Ab = 432, R = 54, _2b = 21, _3b = 0, H = 109, Hr = 22, Rbi = 62, Sb = 1, Cs = 1, Bb = 25, So = 66, Ibb = 3, Hbp = 8, Sh = 2, Sf = 4, Gidp = 7, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "dyeje01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 145, Ab = 529, R = 74, _2b = 29, _3b = 2, H = 145, Hr = 31, Rbi = 86, Sb = 11, Cs = 4, Bb = 39, So = 99, Ibb = 3, Hbp = 9, Sh = 0, Sf = 2, Gidp = 15, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "evereca01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "evereca01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 135, Ab = 490, R = 58, _2b = 17, _3b = 2, H = 123, Hr = 23, Rbi = 87, Sb = 4, Cs = 5, Bb = 42, So = 99, Ibb = 2, Hbp = 5, Sh = 0, Sf = 10, Gidp = 11, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "garcifr02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "garcifr02", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 33, Ab = 7, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 2, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "garlajo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "garlajo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 32, Ab = 2, R = 0, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "gloadro01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "gloadro01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 28, Ab = 42, R = 2, _2b = 2, _3b = 0, H = 7, Hr = 0, Rbi = 5, Sb = 0, Cs = 0, Bb = 2, So = 9, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "harriwi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "harriwi01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 56, Ab = 121, R = 17, _2b = 2, _3b = 1, H = 31, Hr = 1, Rbi = 8, Sb = 10, Cs = 3, Bb = 13, So = 25, Ibb = 0, Hbp = 1, Sh = 4, Sf = 0, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hermadu01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hermadu01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 57, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hernaor01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hernaor01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 24, Ab = 3, R = 0, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "iguchta01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "iguchta01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 135, Ab = 511, R = 74, _2b = 25, _3b = 6, H = 142, Hr = 15, Rbi = 71, Sb = 15, Cs = 5, Bb = 47, So = 114, Ibb = 0, Hbp = 6, Sh = 11, Sf = 6, Gidp = 16, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "jenksbo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "jenksbo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 32, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "konerpa01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "konerpa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 158, Ab = 575, R = 98, _2b = 24, _3b = 0, H = 163, Hr = 40, Rbi = 100, Sb = 0, Cs = 0, Bb = 81, So = 109, Ibb = 10, Hbp = 5, Sh = 0, Sf = 3, Gidp = 9, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lopezpe01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lopezpe01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 2, Ab = 7, R = 1, _2b = 0, _3b = 0, H = 2, Hr = 0, Rbi = 2, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 1, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "marteda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "marteda01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 66, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "mccarbr01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "mccarbr01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 12, Ab = 2, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 2, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "ozunapa01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "ozunapa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 70, Ab = 203, R = 27, _2b = 7, _3b = 2, H = 56, Hr = 0, Rbi = 11, Sb = 14, Cs = 7, Bb = 7, So = 26, Ibb = 0, Hbp = 4, Sh = 3, Sf = 0, Gidp = 5, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "perezti01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "perezti01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 76, Ab = 179, R = 13, _2b = 8, _3b = 0, H = 39, Hr = 2, Rbi = 15, Sb = 2, Cs = 2, Bb = 12, So = 25, Ibb = 1, Hbp = 0, Sh = 4, Sf = 1, Gidp = 3, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "pierzaj01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "pierzaj01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 128, Ab = 460, R = 61, _2b = 21, _3b = 0, H = 118, Hr = 18, Rbi = 56, Sb = 0, Cs = 2, Bb = 23, So = 68, Ibb = 5, Hbp = 12, Sh = 1, Sf = 1, Gidp = 13, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "podsesc01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "podsesc01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 129, Ab = 507, R = 80, _2b = 28, _3b = 1, H = 147, Hr = 0, Rbi = 25, Sb = 59, Cs = 23, Bb = 47, So = 75, Ibb = 0, Hbp = 3, Sh = 6, Sf = 5, Gidp = 7, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "politcl01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "politcl01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 68, Ab = 1, R = 1, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rowanaa01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rowanaa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 157, Ab = 578, R = 77, _2b = 30, _3b = 5, H = 156, Hr = 13, Rbi = 69, Sb = 16, Cs = 5, Bb = 32, So = 116, Ibb = 3, Hbp = 21, Sh = 5, Sf = 4, Gidp = 17, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "sandeda01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "sandeda01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 2, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "takatsh01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "takatsh01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 31, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "thomafr04") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "thomafr04", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 34, Ab = 105, R = 19, _2b = 3, _3b = 0, H = 23, Hr = 12, Rbi = 26, Sb = 0, Cs = 0, Bb = 16, So = 31, Ibb = 0, Hbp = 0, Sh = 0, Sf = 3, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "uribeju01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "uribeju01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 146, Ab = 481, R = 58, _2b = 23, _3b = 3, H = 121, Hr = 16, Rbi = 71, Sb = 4, Cs = 6, Bb = 34, So = 77, Ibb = 0, Hbp = 4, Sh = 11, Sf = 10, Gidp = 7, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "vizcalu01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "vizcalu01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 65, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "walkeke01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "walkeke01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 9, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "widgech01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "widgech01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", G = 45, Ab = 141, R = 18, _2b = 8, _3b = 0, H = 34, Hr = 4, Rbi = 11, Sb = 0, Cs = 2, Bb = 10, So = 22, Ibb = 0, Hbp = 1, Sh = 2, Sf = 0, Gidp = 5, });
			}
			dbContext.SaveChanges();
		}

		public static void BulkFieldingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Fielding.Count(m => m.PlayerId == "adkinjo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "adkinjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 5, Gs = 0, InnOuts = 25, Po = 0, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "anderbr03") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "anderbr03", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 12, Gs = 7, InnOuts = 255, Po = 19, A = 1, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bajenje01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bajenje01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 4, Gs = 0, InnOuts = 13, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "blumge01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "blumge01", YearId = 2005, Stint = 2, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 12, Gs = 9, InnOuts = 267, Po = 91, A = 6, E = 0, Dp = 7, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "blumge01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "blumge01", YearId = 2005, Stint = 2, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 2, Gs = 2, InnOuts = 54, Po = 3, A = 4, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "blumge01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "blumge01", YearId = 2005, Stint = 2, TeamId = "CHA", LgId = "AL", Pos = "3B", G = 12, Gs = 9, InnOuts = 258, Po = 4, A = 29, E = 3, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "blumge01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "blumge01", YearId = 2005, Stint = 2, TeamId = "CHA", LgId = "AL", Pos = "SS", G = 6, Gs = 4, InnOuts = 123, Po = 6, A = 10, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "borchjo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "borchjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 2, Gs = 0, InnOuts = 21, Po = 3, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "buehrma01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "buehrma01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 33, Gs = 33, InnOuts = 710, Po = 13, A = 45, E = 2, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "burkeja02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "burkeja02", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 1, Gs = 0, InnOuts = 3, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "casanra01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "casanra01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "C", G = 6, Gs = 0, InnOuts = 42, Po = 9, A = 0, E = 0, Dp = 0, Pb = 0, Sb = 0, Cs = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "contrjo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "contrjo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 32, Gs = 32, InnOuts = 614, Po = 11, A = 24, E = 2, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "cottsne01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "cottsne01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 69, Gs = 0, InnOuts = 181, Po = 2, A = 14, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "credejo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "credejo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "3B", G = 130, Gs = 122, InnOuts = 3361, Po = 95, A = 243, E = 10, Dp = 28, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "credejo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "credejo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "SS", G = 1, Gs = 1, InnOuts = 24, Po = 1, A = 3, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "dyeje01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 1, Gs = 1, InnOuts = 27, Po = 7, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "dyeje01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 140, Gs = 137, InnOuts = 3706, Po = 259, A = 9, E = 8, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "dyeje01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "SS", G = 1, Gs = 0, InnOuts = 1, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "evereca01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "evereca01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 22, Gs = 22, InnOuts = 562, Po = 34, A = 1, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "garcifr02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "garcifr02", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 33, Gs = 33, InnOuts = 684, Po = 18, A = 29, E = 0, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "garlajo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "garlajo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 32, Gs = 32, InnOuts = 663, Po = 12, A = 35, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "gloadro01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "gloadro01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 24, Gs = 6, InnOuts = 267, Po = 72, A = 4, E = 1, Dp = 9, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "gloadro01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "gloadro01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 3, Gs = 2, InnOuts = 48, Po = 5, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "harriwi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "harriwi01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 32, Gs = 28, InnOuts = 745, Po = 58, A = 78, E = 2, Dp = 20, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "harriwi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "harriwi01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "SS", G = 5, Gs = 2, InnOuts = 75, Po = 1, A = 9, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hermadu01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hermadu01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 57, Gs = 0, InnOuts = 172, Po = 0, A = 6, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hernaor01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hernaor01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 24, Gs = 22, InnOuts = 385, Po = 7, A = 21, E = 2, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "iguchta01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "iguchta01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 133, Gs = 129, InnOuts = 3514, Po = 235, A = 375, E = 14, Dp = 85, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "jenksbo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "jenksbo01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 32, Gs = 0, InnOuts = 118, Po = 2, A = 3, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "konerpa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "konerpa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 146, Gs = 145, InnOuts = 3818, Po = 1321, A = 82, E = 5, Dp = 135, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lopezpe01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lopezpe01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 1, Gs = 1, InnOuts = 27, Po = 3, A = 5, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lopezpe01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lopezpe01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "SS", G = 1, Gs = 1, InnOuts = 27, Po = 0, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "marteda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "marteda01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 66, Gs = 0, InnOuts = 136, Po = 2, A = 5, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "mccarbr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "mccarbr01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 12, Gs = 10, InnOuts = 201, Po = 3, A = 4, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ozunapa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ozunapa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 2, Gs = 0, InnOuts = 9, Po = 2, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ozunapa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ozunapa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 6, Gs = 2, InnOuts = 87, Po = 6, A = 6, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ozunapa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ozunapa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "3B", G = 32, Gs = 30, InnOuts = 783, Po = 29, A = 67, E = 6, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ozunapa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ozunapa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 10, Gs = 8, InnOuts = 201, Po = 10, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ozunapa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ozunapa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "SS", G = 15, Gs = 11, InnOuts = 297, Po = 19, A = 35, E = 2, Dp = 12, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "perezti01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "perezti01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 2, Gs = 1, InnOuts = 33, Po = 13, A = 1, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "perezti01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "perezti01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 50, Gs = 35, InnOuts = 1035, Po = 75, A = 5, E = 3, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "pierzaj01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "pierzaj01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "C", G = 128, Gs = 124, InnOuts = 3353, Po = 803, A = 48, E = 1, Dp = 8, Pb = 7, Sb = 79, Cs = 23, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "podsesc01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "podsesc01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 127, Gs = 124, InnOuts = 3350, Po = 274, A = 3, E = 3, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "politcl01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "politcl01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 68, Gs = 0, InnOuts = 202, Po = 1, A = 6, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rowanaa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rowanaa01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "OF", G = 157, Gs = 151, InnOuts = 4103, Po = 388, A = 3, E = 3, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "sandeda01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "sandeda01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 2, Gs = 0, InnOuts = 6, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "takatsh01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "takatsh01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 31, Gs = 0, InnOuts = 86, Po = 3, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "uribeju01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "uribeju01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "SS", G = 146, Gs = 143, InnOuts = 3880, Po = 249, A = 422, E = 16, Dp = 98, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "vizcalu01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "vizcalu01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 65, Gs = 0, InnOuts = 210, Po = 6, A = 7, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "walkeke01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "walkeke01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "P", G = 9, Gs = 0, InnOuts = 21, Po = 0, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "widgech01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "widgech01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "1B", G = 1, Gs = 0, InnOuts = 3, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "widgech01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "widgech01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "3B", G = 1, Gs = 1, InnOuts = 25, Po = 1, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "widgech01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "widgech01", YearId = 2005, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "C", G = 42, Gs = 38, InnOuts = 1032, Po = 252, A = 12, E = 5, Dp = 1, Pb = 2, Sb = 24, Cs = 2, });
			}
			dbContext.SaveChanges();
		}
	}
}

