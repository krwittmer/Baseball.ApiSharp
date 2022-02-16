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
	public partial class TeamDataOakland2002
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
			if (dbContext.People.Count(m => m.PlayerId == "bowiemi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "bowiemi01", Bats = "L", Throws = "L", NameFirst = "Micah", NameLast = "Bowie", BbrefId = "bowiemi01", BirthCity = "Humble", BirthDay = 10, BirthCountry = "USA", BirthState = "TX", BirthMonth = 11, BirthYear = 1974, Debut = "1999-07-24 00:00:00", FinalGame = "2008-04-21 00:00:00", Height = 76, Weight = 185, RetroId = "bowim001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "bradfch01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "bradfch01", Bats = "R", Throws = "R", NameFirst = "Chad", NameLast = "Bradford", BbrefId = "bradfch01", BirthCity = "Jackson", BirthDay = 14, BirthCountry = "USA", BirthState = "MS", BirthMonth = 9, BirthYear = 1974, Debut = "1998-08-01 00:00:00", FinalGame = "2009-09-23 00:00:00", Height = 77, Weight = 205, RetroId = "bradc001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "fyhrimi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "fyhrimi01", Bats = "R", Throws = "R", NameFirst = "Mike", NameLast = "Fyhrie", BbrefId = "fyhrimi01", BirthCity = "Long Beach", BirthDay = 9, BirthCountry = "USA", BirthState = "CA", BirthMonth = 12, BirthYear = 1969, Debut = "1996-09-14 00:00:00", FinalGame = "2002-09-28 00:00:00", Height = 74, Weight = 190, RetroId = "fyhrm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "haranaa01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "haranaa01", Bats = "R", Throws = "R", NameFirst = "Aaron", NameLast = "Harang", BbrefId = "haranaa01", BirthCity = "San Diego", BirthDay = 9, BirthCountry = "USA", BirthState = "CA", BirthMonth = 5, BirthYear = 1978, Debut = "2002-05-25 00:00:00", FinalGame = "2015-10-03 00:00:00", Height = 79, Weight = 260, RetroId = "haraa001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hiljuer01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hiljuer01", Bats = "R", Throws = "R", NameFirst = "Erik", NameLast = "Hiljus", BbrefId = "hiljuer01", BirthCity = "Panorama City", BirthDay = 25, BirthCountry = "USA", BirthState = "CA", BirthMonth = 12, BirthYear = 1972, Debut = "1999-09-10 00:00:00", FinalGame = "2002-05-29 00:00:00", Height = 77, Weight = 230, RetroId = "hilje001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "holtzmi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "holtzmi01", Bats = "L", Throws = "L", NameFirst = "Mike", NameLast = "Holtz", BbrefId = "holtzmi01", BirthCity = "Arlington", BirthDay = 10, BirthCountry = "USA", BirthState = "VA", BirthMonth = 10, BirthYear = 1972, Debut = "1996-07-11 00:00:00", FinalGame = "2006-05-16 00:00:00", Height = 69, Weight = 172, RetroId = "holtm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hudsoti01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hudsoti01", Bats = "R", Throws = "R", NameFirst = "Tim", NameLast = "Hudson", BbrefId = "hudsoti01", BirthCity = "Columbus", BirthDay = 14, BirthCountry = "USA", BirthState = "GA", BirthMonth = 7, BirthYear = 1975, Debut = "1999-06-08 00:00:00", FinalGame = "2015-10-01 00:00:00", Height = 73, Weight = 175, RetroId = "hudst001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "kochbi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "kochbi01", Bats = "R", Throws = "R", NameFirst = "Billy", NameLast = "Koch", BbrefId = "kochbi01", BirthCity = "Rockville Centre", BirthDay = 14, BirthCountry = "USA", BirthState = "NY", BirthMonth = 12, BirthYear = 1974, Debut = "1999-05-05 00:00:00", FinalGame = "2004-08-26 00:00:00", Height = 75, Weight = 218, RetroId = "kochb001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lidleco01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lidleco01", Bats = "R", Throws = "R", NameFirst = "Cory", NameLast = "Lidle", BbrefId = "lidleco01", BirthCity = "Hollywood", BirthDay = 22, BirthCountry = "USA", BirthState = "CA", BirthMonth = 3, BirthYear = 1972, DeathMonth = 10, DeathDay = 11, DeathCountry = "USA", DeathState = "NY", DeathCity = "New York", Debut = "1997-05-08 00:00:00", FinalGame = "2006-10-01 00:00:00", Height = 71, Weight = 175, RetroId = "lidlc001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "lillyte01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "lillyte01", Bats = "L", Throws = "L", NameFirst = "Ted", NameLast = "Lilly", BbrefId = "lillyte01", BirthCity = "Lomita", BirthDay = 4, BirthCountry = "USA", BirthState = "CA", BirthMonth = 1, BirthYear = 1976, Debut = "1999-05-14 00:00:00", FinalGame = "2013-06-04 00:00:00", Height = 72, Weight = 195, RetroId = "lillt001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "magnami01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "magnami01", Bats = "L", Throws = "L", NameFirst = "Mike", NameLast = "Magnante", BbrefId = "magnami01", BirthCity = "Glendale", BirthDay = 17, BirthCountry = "USA", BirthState = "CA", BirthMonth = 6, BirthYear = 1965, Debut = "1991-04-22 00:00:00", FinalGame = "2002-07-29 00:00:00", Height = 73, Weight = 180, RetroId = "magnm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "mecirji01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "mecirji01", Bats = "B", Throws = "R", NameFirst = "Jim", NameLast = "Mecir", BbrefId = "mecirji01", BirthCity = "Bayside", BirthDay = 16, BirthCountry = "USA", BirthState = "NY", BirthMonth = 5, BirthYear = 1970, Debut = "1995-09-04 00:00:00", FinalGame = "2005-09-28 00:00:00", Height = 73, Weight = 195, RetroId = "mecij001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "muldema01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "muldema01", Bats = "L", Throws = "L", NameFirst = "Mark", NameLast = "Mulder", BbrefId = "muldema01", BirthCity = "South Holland", BirthDay = 5, BirthCountry = "USA", BirthState = "IL", BirthMonth = 8, BirthYear = 1977, Debut = "2000-04-18 00:00:00", FinalGame = "2008-07-09 00:00:00", Height = 78, Weight = 200, RetroId = "muldm001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "rincori01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "rincori01", Bats = "L", Throws = "L", NameFirst = "Ricardo", NameLast = "Rincon", BbrefId = "rincori01", BirthCity = "Cuitlahuac", BirthDay = 13, BirthCountry = "Mexico", BirthState = "Veracruz", BirthMonth = 4, BirthYear = 1970, Debut = "1997-04-03 00:00:00", FinalGame = "2008-09-25 00:00:00", Height = 70, Weight = 190, RetroId = "rincr001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "tamje01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "tamje01", Bats = "R", Throws = "R", NameFirst = "Jeff", NameLast = "Tam", BbrefId = "tamje01", BirthCity = "Fullerton", BirthDay = 19, BirthCountry = "USA", BirthState = "CA", BirthMonth = 8, BirthYear = 1970, Debut = "1998-06-30 00:00:00", FinalGame = "2003-07-09 00:00:00", Height = 73, Weight = 202, RetroId = "tam-j001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "venafmi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "venafmi01", Bats = "L", Throws = "L", NameFirst = "Mike", NameLast = "Venafro", BbrefId = "venafmi01", BirthCity = "Takoma Park", BirthDay = 2, BirthCountry = "USA", BirthState = "MD", BirthMonth = 8, BirthYear = 1973, Debut = "1999-04-24 00:00:00", FinalGame = "2006-09-30 00:00:00", Height = 70, Weight = 170, RetroId = "venam002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "zitoba01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "zitoba01", Bats = "L", Throws = "L", NameFirst = "Barry", NameLast = "Zito", BbrefId = "zitoba01", BirthCity = "Las Vegas", BirthDay = 13, BirthCountry = "USA", BirthState = "NV", BirthMonth = 5, BirthYear = 1978, Debut = "2000-07-22 00:00:00", FinalGame = "2015-09-30 00:00:00", Height = 74, Weight = 205, RetroId = "zitob001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "byrneer01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "byrneer01", Bats = "R", Throws = "R", NameFirst = "Eric", NameLast = "Byrnes", BbrefId = "byrneer01", BirthCity = "Redwood City", BirthDay = 16, BirthCountry = "USA", BirthState = "CA", BirthMonth = 2, BirthYear = 1976, Debut = "2000-08-22 00:00:00", FinalGame = "2010-05-02 00:00:00", Height = 74, Weight = 200, RetroId = "byrne001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "chaveer01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "chaveer01", Bats = "L", Throws = "R", NameFirst = "Eric", NameLast = "Chavez", BbrefId = "chaveer01", BirthCity = "Los Angeles", BirthDay = 7, BirthCountry = "USA", BirthState = "CA", BirthMonth = 12, BirthYear = 1977, Debut = "1998-09-08 00:00:00", FinalGame = "2014-06-08 00:00:00", Height = 73, Weight = 215, RetroId = "chave001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "colanmi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "colanmi01", Bats = "R", Throws = "R", NameFirst = "Mike", NameLast = "Colangelo", BbrefId = "colanmi01", BirthCity = "Teaneck", BirthDay = 22, BirthCountry = "USA", BirthState = "NJ", BirthMonth = 10, BirthYear = 1976, Debut = "1999-06-13 00:00:00", FinalGame = "2002-05-02 00:00:00", Height = 73, Weight = 185, RetroId = "colam001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "durhara01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "durhara01", Bats = "B", Throws = "R", NameFirst = "Ray", NameLast = "Durham", BbrefId = "durhara01", BirthCity = "Charlotte", BirthDay = 30, BirthCountry = "USA", BirthState = "NC", BirthMonth = 11, BirthYear = 1971, Debut = "1995-04-26 00:00:00", FinalGame = "2008-09-28 00:00:00", Height = 68, Weight = 170, RetroId = "durhr001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "dyeje01", Bats = "R", Throws = "R", NameFirst = "Jermaine", NameLast = "Dye", BbrefId = "dyeje01", BirthCity = "Oakland", BirthDay = 28, BirthCountry = "USA", BirthState = "CA", BirthMonth = 1, BirthYear = 1974, Debut = "1996-05-17 00:00:00", FinalGame = "2009-10-04 00:00:00", Height = 76, Weight = 210, RetroId = "dye-j001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "ellisma01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "ellisma01", Bats = "R", Throws = "R", NameFirst = "Mark", NameLast = "Ellis", BbrefId = "ellisma01", BirthCity = "Rapid City", BirthDay = 6, BirthCountry = "USA", BirthState = "SD", BirthMonth = 6, BirthYear = 1977, Debut = "2002-04-09 00:00:00", FinalGame = "2014-09-27 00:00:00", Height = 70, Weight = 190, RetroId = "ellim001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "florejo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "florejo01", Bats = "R", Throws = "R", NameFirst = "Jose", NameLast = "Flores", BbrefId = "florejo01", BirthCity = "New York", BirthDay = 28, BirthCountry = "USA", BirthState = "NY", BirthMonth = 6, BirthYear = 1973, Debut = "2002-09-07 00:00:00", FinalGame = "2004-10-03 00:00:00", Height = 71, Weight = 180, RetroId = "florj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "germaes01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "germaes01", Bats = "R", Throws = "R", NameFirst = "Esteban", NameLast = "German", BbrefId = "germaes01", BirthCity = "Bajos de Haina", BirthDay = 26, BirthCountry = "D.R.", BirthState = "San Cristobal", BirthMonth = 1, BirthYear = 1978, Debut = "2002-05-21 00:00:00", FinalGame = "2011-09-27 00:00:00", Height = 69, Weight = 195, RetroId = "germe001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "giambje01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "giambje01", Bats = "L", Throws = "L", NameFirst = "Jeremy", NameLast = "Giambi", BbrefId = "giambje01", BirthCity = "San Jose", BirthDay = 30, BirthCountry = "USA", BirthState = "CA", BirthMonth = 9, BirthYear = 1974, Debut = "1998-09-01 00:00:00", FinalGame = "2003-08-01 00:00:00", Height = 72, Weight = 185, RetroId = "giamj002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "graboja01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "graboja01", Bats = "L", Throws = "R", NameFirst = "Jason", NameLast = "Grabowski", BbrefId = "graboja01", BirthCity = "New Haven", BirthDay = 24, BirthCountry = "USA", BirthState = "CT", BirthMonth = 5, BirthYear = 1976, Debut = "2002-09-22 00:00:00", FinalGame = "2005-10-02 00:00:00", Height = 75, Weight = 200, RetroId = "grabj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hattesc01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hattesc01", Bats = "L", Throws = "R", NameFirst = "Scott", NameLast = "Hatteberg", BbrefId = "hattesc01", BirthCity = "Salem", BirthDay = 14, BirthCountry = "USA", BirthState = "OR", BirthMonth = 12, BirthYear = 1969, Debut = "1995-09-08 00:00:00", FinalGame = "2008-05-25 00:00:00", Height = 73, Weight = 192, RetroId = "hatts001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "hernara02") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "hernara02", Bats = "R", Throws = "R", NameFirst = "Ramon", NameLast = "Hernandez", BbrefId = "hernara02", BirthCity = "Caracas", BirthDay = 20, BirthCountry = "Venezuela", BirthState = "Distrito Federal", BirthMonth = 5, BirthYear = 1976, Debut = "1999-06-29 00:00:00", FinalGame = "2013-06-12 00:00:00", Height = 72, Weight = 220, RetroId = "hernr002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "justida01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "justida01", Bats = "L", Throws = "L", NameFirst = "David", NameLast = "Justice", BbrefId = "justida01", BirthCity = "Cincinnati", BirthDay = 14, BirthCountry = "USA", BirthState = "OH", BirthMonth = 4, BirthYear = 1966, Debut = "1989-05-24 00:00:00", FinalGame = "2002-09-29 00:00:00", Height = 75, Weight = 195, RetroId = "justd001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "longte01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "longte01", Bats = "L", Throws = "L", NameFirst = "Terrence", NameLast = "Long", BbrefId = "longte01", BirthCity = "Montgomery", BirthDay = 29, BirthCountry = "USA", BirthState = "AL", BirthMonth = 2, BirthYear = 1976, Debut = "1999-04-14 00:00:00", FinalGame = "2006-06-05 00:00:00", Height = 73, Weight = 190, RetroId = "longt002" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "mabryjo01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "mabryjo01", Bats = "L", Throws = "R", NameFirst = "John", NameLast = "Mabry", BbrefId = "mabryjo01", BirthCity = "Wilmington", BirthDay = 17, BirthCountry = "USA", BirthState = "DE", BirthMonth = 10, BirthYear = 1970, Debut = "1994-04-23 00:00:00", FinalGame = "2007-05-17 00:00:00", Height = 76, Weight = 195, RetroId = "mabrj001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "mckayco01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "mckayco01", Bats = "L", Throws = "R", NameFirst = "Cody", NameLast = "McKay", BbrefId = "mckayco01", BirthCity = "Vancouver", BirthDay = 11, BirthCountry = "CAN", BirthState = "BC", BirthMonth = 1, BirthYear = 1974, Debut = "2002-09-22 00:00:00", FinalGame = "2004-10-02 00:00:00", Height = 72, Weight = 212, RetroId = "mckac001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "menecfr01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "menecfr01", Bats = "R", Throws = "R", NameFirst = "Frank", NameLast = "Menechino", BbrefId = "menecfr01", BirthCity = "Staten Island", BirthDay = 7, BirthCountry = "USA", BirthState = "NY", BirthMonth = 1, BirthYear = 1971, Debut = "1999-09-06 00:00:00", FinalGame = "2005-10-02 00:00:00", Height = 69, Weight = 175, RetroId = "menef001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "myersgr01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "myersgr01", Bats = "L", Throws = "R", NameFirst = "Greg", NameLast = "Myers", BbrefId = "myersgr01", BirthCity = "Riverside", BirthDay = 14, BirthCountry = "USA", BirthState = "CA", BirthMonth = 4, BirthYear = 1966, Debut = "1987-09-12 00:00:00", FinalGame = "2005-04-22 00:00:00", Height = 73, Weight = 200, RetroId = "myerg001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "penaca01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "penaca01", Bats = "L", Throws = "L", NameFirst = "Carlos", NameLast = "Pena", BbrefId = "penaca01", BirthCity = "Santo Domingo", BirthDay = 17, BirthCountry = "D.R.", BirthState = "Distrito Nacional", BirthMonth = 5, BirthYear = 1978, Debut = "2001-09-05 00:00:00", FinalGame = "2014-07-12 00:00:00", Height = 74, Weight = 225, RetroId = "penac001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "piattad01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "piattad01", Bats = "R", Throws = "R", NameFirst = "Adam", NameLast = "Piatt", BbrefId = "piattad01", BirthCity = "Chicago", BirthDay = 8, BirthCountry = "USA", BirthState = "IL", BirthMonth = 2, BirthYear = 1976, Debut = "2000-04-24 00:00:00", FinalGame = "2003-09-23 00:00:00", Height = 74, Weight = 195, RetroId = "piata001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "saenzol01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "saenzol01", Bats = "R", Throws = "R", NameFirst = "Olmedo", NameLast = "Saenz", BbrefId = "saenzol01", BirthCity = "Chitre", BirthDay = 8, BirthCountry = "Panama", BirthState = "Herrera", BirthMonth = 10, BirthYear = 1970, Debut = "1994-05-28 00:00:00", FinalGame = "2007-09-27 00:00:00", Height = 74, Weight = 185, RetroId = "saeno001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "suttola01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "suttola01", Bats = "L", Throws = "L", NameFirst = "Larry", NameLast = "Sutton", BbrefId = "suttola01", BirthCity = "West Covina", BirthDay = 14, BirthCountry = "USA", BirthState = "CA", BirthMonth = 5, BirthYear = 1970, Debut = "1997-08-17 00:00:00", FinalGame = "2004-06-01 00:00:00", Height = 71, Weight = 175, RetroId = "suttl001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "tejadmi01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "tejadmi01", Bats = "R", Throws = "R", NameFirst = "Miguel", NameLast = "Tejada", BbrefId = "tejadmi01", BirthCity = "Bani", BirthDay = 25, BirthCountry = "D.R.", BirthState = "Peravia", BirthMonth = 5, BirthYear = 1974, Debut = "1997-08-27 00:00:00", FinalGame = "2013-08-10 00:00:00", Height = 69, Weight = 220, RetroId = "tejam001" });
			}
			if (dbContext.People.Count(m => m.PlayerId == "velarra01") == 0)
			{
				dbContext.People.Add(new Person() { PlayerId = "velarra01", Bats = "R", Throws = "R", NameFirst = "Randy", NameLast = "Velarde", BbrefId = "velarra01", BirthCity = "Midland", BirthDay = 24, BirthCountry = "USA", BirthState = "TX", BirthMonth = 11, BirthYear = 1962, Debut = "1987-08-20 00:00:00", FinalGame = "2002-09-29 00:00:00", Height = 72, Weight = 185, RetroId = "velar001" });
			}
			dbContext.SaveChanges();
		}

		public static void BulkPitchingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Pitching.Count(m => m.PlayerId == "bowiemi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "bowiemi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 2, L = 0, G = 13, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 36, H = 12, Er = 2, Hr = 1, Bb = 8, So = 8, Baopp = 261, Era = 150, Ibb = 1, Wp = 0, Hbp = 1, Bk = 0, Bfp = 55, Gf = 4, R = 2, Sh = 0, Sf = 0, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "bradfch01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "bradfch01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 4, L = 2, G = 75, Gs = 0, Cg = 0, Sho = 0, Sv = 2, Ipouts = 226, H = 73, Er = 26, Hr = 2, Bb = 14, So = 56, Baopp = 253, Era = 311, Ibb = 5, Wp = 0, Hbp = 5, Bk = 1, Bfp = 311, Gf = 14, R = 29, Sh = 2, Sf = 2, Gidp = 8 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "fyhrimi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "fyhrimi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 2, L = 4, G = 16, Gs = 4, Cg = 0, Sho = 0, Sv = 0, Ipouts = 146, H = 46, Er = 24, Hr = 3, Bb = 20, So = 29, Baopp = 246, Era = 444, Ibb = 1, Wp = 1, Hbp = 4, Bk = 1, Bfp = 212, Gf = 2, R = 25, Sh = 1, Sf = 0, Gidp = 3 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "haranaa01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "haranaa01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 5, L = 4, G = 16, Gs = 15, Cg = 0, Sho = 0, Sv = 0, Ipouts = 235, H = 78, Er = 42, Hr = 7, Bb = 45, So = 64, Baopp = 261, Era = 483, Ibb = 2, Wp = 1, Hbp = 3, Bk = 0, Bfp = 354, Gf = 0, R = 44, Sh = 3, Sf = 4, Gidp = 8 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hiljuer01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hiljuer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 3, L = 3, G = 9, Gs = 9, Cg = 0, Sho = 0, Sv = 0, Ipouts = 137, H = 52, Er = 33, Hr = 11, Bb = 21, So = 29, Baopp = 284, Era = 650, Ibb = 1, Wp = 1, Hbp = 0, Bk = 0, Bfp = 206, Gf = 0, R = 36, Sh = 1, Sf = 1, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "holtzmi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "holtzmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 0, L = 0, G = 16, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 42, H = 24, Er = 10, Hr = 3, Bb = 9, So = 7, Baopp = 358, Era = 643, Ibb = 0, Wp = 0, Hbp = 1, Bk = 0, Bfp = 77, Gf = 7, R = 11, Sh = 0, Sf = 0, Gidp = 0 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "hudsoti01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "hudsoti01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 15, L = 9, G = 34, Gs = 34, Cg = 4, Sho = 2, Sv = 0, Ipouts = 715, H = 237, Er = 79, Hr = 19, Bb = 62, So = 152, Baopp = 263, Era = 298, Ibb = 9, Wp = 7, Hbp = 8, Bk = 1, Bfp = 983, Gf = 0, R = 87, Sh = 6, Sf = 5, Gidp = 35 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "kochbi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "kochbi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 11, L = 4, G = 84, Gs = 0, Cg = 0, Sho = 0, Sv = 44, Ipouts = 281, H = 73, Er = 34, Hr = 7, Bb = 46, So = 93, Baopp = 214, Era = 327, Ibb = 6, Wp = 5, Hbp = 4, Bk = 0, Bfp = 398, Gf = 79, R = 38, Sh = 6, Sf = 1, Gidp = 4 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "lidleco01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "lidleco01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 8, L = 10, G = 31, Gs = 30, Cg = 2, Sho = 2, Sv = 0, Ipouts = 576, H = 191, Er = 83, Hr = 17, Bb = 39, So = 111, Baopp = 258, Era = 389, Ibb = 3, Wp = 6, Hbp = 6, Bk = 1, Bfp = 796, Gf = 0, R = 90, Sh = 5, Sf = 6, Gidp = 16 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "lillyte01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "lillyte01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", W = 2, L = 1, G = 6, Gs = 5, Cg = 0, Sho = 0, Sv = 0, Ipouts = 70, H = 23, Er = 12, Hr = 5, Bb = 7, So = 18, Baopp = 253, Era = 463, Ibb = 0, Wp = 0, Hbp = 1, Bk = 1, Bfp = 99, Gf = 0, R = 12, Sh = 0, Sf = 0, Gidp = 2 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "magnami01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "magnami01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 0, L = 2, G = 32, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 86, H = 38, Er = 19, Hr = 2, Bb = 11, So = 11, Baopp = 317, Era = 597, Ibb = 1, Wp = 2, Hbp = 1, Bk = 1, Bfp = 134, Gf = 12, R = 22, Sh = 0, Sf = 2, Gidp = 3 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "mecirji01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "mecirji01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 6, L = 4, G = 61, Gs = 0, Cg = 0, Sho = 0, Sv = 1, Ipouts = 203, H = 68, Er = 32, Hr = 5, Bb = 29, So = 53, Baopp = 259, Era = 426, Ibb = 4, Wp = 4, Hbp = 4, Bk = 1, Bfp = 304, Gf = 10, R = 36, Sh = 4, Sf = 4, Gidp = 3 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "muldema01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "muldema01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 19, L = 7, G = 30, Gs = 30, Cg = 2, Sho = 1, Sv = 0, Ipouts = 622, H = 182, Er = 80, Hr = 21, Bb = 55, So = 159, Baopp = 232, Era = 347, Ibb = 3, Wp = 7, Hbp = 11, Bk = 1, Bfp = 862, Gf = 0, R = 88, Sh = 6, Sf = 4, Gidp = 13 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "rincori01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "rincori01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", W = 0, L = 0, G = 25, Gs = 0, Cg = 0, Sho = 0, Sv = 1, Ipouts = 61, H = 11, Er = 7, Hr = 1, Bb = 3, So = 19, Baopp = 164, Era = 310, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 72, Gf = 3, R = 7, Sh = 0, Sf = 2, Gidp = 1 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "tamje01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "tamje01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 1, L = 2, G = 40, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 121, H = 56, Er = 23, Hr = 2, Bb = 13, So = 14, Baopp = 333, Era = 513, Ibb = 5, Wp = 3, Hbp = 2, Bk = 0, Bfp = 188, Gf = 14, R = 26, Sh = 3, Sf = 2, Gidp = 7 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "venafmi01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "venafmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 2, L = 2, G = 47, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 111, H = 45, Er = 19, Hr = 5, Bb = 14, So = 16, Baopp = 308, Era = 462, Ibb = 2, Wp = 1, Hbp = 2, Bk = 0, Bfp = 168, Gf = 8, R = 22, Sh = 4, Sf = 2, Gidp = 4 });
			}
			if (dbContext.Pitching.Count(m => m.PlayerId == "zitoba01") == 0)
			{
				dbContext.Pitching.Add(new Pitching() { PlayerId = "zitoba01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", W = 23, L = 5, G = 35, Gs = 35, Cg = 1, Sho = 0, Sv = 0, Ipouts = 688, H = 182, Er = 70, Hr = 24, Bb = 78, So = 182, Baopp = 218, Era = 275, Ibb = 2, Wp = 2, Hbp = 9, Bk = 1, Bfp = 939, Gf = 0, R = 79, Sh = 9, Sf = 7, Gidp = 16 });
			}
			dbContext.SaveChanges();
		}

		public static void BulkBattingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Batting.Count(m => m.PlayerId == "bowiemi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "bowiemi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 13, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "bradfch01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "bradfch01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 75, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "byrneer01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "byrneer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 90, Ab = 94, R = 24, _2b = 4, _3b = 2, H = 23, Hr = 3, Rbi = 11, Sb = 3, Cs = 0, Bb = 4, So = 17, Ibb = 0, Hbp = 3, Sh = 1, Sf = 2, Gidp = 3, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "chaveer01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "chaveer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 153, Ab = 585, R = 87, _2b = 31, _3b = 3, H = 161, Hr = 34, Rbi = 109, Sb = 8, Cs = 3, Bb = 65, So = 119, Ibb = 13, Hbp = 1, Sh = 0, Sf = 2, Gidp = 8, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "colanmi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "colanmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 20, Ab = 23, R = 2, _2b = 1, _3b = 0, H = 4, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 1, So = 2, Ibb = 0, Hbp = 1, Sh = 1, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "durhara01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "durhara01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", G = 54, Ab = 219, R = 43, _2b = 14, _3b = 4, H = 60, Hr = 6, Rbi = 22, Sb = 6, Cs = 2, Bb = 24, So = 34, Ibb = 1, Hbp = 2, Sh = 2, Sf = 1, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "dyeje01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 131, Ab = 488, R = 74, _2b = 27, _3b = 1, H = 123, Hr = 24, Rbi = 86, Sb = 2, Cs = 0, Bb = 52, So = 108, Ibb = 2, Hbp = 10, Sh = 0, Sf = 5, Gidp = 15, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "ellisma01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "ellisma01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 98, Ab = 345, R = 58, _2b = 16, _3b = 4, H = 94, Hr = 6, Rbi = 35, Sb = 4, Cs = 2, Bb = 44, So = 54, Ibb = 1, Hbp = 4, Sh = 8, Sf = 3, Gidp = 3, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "florejo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "florejo01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 7, Ab = 3, R = 2, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 1, Cs = 1, Bb = 1, So = 0, Ibb = 0, Hbp = 1, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "fyhrimi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "fyhrimi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 16, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "germaes01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "germaes01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 9, Ab = 35, R = 4, _2b = 0, _3b = 0, H = 7, Hr = 0, Rbi = 0, Sb = 1, Cs = 0, Bb = 4, So = 11, Ibb = 0, Hbp = 1, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "giambje01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "giambje01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 42, Ab = 157, R = 26, _2b = 7, _3b = 0, H = 43, Hr = 8, Rbi = 17, Sb = 0, Cs = 0, Bb = 27, So = 40, Ibb = 0, Hbp = 3, Sh = 0, Sf = 0, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "graboja01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "graboja01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 4, Ab = 8, R = 3, _2b = 1, _3b = 1, H = 3, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 3, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "haranaa01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "haranaa01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 16, Ab = 3, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 3, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hattesc01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hattesc01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 136, Ab = 492, R = 58, _2b = 22, _3b = 4, H = 138, Hr = 15, Rbi = 61, Sb = 0, Cs = 0, Bb = 68, So = 56, Ibb = 1, Hbp = 6, Sh = 1, Sf = 1, Gidp = 8, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hernara02") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hernara02", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 136, Ab = 403, R = 51, _2b = 20, _3b = 0, H = 94, Hr = 7, Rbi = 42, Sb = 0, Cs = 0, Bb = 43, So = 64, Ibb = 1, Hbp = 5, Sh = 3, Sf = 3, Gidp = 11, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hiljuer01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hiljuer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 9, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "holtzmi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "holtzmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 16, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "hudsoti01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "hudsoti01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 34, Ab = 5, R = 1, _2b = 1, _3b = 0, H = 1, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 1, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "justida01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "justida01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 118, Ab = 398, R = 54, _2b = 18, _3b = 3, H = 106, Hr = 11, Rbi = 49, Sb = 4, Cs = 1, Bb = 70, So = 66, Ibb = 3, Hbp = 1, Sh = 0, Sf = 2, Gidp = 12, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "kochbi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "kochbi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 84, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lidleco01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lidleco01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 31, Ab = 1, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 1, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "lillyte01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "lillyte01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", G = 6, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "longte01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "longte01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 162, Ab = 587, R = 71, _2b = 32, _3b = 4, H = 141, Hr = 16, Rbi = 67, Sb = 3, Cs = 6, Bb = 48, So = 96, Ibb = 6, Hbp = 2, Sh = 0, Sf = 3, Gidp = 17, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "mabryjo01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "mabryjo01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", G = 89, Ab = 193, R = 27, _2b = 13, _3b = 1, H = 53, Hr = 11, Rbi = 40, Sb = 1, Cs = 1, Bb = 14, So = 37, Ibb = 1, Hbp = 1, Sh = 0, Sf = 3, Gidp = 7, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "magnami01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "magnami01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 32, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "mckayco01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "mckayco01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 2, Ab = 3, R = 0, _2b = 0, _3b = 0, H = 2, Hr = 0, Rbi = 2, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 1, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "mecirji01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "mecirji01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 61, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "menecfr01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "menecfr01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 38, Ab = 132, R = 22, _2b = 7, _3b = 0, H = 27, Hr = 3, Rbi = 15, Sb = 0, Cs = 0, Bb = 20, So = 32, Ibb = 0, Hbp = 1, Sh = 0, Sf = 1, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "muldema01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "muldema01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 30, Ab = 5, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "myersgr01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "myersgr01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 65, Ab = 144, R = 15, _2b = 5, _3b = 0, H = 32, Hr = 6, Rbi = 21, Sb = 0, Cs = 0, Bb = 26, So = 36, Ibb = 3, Hbp = 0, Sh = 0, Sf = 0, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "penaca01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "penaca01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 40, Ab = 124, R = 12, _2b = 4, _3b = 0, H = 27, Hr = 7, Rbi = 16, Sb = 0, Cs = 0, Bb = 15, So = 38, Ibb = 0, Hbp = 1, Sh = 0, Sf = 1, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "piattad01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "piattad01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 55, Ab = 137, R = 18, _2b = 8, _3b = 0, H = 32, Hr = 5, Rbi = 18, Sb = 2, Cs = 1, Bb = 12, So = 33, Ibb = 0, Hbp = 2, Sh = 0, Sf = 1, Gidp = 1, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "rincori01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "rincori01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", G = 25, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "saenzol01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "saenzol01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 68, Ab = 156, R = 15, _2b = 10, _3b = 1, H = 43, Hr = 6, Rbi = 18, Sb = 1, Cs = 1, Bb = 13, So = 31, Ibb = 1, Hbp = 7, Sh = 0, Sf = 2, Gidp = 2, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "suttola01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "suttola01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 7, Ab = 19, R = 3, _2b = 0, _3b = 0, H = 2, Hr = 1, Rbi = 3, Sb = 0, Cs = 0, Bb = 1, So = 8, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "tamje01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "tamje01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 40, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "tejadmi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "tejadmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 162, Ab = 662, R = 108, _2b = 30, _3b = 0, H = 204, Hr = 34, Rbi = 131, Sb = 7, Cs = 2, Bb = 38, So = 84, Ibb = 3, Hbp = 11, Sh = 0, Sf = 4, Gidp = 21, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "velarra01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "velarra01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 56, Ab = 133, R = 22, _2b = 8, _3b = 0, H = 30, Hr = 2, Rbi = 8, Sb = 3, Cs = 0, Bb = 15, So = 32, Ibb = 1, Hbp = 5, Sh = 1, Sf = 1, Gidp = 4, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "venafmi01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "venafmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 47, Ab = 0, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0, Sf = 0, Gidp = 0, });
			}
			if (dbContext.Batting.Count(m => m.PlayerId == "zitoba01") == 0)
			{
				dbContext.Batting.Add(new Batting() { PlayerId = "zitoba01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", G = 35, Ab = 4, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 3, Ibb = 0, Hbp = 0, Sh = 2, Sf = 0, Gidp = 0, });
			}
			dbContext.SaveChanges();
		}

		public static void BulkFieldingPlayerInsert(LahmansDbContext dbContext)
		{
			if (dbContext.Fielding.Count(m => m.PlayerId == "bowiemi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bowiemi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 13, Gs = 0, InnOuts = 36, Po = 1, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "bradfch01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "bradfch01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 75, Gs = 0, InnOuts = 226, Po = 10, A = 10, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "byrneer01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "byrneer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 79, Gs = 19, InnOuts = 783, Po = 53, A = 1, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "chaveer01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "chaveer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "3B", G = 143, Gs = 143, InnOuts = 3786, Po = 120, A = 301, E = 17, Dp = 24, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "chaveer01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "chaveer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 1, Gs = 0, InnOuts = 12, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "colanmi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "colanmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 19, Gs = 5, InnOuts = 225, Po = 17, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "durhara01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "durhara01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", Pos = "2B", G = 11, Gs = 11, InnOuts = 295, Po = 21, A = 37, E = 2, Dp = 12, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "dyeje01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "dyeje01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 111, Gs = 109, InnOuts = 2869, Po = 171, A = 2, E = 5, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ellisma01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ellisma01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "2B", G = 85, Gs = 83, InnOuts = 2198, Po = 170, A = 232, E = 9, Dp = 48, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ellisma01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ellisma01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "3B", G = 7, Gs = 7, InnOuts = 189, Po = 7, A = 18, E = 2, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "ellisma01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "ellisma01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "SS", G = 8, Gs = 1, InnOuts = 57, Po = 3, A = 13, E = 0, Dp = 4, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "florejo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "florejo01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "2B", G = 2, Gs = 1, InnOuts = 18, Po = 0, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "florejo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "florejo01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "SS", G = 1, Gs = 0, InnOuts = 9, Po = 1, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "fyhrimi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "fyhrimi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 16, Gs = 4, InnOuts = 146, Po = 4, A = 6, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "germaes01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "germaes01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "2B", G = 8, Gs = 8, InnOuts = 231, Po = 22, A = 23, E = 1, Dp = 6, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "giambje01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "giambje01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 40, Gs = 40, InnOuts = 969, Po = 63, A = 0, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "graboja01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "graboja01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 4, Gs = 3, InnOuts = 81, Po = 6, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "haranaa01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "haranaa01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 16, Gs = 15, InnOuts = 235, Po = 6, A = 7, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hattesc01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hattesc01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "1B", G = 91, Gs = 88, InnOuts = 2164, Po = 768, A = 74, E = 5, Dp = 77, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hernara02") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hernara02", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "C", G = 135, Gs = 125, InnOuts = 3302, Po = 788, A = 58, E = 7, Dp = 12, Pb = 6, Sb = 45, Cs = 30, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hiljuer01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hiljuer01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 9, Gs = 9, InnOuts = 137, Po = 3, A = 5, E = 1, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "holtzmi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "holtzmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 16, Gs = 0, InnOuts = 42, Po = 1, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "hudsoti01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "hudsoti01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 34, Gs = 34, InnOuts = 715, Po = 26, A = 27, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "justida01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "justida01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 75, Gs = 72, InnOuts = 1757, Po = 125, A = 3, E = 2, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "kochbi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "kochbi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 84, Gs = 0, InnOuts = 281, Po = 14, A = 12, E = 0, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lidleco01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lidleco01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 31, Gs = 30, InnOuts = 576, Po = 15, A = 42, E = 2, Dp = 5, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "lillyte01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "lillyte01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", Pos = "P", G = 6, Gs = 5, InnOuts = 70, Po = 1, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "longte01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "longte01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 162, Gs = 158, InnOuts = 4230, Po = 382, A = 5, E = 8, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "mabryjo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "mabryjo01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", Pos = "1B", G = 50, Gs = 7, InnOuts = 401, Po = 136, A = 14, E = 0, Dp = 10, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "mabryjo01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "mabryjo01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 53, Gs = 43, InnOuts = 1068, Po = 87, A = 1, E = 2, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "magnami01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "magnami01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 32, Gs = 0, InnOuts = 86, Po = 3, A = 4, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "mckayco01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "mckayco01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "C", G = 1, Gs = 1, InnOuts = 24, Po = 6, A = 0, E = 0, Dp = 0, Pb = 0, Sb = 0, Cs = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "mecirji01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "mecirji01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 61, Gs = 0, InnOuts = 203, Po = 7, A = 15, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "menecfr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "menecfr01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "2B", G = 32, Gs = 31, InnOuts = 834, Po = 37, A = 90, E = 1, Dp = 10, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "menecfr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "menecfr01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "3B", G = 4, Gs = 1, InnOuts = 54, Po = 1, A = 5, E = 1, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "menecfr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "menecfr01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "SS", G = 2, Gs = 0, InnOuts = 18, Po = 2, A = 1, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "muldema01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "muldema01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 30, Gs = 30, InnOuts = 622, Po = 10, A = 36, E = 0, Dp = 3, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "myersgr01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "myersgr01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "C", G = 53, Gs = 36, InnOuts = 1030, Po = 264, A = 21, E = 1, Dp = 0, Pb = 3, Sb = 23, Cs = 16, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "penaca01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "penaca01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "1B", G = 40, Gs = 39, InnOuts = 1017, Po = 351, A = 42, E = 1, Dp = 25, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "piattad01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "piattad01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "1B", G = 1, Gs = 0, InnOuts = 9, Po = 4, A = 0, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "piattad01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "piattad01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 50, Gs = 35, InnOuts = 1014, Po = 66, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "rincori01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "rincori01", YearId = 2002, Stint = 2, TeamId = "OAK", LgId = "AL", Pos = "P", G = 25, Gs = 0, InnOuts = 61, Po = 1, A = 2, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "saenzol01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "saenzol01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "1B", G = 34, Gs = 23, InnOuts = 612, Po = 190, A = 12, E = 0, Dp = 17, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "saenzol01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "saenzol01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "3B", G = 15, Gs = 10, InnOuts = 300, Po = 14, A = 28, E = 5, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "suttola01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "suttola01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "1B", G = 6, Gs = 2, InnOuts = 75, Po = 29, A = 0, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "suttola01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "suttola01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "OF", G = 3, Gs = 2, InnOuts = 60, Po = 5, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "tamje01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "tamje01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 40, Gs = 0, InnOuts = 121, Po = 9, A = 8, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "tejadmi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "tejadmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "SS", G = 162, Gs = 161, InnOuts = 4272, Po = 229, A = 504, E = 19, Dp = 106, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "velarra01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "velarra01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "1B", G = 5, Gs = 3, InnOuts = 78, Po = 25, A = 0, E = 1, Dp = 2, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "velarra01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "velarra01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "2B", G = 38, Gs = 28, InnOuts = 780, Po = 70, A = 88, E = 3, Dp = 22, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "velarra01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "velarra01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "3B", G = 1, Gs = 1, InnOuts = 27, Po = 0, A = 1, E = 0, Dp = 0, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "venafmi01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "venafmi01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 47, Gs = 0, InnOuts = 111, Po = 1, A = 11, E = 0, Dp = 1, });
			}
			if (dbContext.Fielding.Count(m => m.PlayerId == "zitoba01") == 0)
			{
				dbContext.Fielding.Add(new Fielding() { PlayerId = "zitoba01", YearId = 2002, Stint = 1, TeamId = "OAK", LgId = "AL", Pos = "P", G = 35, Gs = 35, InnOuts = 688, Po = 11, A = 31, E = 3, Dp = 3, });
			}
			dbContext.SaveChanges();
		}
	}
}

