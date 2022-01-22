#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Data.Lahman;
using System.Linq;

namespace Baseball.ApiSharp.Dal.Initialization.SampleData
{
    public partial class TeamDataSeattleMariners2001
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
            if (dbContext.People.Count(m => m.PlayerId == "abbotpa01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "abbotpa01", Bats = "R", Throws = "R", NameFirst = "Paul", NameLast = "Abbott",
                    BbrefId = "abbotpa01", BirthCity = "Van Nuys", BirthDay = 15, BirthCountry = "USA",
                    BirthState = "CA", BirthMonth = 9, BirthYear = 1967, Debut = "1990-08-21 00:00:00",
                    FinalGame = "2004-08-07 00:00:00", Height = 75, Weight = 185, RetroId = "abbop001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "charlno01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "charlno01", Bats = "B", Throws = "L", NameFirst = "Norm", NameLast = "Charlton",
                    BbrefId = "charlno01", BirthCity = "Fort Polk", BirthDay = 6, BirthCountry = "USA",
                    BirthState = "LA", BirthMonth = 1, BirthYear = 1963, Debut = "1988-08-19 00:00:00",
                    FinalGame = "2001-10-07 00:00:00", Height = 75, Weight = 195, RetroId = "charn001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "frankry01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "frankry01", Bats = "R", Throws = "R", NameFirst = "Ryan", NameLast = "Franklin",
                    BbrefId = "frankry01", BirthCity = "Fort Smith", BirthDay = 5, BirthCountry = "USA",
                    BirthState = "AR", BirthMonth = 3, BirthYear = 1973, Debut = "1999-05-15 00:00:00",
                    FinalGame = "2011-06-28 00:00:00", Height = 75, Weight = 190, RetroId = "franr001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "fuentbr01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "fuentbr01", Bats = "L", Throws = "L", NameFirst = "Brian", NameLast = "Fuentes",
                    BbrefId = "fuentbr01", BirthCity = "Merced", BirthDay = 9, BirthCountry = "USA", BirthState = "CA",
                    BirthMonth = 8, BirthYear = 1975, Debut = "2001-06-02 00:00:00", FinalGame = "2012-08-08 00:00:00",
                    Height = 76, Weight = 230, RetroId = "fuenb001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "garcifr02") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "garcifr02", Bats = "R", Throws = "R", NameFirst = "Freddy", NameLast = "Garcia",
                    BbrefId = "garcifr03", BirthCity = "Caracas", BirthDay = 6, BirthCountry = "Venezuela",
                    BirthState = "Distrito Federal", BirthMonth = 10, BirthYear = 1976, Debut = "1999-04-07 00:00:00",
                    FinalGame = "2013-09-24 00:00:00", Height = 76, Weight = 250, RetroId = "garcf002"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "halamjo01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "halamjo01", Bats = "L", Throws = "L", NameFirst = "John", NameLast = "Halama",
                    BbrefId = "halamjo01", BirthCity = "Brooklyn", BirthDay = 22, BirthCountry = "USA",
                    BirthState = "NY", BirthMonth = 2, BirthYear = 1972, Debut = "1998-04-02 00:00:00",
                    FinalGame = "2006-06-10 00:00:00", Height = 77, Weight = 215, RetroId = "halaj001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "moyerja01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "moyerja01", Bats = "L", Throws = "L", NameFirst = "Jamie", NameLast = "Moyer",
                    BbrefId = "moyerja01", BirthCity = "Sellersville", BirthDay = 18, BirthCountry = "USA",
                    BirthState = "PA", BirthMonth = 11, BirthYear = 1962, Debut = "1986-06-16 00:00:00",
                    FinalGame = "2012-05-27 00:00:00", Height = 72, Weight = 170, RetroId = "moyej001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "nelsoje01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "nelsoje01", Bats = "R", Throws = "R", NameFirst = "Jeff", NameLast = "Nelson",
                    BbrefId = "nelsoje01", BirthCity = "Baltimore", BirthDay = 17, BirthCountry = "USA",
                    BirthState = "MD", BirthMonth = 11, BirthYear = 1966, Debut = "1992-04-16 00:00:00",
                    FinalGame = "2006-06-02 00:00:00", Height = 80, Weight = 225, RetroId = "nelsj001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "paniajo01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "paniajo01", Bats = "R", Throws = "R", NameFirst = "Jose", NameLast = "Paniagua",
                    BbrefId = "paniajo01", BirthCity = "San Jose de Ocoa", BirthDay = 20, BirthCountry = "D.R.",
                    BirthState = "Peravia", BirthMonth = 8, BirthYear = 1973, Debut = "1996-04-04 00:00:00",
                    FinalGame = "2003-09-09 00:00:00", Height = 74, Weight = 185, RetroId = "panij001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "pineijo01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "pineijo01", Bats = "R", Throws = "R", NameFirst = "Joel", NameLast = "Pineiro",
                    BbrefId = "pineijo01", BirthCity = "Rio Piedras", BirthDay = 25, BirthCountry = "P.R.",
                    BirthMonth = 9, BirthYear = 1978, Debut = "2000-08-08 00:00:00", FinalGame = "2011-09-25 00:00:00",
                    Height = 72, Weight = 200, RetroId = "pinej001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "rhodear01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "rhodear01", Bats = "L", Throws = "L", NameFirst = "Arthur", NameLast = "Rhodes",
                    BbrefId = "rhodear01", BirthCity = "Waco", BirthDay = 24, BirthCountry = "USA", BirthState = "TX",
                    BirthMonth = 10, BirthYear = 1969, Debut = "1991-08-21 00:00:00", FinalGame = "2011-09-27 00:00:00",
                    Height = 74, Weight = 220, RetroId = "rhoda001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "sasakka01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "sasakka01", Bats = "R", Throws = "R", NameFirst = "Kazuhiro", NameLast = "Sasaki",
                    BbrefId = "sasakka01", BirthCity = "Sendai", BirthDay = 22, BirthCountry = "Japan",
                    BirthState = "Miyagi", BirthMonth = 2, BirthYear = 1968, Debut = "2000-04-05 00:00:00",
                    FinalGame = "2003-09-28 00:00:00", Height = 76, Weight = 209, RetroId = "sasak001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "seleaa01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "seleaa01", Bats = "R", Throws = "R", NameFirst = "Aaron", NameLast = "Sele",
                    BbrefId = "seleaa01", BirthCity = "Golden Valley", BirthDay = 25, BirthCountry = "USA",
                    BirthState = "MN", BirthMonth = 6, BirthYear = 1970, Debut = "1993-06-23 00:00:00",
                    FinalGame = "2007-09-25 00:00:00", Height = 77, Weight = 205, RetroId = "selea001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "starkde01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "starkde01", Bats = "R", Throws = "R", NameFirst = "Denny", NameLast = "Stark",
                    BbrefId = "starkde01", BirthCity = "Hicksville", BirthDay = 27, BirthCountry = "USA",
                    BirthState = "OH", BirthMonth = 10, BirthYear = 1974, Debut = "1999-09-15 00:00:00",
                    FinalGame = "2009-06-02 00:00:00", Height = 74, Weight = 210, RetroId = "stard001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "tomkobr01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "tomkobr01", Bats = "R", Throws = "R", NameFirst = "Brett", NameLast = "Tomko",
                    BbrefId = "tomkobr01", BirthCity = "Cleveland", BirthDay = 7, BirthCountry = "USA",
                    BirthState = "OH", BirthMonth = 4, BirthYear = 1973, Debut = "1997-05-27 00:00:00",
                    FinalGame = "2011-05-24 00:00:00", Height = 76, Weight = 220, RetroId = "tomkb001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "bellda01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "bellda01", Bats = "R", Throws = "R", NameFirst = "David", NameLast = "Bell",
                    BbrefId = "bellda01", BirthCity = "Cincinnati", BirthDay = 14, BirthCountry = "USA",
                    BirthState = "OH", BirthMonth = 9, BirthYear = 1972, Debut = "1995-05-03 00:00:00",
                    FinalGame = "2006-10-01 00:00:00", Height = 70, Weight = 170, RetroId = "belld002"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "boonebr01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "boonebr01", Bats = "R", Throws = "R", NameFirst = "Bret", NameLast = "Boone",
                    BbrefId = "boonebr01", BirthCity = "El Cajon", BirthDay = 6, BirthCountry = "USA",
                    BirthState = "CA", BirthMonth = 4, BirthYear = 1969, Debut = "1992-08-19 00:00:00",
                    FinalGame = "2005-07-30 00:00:00", Height = 70, Weight = 180, RetroId = "boonb002"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "bordepa01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "bordepa01", Bats = "R", Throws = "R", NameFirst = "Pat", NameLast = "Borders",
                    BbrefId = "bordepa01", BirthCity = "Columbus", BirthDay = 14, BirthCountry = "USA",
                    BirthState = "OH", BirthMonth = 5, BirthYear = 1963, Debut = "1988-04-06 00:00:00",
                    FinalGame = "2005-07-27 00:00:00", Height = 74, Weight = 190, RetroId = "bordp001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "buhneja01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "buhneja01", Bats = "R", Throws = "R", NameFirst = "Jay", NameLast = "Buhner",
                    BbrefId = "buhneja01", BirthCity = "Louisville", BirthDay = 13, BirthCountry = "USA",
                    BirthState = "KY", BirthMonth = 8, BirthYear = 1964, Debut = "1987-09-11 00:00:00",
                    FinalGame = "2001-10-07 00:00:00", Height = 75, Weight = 220, RetroId = "buhnj001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "camermi01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "camermi01", Bats = "R", Throws = "R", NameFirst = "Mike", NameLast = "Cameron",
                    BbrefId = "camermi01", BirthCity = "La Grange", BirthDay = 8, BirthCountry = "USA",
                    BirthState = "GA", BirthMonth = 1, BirthYear = 1973, Debut = "1995-08-27 00:00:00",
                    FinalGame = "2011-09-12 00:00:00", Height = 74, Weight = 210, RetroId = "camem001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "gipsoch01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "gipsoch01", Bats = "R", Throws = "R", NameFirst = "Charles", NameLast = "Gipson",
                    BbrefId = "gipsoch01", BirthCity = "Orange", BirthDay = 16, BirthCountry = "USA", BirthState = "CA",
                    BirthMonth = 12, BirthYear = 1972, Debut = "1998-03-31 00:00:00", FinalGame = "2005-10-02 00:00:00",
                    Height = 74, Weight = 180, RetroId = "gipsc001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "guillca01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "guillca01", Bats = "B", Throws = "R", NameFirst = "Carlos", NameLast = "Guillen",
                    BbrefId = "guillca01", BirthCity = "Maracay", BirthDay = 30, BirthCountry = "Venezuela",
                    BirthState = "Aragua", BirthMonth = 9, BirthYear = 1975, Debut = "1998-09-06 00:00:00",
                    FinalGame = "2011-09-18 00:00:00", Height = 73, Weight = 215, RetroId = "guilc001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "javiest01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "javiest01", Bats = "B", Throws = "R", NameFirst = "Stan", NameLast = "Javier",
                    BbrefId = "javiest01", BirthCity = "San Francisco de Macoris", BirthDay = 9, BirthCountry = "D.R.",
                    BirthState = "Duarte", BirthMonth = 1, BirthYear = 1964, Debut = "1984-04-15 00:00:00",
                    FinalGame = "2001-10-06 00:00:00", Height = 72, Weight = 185, RetroId = "javis001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "kingsge01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "kingsge01", Bats = "B", Throws = "R", NameFirst = "Gene", NameLast = "Kingsale",
                    BbrefId = "kingsge01", BirthCity = "Solito", BirthDay = 20, BirthCountry = "Aruba", BirthMonth = 8,
                    BirthYear = 1976, Debut = "1996-09-03 00:00:00", FinalGame = "2003-06-08 00:00:00", Height = 75,
                    Weight = 190, RetroId = "kingg001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "lampkto01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "lampkto01", Bats = "L", Throws = "R", NameFirst = "Tom", NameLast = "Lampkin",
                    BbrefId = "lampkto01", BirthCity = "Cincinnati", BirthDay = 4, BirthCountry = "USA",
                    BirthState = "OH", BirthMonth = 3, BirthYear = 1964, Debut = "1988-09-10 00:00:00",
                    FinalGame = "2002-09-28 00:00:00", Height = 71, Weight = 180, RetroId = "lampt001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "martial03") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "martial03", Bats = "L", Throws = "L", NameFirst = "Al", NameLast = "Martin",
                    BbrefId = "martial03", BirthCity = "West Covina", BirthDay = 24, BirthCountry = "USA",
                    BirthState = "CA", BirthMonth = 11, BirthYear = 1967, Debut = "1992-07-28 00:00:00",
                    FinalGame = "2003-09-21 00:00:00", Height = 74, Weight = 220, RetroId = "marta001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "martied01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "martied01", Bats = "R", Throws = "R", NameFirst = "Edgar", NameLast = "Martinez",
                    BbrefId = "martied01", BirthCity = "New York", BirthDay = 2, BirthCountry = "USA",
                    BirthState = "NY", BirthMonth = 1, BirthYear = 1963, Debut = "1987-09-12 00:00:00",
                    FinalGame = "2004-10-03 00:00:00", Height = 72, Weight = 175, RetroId = "marte001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "mclemma01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "mclemma01", Bats = "B", Throws = "R", NameFirst = "Mark", NameLast = "McLemore",
                    BbrefId = "mclemma01", BirthCity = "San Diego", BirthDay = 4, BirthCountry = "USA",
                    BirthState = "CA", BirthMonth = 10, BirthYear = 1964, Debut = "1986-09-13 00:00:00",
                    FinalGame = "2004-10-02 00:00:00", Height = 71, Weight = 175, RetroId = "mclem001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "olerujo01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "olerujo01", Bats = "L", Throws = "L", NameFirst = "John", NameLast = "Olerud",
                    BbrefId = "olerujo01", BirthCity = "Seattle", BirthDay = 5, BirthCountry = "USA", BirthState = "WA",
                    BirthMonth = 8, BirthYear = 1968, Debut = "1989-09-03 00:00:00", FinalGame = "2005-10-02 00:00:00",
                    Height = 77, Weight = 205, RetroId = "olerj001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "podsesc01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "podsesc01", Bats = "L", Throws = "L", NameFirst = "Scott", NameLast = "Podsednik",
                    BbrefId = "podsesc01", BirthCity = "West", BirthDay = 18, BirthCountry = "USA", BirthState = "TX",
                    BirthMonth = 3, BirthYear = 1976, Debut = "2001-07-06 00:00:00", FinalGame = "2012-10-03 00:00:00",
                    Height = 72, Weight = 185, RetroId = "podss001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "sandean01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "sandean01", Bats = "R", Throws = "R", NameFirst = "Anthony", NameLast = "Sanders",
                    BbrefId = "sandean01", BirthCity = "Tucson", BirthDay = 2, BirthCountry = "USA", BirthState = "AZ",
                    BirthMonth = 3, BirthYear = 1974, Debut = "1999-04-26 00:00:00", FinalGame = "2001-04-18 00:00:00",
                    Height = 74, Weight = 200, RetroId = "sanda001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "spraged02") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "spraged02", Bats = "R", Throws = "R", NameFirst = "Ed", NameLast = "Sprague",
                    BbrefId = "spraged02", BirthCity = "Castro Valley", BirthDay = 25, BirthCountry = "USA",
                    BirthState = "CA", BirthMonth = 7, BirthYear = 1967, Debut = "1991-05-07 00:00:00",
                    FinalGame = "2001-10-07 00:00:00", Height = 74, Weight = 215, RetroId = "sprae001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "suzukic01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "suzukic01", Bats = "L", Throws = "R", NameFirst = "Ichiro", NameLast = "Suzuki",
                    BbrefId = "suzukic01", BirthCity = "Nichi Kasugai-gun", BirthDay = 22, BirthCountry = "Japan",
                    BirthState = "Aichi", BirthMonth = 10, BirthYear = 1973, Debut = "2001-04-02 00:00:00",
                    FinalGame = "2018-05-02 00:00:00", Height = 71, Weight = 175, RetroId = "suzui001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "vazqura01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "vazqura01", Bats = "L", Throws = "R", NameFirst = "Ramon", NameLast = "Vazquez",
                    BbrefId = "vazqura01", BirthCity = "Aibonito", BirthDay = 21, BirthCountry = "P.R.", BirthMonth = 8,
                    BirthYear = 1976, Debut = "2001-09-07 00:00:00", FinalGame = "2009-10-04 00:00:00", Height = 71,
                    Weight = 195, RetroId = "vazqr001"
                });
            }

            if (dbContext.People.Count(m => m.PlayerId == "wilsoda01") == 0)
            {
                dbContext.People.Add(new Person()
                {
                    PlayerId = "wilsoda01", Bats = "R", Throws = "R", NameFirst = "Dan", NameLast = "Wilson",
                    BbrefId = "wilsoda01", BirthCity = "Arlington Heights", BirthDay = 25, BirthCountry = "USA",
                    BirthState = "IL", BirthMonth = 3, BirthYear = 1969, Debut = "1992-09-07 00:00:00",
                    FinalGame = "2005-09-30 00:00:00", Height = 75, Weight = 190, RetroId = "wilsd001"
                });
            }

            dbContext.SaveChanges();
        }

        public static void BulkPitchingPlayerInsert(LahmansDbContext dbContext)
        {
            if (dbContext.Pitching.Count(m => m.PlayerId == "abbotpa01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "abbotpa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 17, L = 4,
                    G = 28, Gs = 27, Cg = 1, Sho = 0, Sv = 0, Ipouts = 489, H = 145, Er = 77, Hr = 21, Bb = 87,
                    So = 118, Baopp = 238, Era = 425, Ibb = 5, Wp = 11, Hbp = 7, Bk = 0, Bfp = 710, Gf = 0, R = 79,
                    Sh = 3, Sf = 5, Gidp = 11
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "charlno01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "charlno01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 4, L = 2, G = 44,
                    Gs = 0, Cg = 0, Sho = 0, Sv = 1, Ipouts = 143, H = 36, Er = 16, Hr = 4, Bb = 11, So = 48,
                    Baopp = 212, Era = 302, Ibb = 0, Wp = 4, Hbp = 4, Bk = 0, Bfp = 189, Gf = 10, R = 19, Sh = 3,
                    Sf = 1, Gidp = 3
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "frankry01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "frankry01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 5, L = 1, G = 38,
                    Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 235, H = 76, Er = 31, Hr = 13, Bb = 24, So = 60,
                    Baopp = 250, Era = 356, Ibb = 4, Wp = 2, Hbp = 4, Bk = 0, Bfp = 335, Gf = 14, R = 32, Sh = 1,
                    Sf = 2, Gidp = 5
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "fuentbr01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "fuentbr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 1, L = 1, G = 10,
                    Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 35, H = 6, Er = 6, Hr = 2, Bb = 8, So = 10, Baopp = 171,
                    Era = 463, Ibb = 0, Wp = 1, Hbp = 3, Bk = 0, Bfp = 47, Gf = 3, R = 6, Sh = 0, Sf = 1, Gidp = 4
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "garcifr02") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "garcifr02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 18, L = 6,
                    G = 34, Gs = 34, Cg = 4, Sho = 3, Sv = 0, Ipouts = 716, H = 199, Er = 81, Hr = 16, Bb = 69,
                    So = 163, Baopp = 225, Era = 305, Ibb = 6, Wp = 3, Hbp = 5, Bk = 1, Bfp = 971, Gf = 0, R = 88,
                    Sh = 8, Sf = 5, Gidp = 23
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "halamjo01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "halamjo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 10, L = 7,
                    G = 31, Gs = 17, Cg = 0, Sho = 0, Sv = 0, Ipouts = 331, H = 132, Er = 58, Hr = 18, Bb = 26, So = 50,
                    Baopp = 296, Era = 473, Ibb = 0, Wp = 2, Hbp = 6, Bk = 0, Bfp = 485, Gf = 6, R = 69, Sh = 3, Sf = 4,
                    Gidp = 11
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "moyerja01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "moyerja01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 20, L = 6,
                    G = 33, Gs = 33, Cg = 1, Sho = 0, Sv = 0, Ipouts = 629, H = 187, Er = 80, Hr = 24, Bb = 44,
                    So = 119, Baopp = 239, Era = 343, Ibb = 4, Wp = 1, Hbp = 10, Bk = 0, Bfp = 851, Gf = 0, R = 84,
                    Sh = 5, Sf = 11, Gidp = 14
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "nelsoje01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "nelsoje01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 4, L = 3, G = 69,
                    Gs = 0, Cg = 0, Sho = 0, Sv = 4, Ipouts = 196, H = 30, Er = 20, Hr = 3, Bb = 44, So = 88,
                    Baopp = 136, Era = 276, Ibb = 1, Wp = 2, Hbp = 6, Bk = 0, Bfp = 273, Gf = 16, R = 21, Sh = 2,
                    Sf = 0, Gidp = 7
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "paniajo01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "paniajo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 4, L = 3, G = 60,
                    Gs = 0, Cg = 0, Sho = 0, Sv = 3, Ipouts = 198, H = 59, Er = 32, Hr = 7, Bb = 38, So = 46,
                    Baopp = 233, Era = 436, Ibb = 2, Wp = 3, Hbp = 4, Bk = 0, Bfp = 296, Gf = 24, R = 35, Sh = 0,
                    Sf = 1, Gidp = 6
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "pineijo01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "pineijo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 6, L = 2, G = 17,
                    Gs = 11, Cg = 0, Sho = 0, Sv = 0, Ipouts = 226, H = 50, Er = 17, Hr = 2, Bb = 21, So = 56,
                    Baopp = 191, Era = 203, Ibb = 0, Wp = 2, Hbp = 3, Bk = 0, Bfp = 289, Gf = 1, R = 24, Sh = 1, Sf = 2,
                    Gidp = 6
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "rhodear01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "rhodear01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 8, L = 0, G = 71,
                    Gs = 0, Cg = 0, Sho = 0, Sv = 3, Ipouts = 204, H = 46, Er = 13, Hr = 5, Bb = 12, So = 83,
                    Baopp = 189, Era = 172, Ibb = 0, Wp = 3, Hbp = 1, Bk = 0, Bfp = 258, Gf = 16, R = 14, Sh = 1,
                    Sf = 0, Gidp = 1
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "sasakka01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "sasakka01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 0, L = 4, G = 69,
                    Gs = 0, Cg = 0, Sho = 0, Sv = 45, Ipouts = 200, H = 48, Er = 24, Hr = 6, Bb = 11, So = 62,
                    Baopp = 195, Era = 324, Ibb = 2, Wp = 4, Hbp = 4, Bk = 0, Bfp = 261, Gf = 63, R = 24, Sh = 0,
                    Sf = 0, Gidp = 4
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "seleaa01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "seleaa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 15, L = 5, G = 34,
                    Gs = 33, Cg = 2, Sho = 1, Sv = 0, Ipouts = 645, H = 216, Er = 86, Hr = 25, Bb = 51, So = 114,
                    Baopp = 261, Era = 360, Ibb = 2, Wp = 1, Hbp = 7, Bk = 0, Bfp = 899, Gf = 0, R = 93, Sh = 5, Sf = 9,
                    Gidp = 18
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "starkde01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "starkde01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 1, L = 1, G = 4,
                    Gs = 3, Cg = 0, Sho = 0, Sv = 0, Ipouts = 44, H = 21, Er = 15, Hr = 5, Bb = 4, So = 12, Baopp = 333,
                    Era = 920, Ibb = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 68, Gf = 0, R = 15, Sh = 0, Sf = 1, Gidp = 1
                });
            }

            if (dbContext.Pitching.Count(m => m.PlayerId == "tomkobr01") == 0)
            {
                dbContext.Pitching.Add(new Pitching()
                {
                    PlayerId = "tomkobr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", W = 3, L = 1, G = 11,
                    Gs = 4, Cg = 0, Sho = 0, Sv = 0, Ipouts = 104, H = 42, Er = 20, Hr = 9, Bb = 15, So = 22,
                    Baopp = 288, Era = 519, Ibb = 2, Wp = 1, Hbp = 0, Bk = 0, Bfp = 164, Gf = 1, R = 24, Sh = 1, Sf = 2,
                    Gidp = 1
                });
            }

            dbContext.SaveChanges();
        }

        public static void BulkBattingPlayerInsert(LahmansDbContext dbContext)
        {
            if (dbContext.Batting.Count(m => m.PlayerId == "abbotpa01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "abbotpa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 28, Ab = 4,
                    R = 0, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0,
                    Sh = 1, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "bellda01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "bellda01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 135, Ab = 470,
                    R = 62, _2b = 28, _3b = 0, H = 122, Hr = 15, Rbi = 64, Sb = 2, Cs = 1, Bb = 28, So = 59, Ibb = 1,
                    Hbp = 3, Sh = 5, Sf = 4, Gidp = 8,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "boonebr01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "boonebr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 158, Ab = 623,
                    R = 118, _2b = 37, _3b = 3, H = 206, Hr = 37, Rbi = 141, Sb = 5, Cs = 5, Bb = 40, So = 110, Ibb = 5,
                    Hbp = 9, Sh = 5, Sf = 13, Gidp = 11,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "bordepa01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "bordepa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 5, Ab = 6, R = 1,
                    _2b = 0, _3b = 0, H = 3, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 1,
                    Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "buhneja01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "buhneja01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 19, Ab = 45,
                    R = 4, _2b = 2, _3b = 0, H = 10, Hr = 2, Rbi = 5, Sb = 0, Cs = 0, Bb = 8, So = 9, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 3,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "camermi01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "camermi01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 150, Ab = 540,
                    R = 99, _2b = 30, _3b = 5, H = 144, Hr = 25, Rbi = 110, Sb = 34, Cs = 5, Bb = 69, So = 155, Ibb = 3,
                    Hbp = 10, Sh = 1, Sf = 13, Gidp = 13,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "charlno01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "charlno01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 44, Ab = 0,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "frankry01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "frankry01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 38, Ab = 0,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "fuentbr01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "fuentbr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 10, Ab = 0,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "garcifr02") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "garcifr02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 34, Ab = 7,
                    R = 0, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 4, Ibb = 0, Hbp = 0,
                    Sh = 2, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "gipsoch01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "gipsoch01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 94, Ab = 64,
                    R = 16, _2b = 2, _3b = 2, H = 14, Hr = 0, Rbi = 5, Sb = 1, Cs = 1, Bb = 4, So = 20, Ibb = 0,
                    Hbp = 2, Sh = 1, Sf = 1, Gidp = 2,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "guillca01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "guillca01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 140, Ab = 456,
                    R = 72, _2b = 21, _3b = 4, H = 118, Hr = 5, Rbi = 53, Sb = 4, Cs = 1, Bb = 53, So = 89, Ibb = 0,
                    Hbp = 1, Sh = 7, Sf = 6, Gidp = 9,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "halamjo01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "halamjo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 31, Ab = 1,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 1, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "javiest01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "javiest01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 89, Ab = 281,
                    R = 44, _2b = 14, _3b = 1, H = 82, Hr = 4, Rbi = 33, Sb = 11, Cs = 1, Bb = 36, So = 47, Ibb = 1,
                    Hbp = 2, Sh = 3, Sf = 1, Gidp = 8,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "kingsge01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "kingsge01", YearId = 2001, Stint = 2, TeamId = "SEA", LgId = "AL", G = 10, Ab = 15,
                    R = 4, _2b = 0, _3b = 0, H = 5, Hr = 0, Rbi = 1, Sb = 2, Cs = 0, Bb = 2, So = 2, Ibb = 0, Hbp = 1,
                    Sh = 0, Sf = 0, Gidp = 1,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "lampkto01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "lampkto01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 79, Ab = 204,
                    R = 28, _2b = 10, _3b = 0, H = 46, Hr = 5, Rbi = 22, Sb = 1, Cs = 0, Bb = 18, So = 41, Ibb = 1,
                    Hbp = 7, Sh = 1, Sf = 1, Gidp = 4,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "martial03") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "martial03", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 100, Ab = 283,
                    R = 41, _2b = 15, _3b = 2, H = 68, Hr = 7, Rbi = 42, Sb = 9, Cs = 3, Bb = 37, So = 59, Ibb = 4,
                    Hbp = 2, Sh = 0, Sf = 2, Gidp = 2,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "martied01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "martied01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 132, Ab = 470,
                    R = 80, _2b = 40, _3b = 1, H = 144, Hr = 23, Rbi = 116, Sb = 4, Cs = 1, Bb = 93, So = 90, Ibb = 9,
                    Hbp = 9, Sh = 0, Sf = 9, Gidp = 11,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "mclemma01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "mclemma01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 125, Ab = 409,
                    R = 78, _2b = 16, _3b = 9, H = 117, Hr = 5, Rbi = 57, Sb = 39, Cs = 7, Bb = 69, So = 84, Ibb = 0,
                    Hbp = 0, Sh = 3, Sf = 6, Gidp = 6,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "moyerja01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "moyerja01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 33, Ab = 1,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 1, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "nelsoje01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "nelsoje01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 69, Ab = 0,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "olerujo01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "olerujo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 159, Ab = 572,
                    R = 91, _2b = 32, _3b = 1, H = 173, Hr = 21, Rbi = 95, Sb = 3, Cs = 1, Bb = 94, So = 70, Ibb = 19,
                    Hbp = 5, Sh = 1, Sf = 7, Gidp = 21,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "paniajo01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "paniajo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 60, Ab = 1,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "pineijo01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "pineijo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 17, Ab = 0,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "podsesc01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "podsesc01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 5, Ab = 6, R = 1,
                    _2b = 0, _3b = 1, H = 1, Hr = 0, Rbi = 3, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0, Sh = 0,
                    Sf = 0, Gidp = 1,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "rhodear01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "rhodear01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 72, Ab = 1,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 1, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "sandean01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "sandean01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 9, Ab = 17,
                    R = 1, _2b = 2, _3b = 0, H = 3, Hr = 0, Rbi = 2, Sb = 0, Cs = 0, Bb = 2, So = 3, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "sasakka01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "sasakka01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 69, Ab = 0,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "seleaa01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "seleaa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 34, Ab = 6, R = 2,
                    _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 2,
                    Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "spraged02") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "spraged02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 45, Ab = 94,
                    R = 9, _2b = 7, _3b = 0, H = 28, Hr = 2, Rbi = 16, Sb = 0, Cs = 0, Bb = 11, So = 18, Ibb = 1,
                    Hbp = 1, Sh = 0, Sf = 1, Gidp = 3,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "starkde01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "starkde01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 4, Ab = 0, R = 0,
                    _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0, Sh = 0,
                    Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "suzukic01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "suzukic01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 157, Ab = 692,
                    R = 127, _2b = 34, _3b = 8, H = 242, Hr = 8, Rbi = 69, Sb = 56, Cs = 14, Bb = 30, So = 53, Ibb = 10,
                    Hbp = 8, Sh = 4, Sf = 4, Gidp = 3,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "tomkobr01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "tomkobr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 11, Ab = 0,
                    R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Ibb = 0, Hbp = 0,
                    Sh = 0, Sf = 0, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "vazqura01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "vazqura01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 17, Ab = 35,
                    R = 5, _2b = 0, _3b = 0, H = 8, Hr = 0, Rbi = 4, Sb = 0, Cs = 0, Bb = 0, So = 3, Ibb = 0, Hbp = 0,
                    Sh = 1, Sf = 1, Gidp = 0,
                });
            }

            if (dbContext.Batting.Count(m => m.PlayerId == "wilsoda01") == 0)
            {
                dbContext.Batting.Add(new Batting()
                {
                    PlayerId = "wilsoda01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", G = 123, Ab = 377,
                    R = 44, _2b = 20, _3b = 1, H = 100, Hr = 10, Rbi = 42, Sb = 3, Cs = 2, Bb = 20, So = 69, Ibb = 0,
                    Hbp = 2, Sh = 8, Sf = 1, Gidp = 6,
                });
            }

            dbContext.SaveChanges();
        }

        public static void BulkFieldingPlayerInsert(LahmansDbContext dbContext)
        {
            if (dbContext.Fielding.Count(m => m.PlayerId == "abbotpa01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "abbotpa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 28,
                    Gs = 27, InnOuts = 489, Po = 16, A = 13, E = 0, Dp = 3,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "bellda01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "bellda01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "1B", G = 2,
                    Gs = 1, InnOuts = 24, Po = 6, A = 0, E = 0, Dp = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "bellda01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "bellda01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "3B", G = 134,
                    Gs = 120, InnOuts = 3384, Po = 92, A = 257, E = 14, Dp = 21,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "boonebr01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "boonebr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "2B", G = 156,
                    Gs = 152, InnOuts = 4110, Po = 286, A = 409, E = 10, Dp = 90,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "bordepa01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "bordepa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "C", G = 5,
                    Gs = 1, InnOuts = 57, Po = 10, A = 2, E = 1, Dp = 0, Pb = 0, Sb = 1, Cs = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "buhneja01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "buhneja01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 12,
                    Gs = 10, InnOuts = 219, Po = 15, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "camermi01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "camermi01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 149,
                    Gs = 140, InnOuts = 3817, Po = 410, A = 8, E = 6, Dp = 2,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "charlno01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "charlno01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 44,
                    Gs = 0, InnOuts = 143, Po = 6, A = 6, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "frankry01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "frankry01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 38,
                    Gs = 0, InnOuts = 235, Po = 8, A = 6, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "fuentbr01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "fuentbr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 10,
                    Gs = 0, InnOuts = 35, Po = 1, A = 3, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "garcifr02") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "garcifr02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 34,
                    Gs = 34, InnOuts = 716, Po = 29, A = 39, E = 1, Dp = 5,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "gipsoch01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "gipsoch01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "2B", G = 1,
                    Gs = 0, InnOuts = 9, Po = 0, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "gipsoch01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "gipsoch01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "3B", G = 9,
                    Gs = 2, InnOuts = 93, Po = 2, A = 6, E = 1, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "gipsoch01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "gipsoch01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 65,
                    Gs = 8, InnOuts = 511, Po = 40, A = 1, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "gipsoch01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "gipsoch01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "SS", G = 6,
                    Gs = 4, InnOuts = 99, Po = 9, A = 11, E = 1, Dp = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "guillca01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "guillca01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "SS", G = 137,
                    Gs = 123, InnOuts = 3360, Po = 187, A = 313, E = 10, Dp = 75,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "halamjo01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "halamjo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 31,
                    Gs = 17, InnOuts = 331, Po = 9, A = 21, E = 1, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "javiest01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "javiest01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "1B", G = 6,
                    Gs = 5, InnOuts = 120, Po = 26, A = 3, E = 0, Dp = 4,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "javiest01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "javiest01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 76,
                    Gs = 61, InnOuts = 1643, Po = 139, A = 1, E = 1, Dp = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "kingsge01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "kingsge01", YearId = 2001, Stint = 2, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 9,
                    Gs = 3, InnOuts = 126, Po = 12, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "lampkto01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "lampkto01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "C", G = 71,
                    Gs = 56, InnOuts = 1512, Po = 375, A = 23, E = 2, Dp = 2, Pb = 3, Sb = 26, Cs = 10,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "lampkto01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "lampkto01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 1,
                    Gs = 0, InnOuts = 9, Po = 0, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "martial03") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "martial03", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 73,
                    Gs = 71, InnOuts = 1538, Po = 132, A = 3, E = 4, Dp = 2,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "martied01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "martied01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "1B", G = 1,
                    Gs = 1, InnOuts = 15, Po = 8, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "mclemma01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "mclemma01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "2B", G = 9,
                    Gs = 8, InnOuts = 192, Po = 18, A = 17, E = 2, Dp = 8,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "mclemma01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "mclemma01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "3B", G = 36,
                    Gs = 32, InnOuts = 735, Po = 25, A = 48, E = 7, Dp = 3,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "mclemma01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "mclemma01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 68,
                    Gs = 30, InnOuts = 1036, Po = 81, A = 3, E = 1, Dp = 2,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "mclemma01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "mclemma01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "SS", G = 35,
                    Gs = 30, InnOuts = 786, Po = 41, A = 79, E = 2, Dp = 20,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "moyerja01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "moyerja01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 33,
                    Gs = 33, InnOuts = 629, Po = 17, A = 27, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "nelsoje01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "nelsoje01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 69,
                    Gs = 0, InnOuts = 196, Po = 2, A = 6, E = 2, Dp = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "olerujo01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "olerujo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "1B", G = 158,
                    Gs = 149, InnOuts = 4043, Po = 1211, A = 121, E = 9, Dp = 116,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "paniajo01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "paniajo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 60,
                    Gs = 0, InnOuts = 198, Po = 2, A = 3, E = 1, Dp = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "pineijo01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "pineijo01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 17,
                    Gs = 11, InnOuts = 226, Po = 4, A = 4, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "podsesc01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "podsesc01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 5,
                    Gs = 1, InnOuts = 54, Po = 3, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "rhodear01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "rhodear01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 71,
                    Gs = 0, InnOuts = 204, Po = 4, A = 9, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "sandean01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "sandean01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 9,
                    Gs = 6, InnOuts = 138, Po = 13, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "sasakka01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "sasakka01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 69,
                    Gs = 0, InnOuts = 200, Po = 6, A = 2, E = 1, Dp = 2,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "seleaa01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "seleaa01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 34,
                    Gs = 33, InnOuts = 645, Po = 15, A = 17, E = 1, Dp = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "spraged02") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "spraged02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "1B", G = 12,
                    Gs = 6, InnOuts = 187, Po = 51, A = 2, E = 1, Dp = 4,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "spraged02") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "spraged02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "3B", G = 8,
                    Gs = 7, InnOuts = 162, Po = 5, A = 11, E = 1, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "spraged02") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "spraged02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "C", G = 1,
                    Gs = 0, InnOuts = 3, Po = 1, A = 0, E = 0, Dp = 0, Pb = 0, Sb = 0, Cs = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "spraged02") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "spraged02", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 9,
                    Gs = 8, InnOuts = 153, Po = 11, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "starkde01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "starkde01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 4,
                    Gs = 3, InnOuts = 44, Po = 2, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "suzukic01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "suzukic01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "OF", G = 152,
                    Gs = 148, InnOuts = 3941, Po = 335, A = 8, E = 1, Dp = 2,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "tomkobr01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "tomkobr01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "P", G = 11,
                    Gs = 4, InnOuts = 104, Po = 2, A = 3, E = 0, Dp = 1,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "vazqura01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "vazqura01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "2B", G = 6,
                    Gs = 2, InnOuts = 84, Po = 3, A = 7, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "vazqura01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "vazqura01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "3B", G = 2,
                    Gs = 1, InnOuts = 21, Po = 0, A = 1, E = 1, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "vazqura01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "vazqura01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "SS", G = 10,
                    Gs = 5, InnOuts = 150, Po = 11, A = 9, E = 0, Dp = 3,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "wilsoda01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "wilsoda01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "1B", G = 2,
                    Gs = 0, InnOuts = 6, Po = 3, A = 0, E = 0, Dp = 0,
                });
            }

            if (dbContext.Fielding.Count(m => m.PlayerId == "wilsoda01") == 0)
            {
                dbContext.Fielding.Add(new Fielding()
                {
                    PlayerId = "wilsoda01", YearId = 2001, Stint = 1, TeamId = "SEA", LgId = "AL", Pos = "C", G = 122,
                    Gs = 105, InnOuts = 2823, Po = 711, A = 32, E = 1, Dp = 1, Pb = 3, Sb = 46, Cs = 18,
                });
            }

            dbContext.SaveChanges();
        }
    }
}