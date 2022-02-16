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
    public partial class AllTimeBestPlayerData
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
            if (dbContext.People.Count(m => m.PlayerId == "cobbty01") == 0)
            {
                dbContext.People.Add(new Person() { PlayerId = "cobbty01", Bats = "L", Throws = "R", NameFirst = "Ty", NameLast = "Cobb", BbrefId = "cobbty01", BirthCity = "Narrows", BirthDay = 18, BirthCountry = "USA", BirthState = "GA", BirthMonth = 12, BirthYear = 1886, DeathMonth = 7, DeathDay = 17, DeathCountry = "USA", DeathState = "GA", DeathCity = "Atlanta", Debut = "1905-08-30", FinalGame = "1928-09-11", Height = 73, Weight = 175, RetroId = "cobbt101" });
            }
            if (dbContext.People.Count(m => m.PlayerId == "musiast01") == 0)
            {
                dbContext.People.Add(new Person() { PlayerId = "musiast01", Bats = "L", Throws = "L", NameFirst = "Stan", NameLast = "Musial", BbrefId = "musiast01", BirthCity = "Donora", BirthDay = 21, BirthCountry = "USA", BirthState = "PA", BirthMonth = 11, BirthYear = 1920, DeathMonth = 1, DeathDay = 19, DeathCountry = "USA", DeathState = "MO", DeathCity = "Ladue", Debut = "1941-09-17", FinalGame = "1963-09-29", Height = 72, Weight = 175, RetroId = "musis101" });
            }
            if (dbContext.People.Count(m => m.PlayerId == "ruthba01") == 0)
            {
                dbContext.People.Add(new Person() { PlayerId = "ruthba01", Bats = "L", Throws = "L", NameFirst = "Babe", NameLast = "Ruth", BbrefId = "ruthba01", BirthCity = "Baltimore", BirthDay = 6, BirthCountry = "USA", BirthState = "MD", BirthMonth = 2, BirthYear = 1895, DeathMonth = 8, DeathDay = 16, DeathCountry = "USA", DeathState = "NY", DeathCity = "New York", Debut = "1914-07-11", FinalGame = "1935-05-30", Height = 74, Weight = 215, RetroId = "ruthb101" });
            }
            if (dbContext.People.Count(m => m.PlayerId == "aaronha01") == 0)
            {
                dbContext.People.Add(new Person() { PlayerId = "aaronha01", Bats = "R", Throws = "R", NameFirst = "Hank", NameLast = "Aaron", BbrefId = "aaronha01", BirthCity = "Mobile", BirthDay = 5, BirthCountry = "USA", BirthState = "AL", BirthMonth = 2, BirthYear = 1934, Debut = "1954-04-13", FinalGame = "1976-10-03", Height = 72, Weight = 180, RetroId = "aaroh101" });
            }
            if (dbContext.People.Count(m => m.PlayerId == "collied02") == 0)
            {
                dbContext.People.Add(new Person() { PlayerId = "collied02", Bats = "L", Throws = "R", NameFirst = "Eddie", NameLast = "Collins", BbrefId = "collied02", BirthCity = "Lansdowne", BirthDay = 23, BirthCountry = "USA", BirthState = "PA", BirthMonth = 11, BirthYear = 1916, DeathMonth = 11, DeathDay = 2, DeathCountry = "USA", DeathState = "PA", DeathCity = "Jennersville", Debut = "1939-07-04", FinalGame = "1942-05-26", Height = 70, Weight = 175, RetroId = "colle102" });
            }
            if (dbContext.People.Count(m => m.PlayerId == "gehrilo01") == 0)
            {
                dbContext.People.Add(new Person() { PlayerId = "gehrilo01", Bats = "L", Throws = "L", NameFirst = "Lou", NameLast = "Gehrig", BbrefId = "gehrilo01", BirthCity = "New York", BirthDay = 19, BirthCountry = "USA", BirthState = "NY", BirthMonth = 6, BirthYear = 1903, DeathMonth = 6, DeathDay = 2, DeathCountry = "USA", DeathState = "NY", DeathCity = "Bronx", Debut = "1923-06-15", FinalGame = "1939-04-30", Height = 72, Weight = 200, RetroId = "gehrl101" });
            }
            if (dbContext.People.Count(m => m.PlayerId == "mayswi01") == 0)
            {
                dbContext.People.Add(new Person() { PlayerId = "mayswi01", Bats = "R", Throws = "R", NameFirst = "Willie", NameLast = "Mays", BbrefId = "mayswi01", BirthCity = "Westfield", BirthDay = 6, BirthCountry = "USA", BirthState = "AL", BirthMonth = 5, BirthYear = 1931, Debut = "1951-05-25", FinalGame = "1973-09-09", Height = 70, Weight = 170, RetroId = "maysw101" });
            }
            dbContext.SaveChanges();
        }

        public static void BulkPitchingPlayerInsert(LahmansDbContext dbContext)
        {
            dbContext.Pitching.Add(new Pitching() { PlayerId = "cobbty01", YearId = 1918, Stint = 1, TeamId = "DET", LgId = "AL", W = 0, L = 0, G = 2, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 12, H = 6, Er = 2, Hr = 0, Bb = 2, So = 0, Baopp = 0.4, Era = 4.5, Wp = 0, Hbp = 0, Bk = 0, Bfp = 17, Gf = 1, R = 2, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "cobbty01", YearId = 1925, Stint = 1, TeamId = "DET", LgId = "AL", W = 0, L = 0, G = 1, Gs = 0, Cg = 0, Sho = 0, Sv = 1, Ipouts = 3, H = 0, Er = 0, Hr = 0, Bb = 0, So = 0, Baopp = 0, Era = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 3, Gf = 1, R = 0, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "musiast01", YearId = 1952, Stint = 1, TeamId = "SLN", LgId = "NL", W = 0, L = 0, G = 1, Gs = 0, Cg = 0, Sho = 0, Sv = 0, Ipouts = 0, H = 0, Er = 0, Hr = 0, Bb = 0, So = 0, Baopp = 0, Wp = 0, Hbp = 0, Bk = 0, Bfp = 1, Gf = 0, R = 0, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1914, Stint = 1, TeamId = "BOS", LgId = "AL", W = 2, L = 1, G = 4, Gs = 3, Cg = 1, Sho = 0, Sv = 0, Ipouts = 69, H = 21, Er = 10, Hr = 1, Bb = 7, So = 3, Baopp = 0.23, Era = 3.91, Wp = 0, Hbp = 0, Bk = 0, Bfp = 100, Gf = 0, R = 12, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1915, Stint = 1, TeamId = "BOS", LgId = "AL", W = 18, L = 8, G = 32, Gs = 28, Cg = 16, Sho = 1, Sv = 0, Ipouts = 653, H = 166, Er = 59, Hr = 3, Bb = 85, So = 112, Baopp = 0.21, Era = 2.44, Wp = 9, Hbp = 6, Bk = 1, Bfp = 895, Gf = 3, R = 80, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1916, Stint = 1, TeamId = "BOS", LgId = "AL", W = 23, L = 12, G = 44, Gs = 41, Cg = 23, Sho = 9, Sv = 1, Ipouts = 971, H = 230, Er = 63, Hr = 0, Bb = 118, So = 170, Baopp = 0.2, Era = 1.75, Wp = 3, Hbp = 8, Bk = 1, Bfp = 1300, Gf = 3, R = 83, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1917, Stint = 1, TeamId = "BOS", LgId = "AL", W = 24, L = 13, G = 41, Gs = 38, Cg = 35, Sho = 6, Sv = 2, Ipouts = 979, H = 244, Er = 73, Hr = 2, Bb = 108, So = 128, Baopp = 0.21, Era = 2.01, Wp = 5, Hbp = 11, Bk = 0, Bfp = 1313, Gf = 2, R = 91, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1918, Stint = 1, TeamId = "BOS", LgId = "AL", W = 13, L = 7, G = 20, Gs = 19, Cg = 18, Sho = 1, Sv = 0, Ipouts = 499, H = 125, Er = 41, Hr = 1, Bb = 49, So = 40, Baopp = 0.21, Era = 2.22, Wp = 3, Hbp = 2, Bk = 1, Bfp = 660, Gf = 0, R = 51, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1919, Stint = 1, TeamId = "BOS", LgId = "AL", W = 9, L = 5, G = 17, Gs = 15, Cg = 12, Sho = 0, Sv = 1, Ipouts = 400, H = 148, Er = 44, Hr = 2, Bb = 58, So = 30, Baopp = 0.29, Era = 2.97, Wp = 5, Hbp = 2, Bk = 1, Bfp = 591, Gf = 2, R = 59, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1920, Stint = 1, TeamId = "NYA", LgId = "AL", W = 1, L = 0, G = 1, Gs = 1, Cg = 0, Sho = 0, Sv = 0, Ipouts = 12, H = 3, Er = 2, Hr = 0, Bb = 2, So = 0, Baopp = 0.2, Era = 4.5, Wp = 0, Hbp = 0, Bk = 0, Bfp = 17, Gf = 0, R = 4, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1921, Stint = 1, TeamId = "NYA", LgId = "AL", W = 2, L = 0, G = 2, Gs = 1, Cg = 0, Sho = 0, Sv = 0, Ipouts = 27, H = 14, Er = 9, Hr = 1, Bb = 9, So = 2, Baopp = 0.35, Era = 9, Wp = 0, Hbp = 0, Bk = 0, Bfp = 49, Gf = 1, R = 10, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1930, Stint = 1, TeamId = "NYA", LgId = "AL", W = 1, L = 0, G = 1, Gs = 1, Cg = 1, Sho = 0, Sv = 0, Ipouts = 27, H = 11, Er = 3, Hr = 0, Bb = 2, So = 3, Baopp = 0.3, Era = 3, Wp = 0, Hbp = 0, Bk = 0, Bfp = 39, Gf = 0, R = 3, });
            dbContext.Pitching.Add(new Pitching() { PlayerId = "ruthba01", YearId = 1933, Stint = 1, TeamId = "NYA", LgId = "AL", W = 1, L = 0, G = 1, Gs = 1, Cg = 1, Sho = 0, Sv = 0, Ipouts = 27, H = 12, Er = 5, Hr = 0, Bb = 3, So = 0, Baopp = 0.3, Era = 5, Wp = 0, Hbp = 0, Bk = 0, Bfp = 42, Gf = 0, R = 5, });
            dbContext.SaveChanges();
        }

        public static void BulkBattingPlayerInsert(LahmansDbContext dbContext)
        {
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1954, Stint = 1, TeamId = "ML1", LgId = "NL", G = 122, Ab = 468, R = 58, _2b = 27, _3b = 6, H = 131, Hr = 13, Rbi = 69, Sb = 2, Cs = 2, Bb = 28, So = 39, Hbp = 3, Sh = 6, Sf = 4, Gidp = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1955, Stint = 1, TeamId = "ML1", LgId = "NL", G = 153, Ab = 602, R = 105, _2b = 37, _3b = 9, H = 189, Hr = 27, Rbi = 106, Sb = 3, Cs = 1, Bb = 49, So = 61, Ibb = 5, Hbp = 3, Sh = 7, Sf = 4, Gidp = 20, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1956, Stint = 1, TeamId = "ML1", LgId = "NL", G = 153, Ab = 609, R = 106, _2b = 34, _3b = 14, H = 200, Hr = 26, Rbi = 92, Sb = 2, Cs = 4, Bb = 37, So = 54, Ibb = 6, Hbp = 2, Sh = 5, Sf = 7, Gidp = 21, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1957, Stint = 1, TeamId = "ML1", LgId = "NL", G = 151, Ab = 615, R = 118, _2b = 27, _3b = 6, H = 198, Hr = 44, Rbi = 132, Sb = 1, Cs = 1, Bb = 57, So = 58, Ibb = 15, Hbp = 0, Sh = 0, Sf = 3, Gidp = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1958, Stint = 1, TeamId = "ML1", LgId = "NL", G = 153, Ab = 601, R = 109, _2b = 34, _3b = 4, H = 196, Hr = 30, Rbi = 95, Sb = 4, Cs = 1, Bb = 59, So = 49, Ibb = 16, Hbp = 1, Sh = 0, Sf = 3, Gidp = 21, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1959, Stint = 1, TeamId = "ML1", LgId = "NL", G = 154, Ab = 629, R = 116, _2b = 46, _3b = 7, H = 223, Hr = 39, Rbi = 123, Sb = 8, Cs = 0, Bb = 51, So = 54, Ibb = 17, Hbp = 4, Sh = 0, Sf = 9, Gidp = 19, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1960, Stint = 1, TeamId = "ML1", LgId = "NL", G = 153, Ab = 590, R = 102, _2b = 20, _3b = 11, H = 172, Hr = 40, Rbi = 126, Sb = 16, Cs = 7, Bb = 60, So = 63, Ibb = 13, Hbp = 2, Sh = 0, Sf = 12, Gidp = 8, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1961, Stint = 1, TeamId = "ML1", LgId = "NL", G = 155, Ab = 603, R = 115, _2b = 39, _3b = 10, H = 197, Hr = 34, Rbi = 120, Sb = 21, Cs = 9, Bb = 56, So = 64, Ibb = 20, Hbp = 2, Sh = 1, Sf = 9, Gidp = 16, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1962, Stint = 1, TeamId = "ML1", LgId = "NL", G = 156, Ab = 592, R = 127, _2b = 28, _3b = 6, H = 191, Hr = 45, Rbi = 128, Sb = 15, Cs = 7, Bb = 66, So = 73, Ibb = 14, Hbp = 3, Sh = 0, Sf = 6, Gidp = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1963, Stint = 1, TeamId = "ML1", LgId = "NL", G = 161, Ab = 631, R = 121, _2b = 29, _3b = 4, H = 201, Hr = 44, Rbi = 130, Sb = 31, Cs = 5, Bb = 78, So = 94, Ibb = 18, Hbp = 0, Sh = 0, Sf = 5, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1964, Stint = 1, TeamId = "ML1", LgId = "NL", G = 145, Ab = 570, R = 103, _2b = 30, _3b = 2, H = 187, Hr = 24, Rbi = 95, Sb = 22, Cs = 4, Bb = 62, So = 46, Ibb = 9, Hbp = 0, Sh = 0, Sf = 2, Gidp = 22, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1965, Stint = 1, TeamId = "ML1", LgId = "NL", G = 150, Ab = 570, R = 109, _2b = 40, _3b = 1, H = 181, Hr = 32, Rbi = 89, Sb = 24, Cs = 4, Bb = 60, So = 81, Ibb = 10, Hbp = 1, Sh = 0, Sf = 8, Gidp = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1966, Stint = 1, TeamId = "ATL", LgId = "NL", G = 158, Ab = 603, R = 117, _2b = 23, _3b = 1, H = 168, Hr = 44, Rbi = 127, Sb = 21, Cs = 3, Bb = 76, So = 96, Ibb = 15, Hbp = 1, Sh = 0, Sf = 8, Gidp = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1967, Stint = 1, TeamId = "ATL", LgId = "NL", G = 155, Ab = 600, R = 113, _2b = 37, _3b = 3, H = 184, Hr = 39, Rbi = 109, Sb = 17, Cs = 6, Bb = 63, So = 97, Ibb = 19, Hbp = 0, Sh = 0, Sf = 6, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1968, Stint = 1, TeamId = "ATL", LgId = "NL", G = 160, Ab = 606, R = 84, _2b = 33, _3b = 4, H = 174, Hr = 29, Rbi = 86, Sb = 28, Cs = 5, Bb = 64, So = 62, Ibb = 23, Hbp = 1, Sh = 0, Sf = 5, Gidp = 21, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1969, Stint = 1, TeamId = "ATL", LgId = "NL", G = 147, Ab = 547, R = 100, _2b = 30, _3b = 3, H = 164, Hr = 44, Rbi = 97, Sb = 9, Cs = 10, Bb = 87, So = 47, Ibb = 19, Hbp = 2, Sh = 0, Sf = 3, Gidp = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1970, Stint = 1, TeamId = "ATL", LgId = "NL", G = 150, Ab = 516, R = 103, _2b = 26, _3b = 1, H = 154, Hr = 38, Rbi = 118, Sb = 9, Cs = 0, Bb = 74, So = 63, Ibb = 15, Hbp = 2, Sh = 0, Sf = 6, Gidp = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1971, Stint = 1, TeamId = "ATL", LgId = "NL", G = 139, Ab = 495, R = 95, _2b = 22, _3b = 3, H = 162, Hr = 47, Rbi = 118, Sb = 1, Cs = 1, Bb = 71, So = 58, Ibb = 21, Hbp = 2, Sh = 0, Sf = 5, Gidp = 9, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1972, Stint = 1, TeamId = "ATL", LgId = "NL", G = 129, Ab = 449, R = 75, _2b = 10, _3b = 0, H = 119, Hr = 34, Rbi = 77, Sb = 4, Cs = 0, Bb = 92, So = 55, Ibb = 15, Hbp = 1, Sh = 0, Sf = 2, Gidp = 17, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1973, Stint = 1, TeamId = "ATL", LgId = "NL", G = 120, Ab = 392, R = 84, _2b = 12, _3b = 1, H = 118, Hr = 40, Rbi = 96, Sb = 1, Cs = 1, Bb = 68, So = 51, Ibb = 13, Hbp = 1, Sh = 0, Sf = 4, Gidp = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1974, Stint = 1, TeamId = "ATL", LgId = "NL", G = 112, Ab = 340, R = 47, _2b = 16, _3b = 0, H = 91, Hr = 20, Rbi = 69, Sb = 1, Cs = 0, Bb = 39, So = 29, Ibb = 6, Hbp = 0, Sh = 1, Sf = 2, Gidp = 6, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1975, Stint = 1, TeamId = "ML4", LgId = "AL", G = 137, Ab = 465, R = 45, _2b = 16, _3b = 2, H = 109, Hr = 12, Rbi = 60, Sb = 0, Cs = 1, Bb = 70, So = 51, Ibb = 3, Hbp = 1, Sh = 1, Sf = 6, Gidp = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "aaronha01", YearId = 1976, Stint = 1, TeamId = "ML4", LgId = "AL", G = 85, Ab = 271, R = 22, _2b = 8, _3b = 0, H = 62, Hr = 10, Rbi = 35, Sb = 0, Cs = 1, Bb = 35, So = 38, Ibb = 1, Hbp = 0, Sh = 0, Sf = 2, Gidp = 8, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1905, Stint = 1, TeamId = "DET", LgId = "AL", G = 41, Ab = 150, R = 19, _2b = 6, _3b = 0, H = 36, Hr = 1, Rbi = 15, Sb = 2, Bb = 10, Hbp = 0, Sh = 4, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1906, Stint = 1, TeamId = "DET", LgId = "AL", G = 98, Ab = 358, R = 45, _2b = 15, _3b = 5, H = 113, Hr = 1, Rbi = 34, Sb = 23, Bb = 19, Hbp = 3, Sh = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1907, Stint = 1, TeamId = "DET", LgId = "AL", G = 150, Ab = 605, R = 97, _2b = 28, _3b = 14, H = 212, Hr = 5, Rbi = 119, Sb = 49, Bb = 24, Hbp = 5, Sh = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1908, Stint = 1, TeamId = "DET", LgId = "AL", G = 150, Ab = 581, R = 88, _2b = 36, _3b = 20, H = 188, Hr = 4, Rbi = 108, Sb = 39, Bb = 34, Hbp = 6, Sh = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1909, Stint = 1, TeamId = "DET", LgId = "AL", G = 156, Ab = 573, R = 116, _2b = 33, _3b = 10, H = 216, Hr = 9, Rbi = 107, Sb = 76, Bb = 48, Hbp = 6, Sh = 24, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1910, Stint = 1, TeamId = "DET", LgId = "AL", G = 140, Ab = 506, R = 106, _2b = 35, _3b = 13, H = 194, Hr = 8, Rbi = 91, Sb = 65, Bb = 64, Hbp = 4, Sh = 16, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1911, Stint = 1, TeamId = "DET", LgId = "AL", G = 146, Ab = 591, R = 147, _2b = 47, _3b = 24, H = 248, Hr = 8, Rbi = 127, Sb = 83, Bb = 44, Hbp = 8, Sh = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1912, Stint = 1, TeamId = "DET", LgId = "AL", G = 140, Ab = 553, R = 120, _2b = 30, _3b = 23, H = 226, Hr = 7, Rbi = 83, Sb = 61, Bb = 43, Hbp = 5, Sh = 8, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1913, Stint = 1, TeamId = "DET", LgId = "AL", G = 122, Ab = 428, R = 70, _2b = 18, _3b = 16, H = 167, Hr = 4, Rbi = 67, Sb = 51, Bb = 58, So = 31, Hbp = 4, Sh = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1914, Stint = 1, TeamId = "DET", LgId = "AL", G = 98, Ab = 345, R = 69, _2b = 22, _3b = 11, H = 127, Hr = 2, Rbi = 57, Sb = 35, Cs = 17, Bb = 57, So = 22, Hbp = 6, Sh = 6, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1915, Stint = 1, TeamId = "DET", LgId = "AL", G = 156, Ab = 563, R = 144, _2b = 31, _3b = 13, H = 208, Hr = 3, Rbi = 99, Sb = 96, Cs = 38, Bb = 118, So = 43, Hbp = 10, Sh = 9, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1916, Stint = 1, TeamId = "DET", LgId = "AL", G = 145, Ab = 542, R = 113, _2b = 31, _3b = 10, H = 201, Hr = 5, Rbi = 68, Sb = 68, Cs = 24, Bb = 78, So = 39, Hbp = 2, Sh = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1917, Stint = 1, TeamId = "DET", LgId = "AL", G = 152, Ab = 588, R = 107, _2b = 44, _3b = 24, H = 225, Hr = 6, Rbi = 102, Sb = 55, Bb = 61, So = 34, Hbp = 4, Sh = 16, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1918, Stint = 1, TeamId = "DET", LgId = "AL", G = 111, Ab = 421, R = 83, _2b = 19, _3b = 14, H = 161, Hr = 3, Rbi = 64, Sb = 34, Bb = 41, So = 21, Hbp = 2, Sh = 9, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1919, Stint = 1, TeamId = "DET", LgId = "AL", G = 124, Ab = 497, R = 92, _2b = 36, _3b = 13, H = 191, Hr = 1, Rbi = 70, Sb = 28, Bb = 38, So = 22, Hbp = 1, Sh = 9, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1920, Stint = 1, TeamId = "DET", LgId = "AL", G = 112, Ab = 428, R = 86, _2b = 28, _3b = 8, H = 143, Hr = 2, Rbi = 63, Sb = 15, Cs = 10, Bb = 58, So = 28, Hbp = 2, Sh = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1921, Stint = 1, TeamId = "DET", LgId = "AL", G = 128, Ab = 507, R = 124, _2b = 37, _3b = 16, H = 197, Hr = 12, Rbi = 101, Sb = 22, Cs = 15, Bb = 56, So = 19, Hbp = 3, Sh = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1922, Stint = 1, TeamId = "DET", LgId = "AL", G = 137, Ab = 526, R = 99, _2b = 42, _3b = 16, H = 211, Hr = 4, Rbi = 99, Sb = 9, Cs = 13, Bb = 55, So = 24, Hbp = 4, Sh = 27, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1923, Stint = 1, TeamId = "DET", LgId = "AL", G = 145, Ab = 556, R = 103, _2b = 40, _3b = 7, H = 189, Hr = 6, Rbi = 88, Sb = 9, Cs = 10, Bb = 66, So = 14, Hbp = 3, Sh = 22, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1924, Stint = 1, TeamId = "DET", LgId = "AL", G = 155, Ab = 625, R = 115, _2b = 38, _3b = 10, H = 211, Hr = 4, Rbi = 78, Sb = 23, Cs = 14, Bb = 85, So = 18, Hbp = 1, Sh = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1925, Stint = 1, TeamId = "DET", LgId = "AL", G = 121, Ab = 415, R = 97, _2b = 31, _3b = 12, H = 157, Hr = 12, Rbi = 102, Sb = 13, Cs = 9, Bb = 65, So = 12, Hbp = 5, Sh = 5, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1926, Stint = 1, TeamId = "DET", LgId = "AL", G = 79, Ab = 233, R = 48, _2b = 18, _3b = 5, H = 79, Hr = 4, Rbi = 62, Sb = 9, Cs = 4, Bb = 26, So = 2, Hbp = 1, Sh = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1927, Stint = 1, TeamId = "PHA", LgId = "AL", G = 134, Ab = 490, R = 104, _2b = 32, _3b = 7, H = 175, Hr = 5, Rbi = 93, Sb = 22, Cs = 16, Bb = 67, So = 12, Hbp = 5, Sh = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "cobbty01", YearId = 1928, Stint = 1, TeamId = "PHA", LgId = "AL", G = 95, Ab = 353, R = 54, _2b = 27, _3b = 4, H = 114, Hr = 1, Rbi = 40, Sb = 5, Cs = 8, Bb = 34, So = 16, Hbp = 4, Sh = 2, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1906, Stint = 1, TeamId = "PHA", LgId = "AL", G = 6, Ab = 15, R = 2, _2b = 0, _3b = 0, H = 3, Hr = 0, Rbi = 0, Sb = 0, Bb = 0, Hbp = 0, Sh = 3, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1907, Stint = 1, TeamId = "PHA", LgId = "AL", G = 14, Ab = 23, R = 0, _2b = 0, _3b = 1, H = 8, Hr = 0, Rbi = 2, Sb = 0, Bb = 0, Hbp = 0, Sh = 1, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1908, Stint = 1, TeamId = "PHA", LgId = "AL", G = 102, Ab = 330, R = 39, _2b = 18, _3b = 7, H = 90, Hr = 1, Rbi = 40, Sb = 8, Bb = 16, Hbp = 3, Sh = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1909, Stint = 1, TeamId = "PHA", LgId = "AL", G = 153, Ab = 571, R = 104, _2b = 30, _3b = 10, H = 198, Hr = 3, Rbi = 56, Sb = 67, Bb = 62, Hbp = 6, Sh = 21, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1910, Stint = 1, TeamId = "PHA", LgId = "AL", G = 153, Ab = 581, R = 81, _2b = 16, _3b = 15, H = 188, Hr = 3, Rbi = 81, Sb = 81, Bb = 49, Hbp = 6, Sh = 22, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1911, Stint = 1, TeamId = "PHA", LgId = "AL", G = 132, Ab = 493, R = 92, _2b = 22, _3b = 13, H = 180, Hr = 3, Rbi = 73, Sb = 38, Bb = 62, Hbp = 15, Sh = 18, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1912, Stint = 1, TeamId = "PHA", LgId = "AL", G = 153, Ab = 543, R = 137, _2b = 25, _3b = 11, H = 189, Hr = 0, Rbi = 64, Sb = 63, Bb = 101, Hbp = 0, Sh = 29, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1913, Stint = 1, TeamId = "PHA", LgId = "AL", G = 148, Ab = 534, R = 125, _2b = 23, _3b = 13, H = 184, Hr = 3, Rbi = 73, Sb = 55, Bb = 85, So = 37, Hbp = 7, Sh = 26, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1914, Stint = 1, TeamId = "PHA", LgId = "AL", G = 152, Ab = 526, R = 122, _2b = 23, _3b = 14, H = 181, Hr = 2, Rbi = 85, Sb = 58, Cs = 30, Bb = 97, So = 31, Hbp = 6, Sh = 28, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1915, Stint = 1, TeamId = "CHA", LgId = "AL", G = 155, Ab = 521, R = 118, _2b = 22, _3b = 10, H = 173, Hr = 4, Rbi = 77, Sb = 46, Cs = 30, Bb = 119, So = 27, Hbp = 5, Sh = 35, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1916, Stint = 1, TeamId = "CHA", LgId = "AL", G = 155, Ab = 545, R = 87, _2b = 14, _3b = 17, H = 168, Hr = 0, Rbi = 52, Sb = 40, Cs = 21, Bb = 86, So = 36, Hbp = 3, Sh = 39, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1917, Stint = 1, TeamId = "CHA", LgId = "AL", G = 156, Ab = 564, R = 91, _2b = 18, _3b = 12, H = 163, Hr = 0, Rbi = 67, Sb = 53, Bb = 89, So = 16, Hbp = 3, Sh = 33, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1918, Stint = 1, TeamId = "CHA", LgId = "AL", G = 97, Ab = 330, R = 51, _2b = 8, _3b = 2, H = 91, Hr = 2, Rbi = 30, Sb = 22, Bb = 73, So = 13, Hbp = 0, Sh = 22, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1919, Stint = 1, TeamId = "CHA", LgId = "AL", G = 140, Ab = 518, R = 87, _2b = 19, _3b = 7, H = 165, Hr = 4, Rbi = 80, Sb = 33, Bb = 68, So = 27, Hbp = 2, Sh = 40, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1920, Stint = 1, TeamId = "CHA", LgId = "AL", G = 153, Ab = 602, R = 117, _2b = 38, _3b = 13, H = 224, Hr = 3, Rbi = 76, Sb = 20, Cs = 8, Bb = 69, So = 19, Hbp = 2, Sh = 33, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1921, Stint = 1, TeamId = "CHA", LgId = "AL", G = 139, Ab = 526, R = 79, _2b = 20, _3b = 10, H = 177, Hr = 2, Rbi = 58, Sb = 12, Cs = 10, Bb = 66, So = 11, Hbp = 2, Sh = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1922, Stint = 1, TeamId = "CHA", LgId = "AL", G = 154, Ab = 598, R = 92, _2b = 20, _3b = 12, H = 194, Hr = 1, Rbi = 69, Sb = 20, Cs = 12, Bb = 73, So = 16, Hbp = 3, Sh = 27, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1923, Stint = 1, TeamId = "CHA", LgId = "AL", G = 145, Ab = 505, R = 89, _2b = 22, _3b = 5, H = 182, Hr = 5, Rbi = 67, Sb = 48, Cs = 29, Bb = 84, So = 8, Hbp = 4, Sh = 39, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1924, Stint = 1, TeamId = "CHA", LgId = "AL", G = 152, Ab = 556, R = 108, _2b = 27, _3b = 7, H = 194, Hr = 6, Rbi = 86, Sb = 42, Cs = 17, Bb = 89, So = 16, Hbp = 3, Sh = 28, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1925, Stint = 1, TeamId = "CHA", LgId = "AL", G = 118, Ab = 425, R = 80, _2b = 26, _3b = 3, H = 147, Hr = 3, Rbi = 80, Sb = 19, Cs = 6, Bb = 87, So = 8, Hbp = 4, Sh = 17, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1926, Stint = 1, TeamId = "CHA", LgId = "AL", G = 106, Ab = 375, R = 66, _2b = 32, _3b = 4, H = 129, Hr = 1, Rbi = 62, Sb = 13, Cs = 8, Bb = 62, So = 8, Hbp = 3, Sh = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1927, Stint = 1, TeamId = "PHA", LgId = "AL", G = 95, Ab = 226, R = 50, _2b = 12, _3b = 1, H = 76, Hr = 1, Rbi = 15, Sb = 6, Cs = 2, Bb = 56, So = 9, Hbp = 0, Sh = 8, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1928, Stint = 1, TeamId = "PHA", LgId = "AL", G = 36, Ab = 33, R = 3, _2b = 3, _3b = 0, H = 10, Hr = 0, Rbi = 7, Sb = 0, Cs = 0, Bb = 4, So = 4, Hbp = 0, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1929, Stint = 1, TeamId = "PHA", LgId = "AL", G = 9, Ab = 7, R = 0, _2b = 0, _3b = 0, H = 0, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 2, So = 0, Hbp = 0, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied01", YearId = 1930, Stint = 1, TeamId = "PHA", LgId = "AL", G = 3, Ab = 2, R = 1, _2b = 0, _3b = 0, H = 1, Hr = 0, Rbi = 0, Sb = 0, Cs = 0, Bb = 0, So = 0, Hbp = 0, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied02", YearId = 1939, Stint = 1, TeamId = "PHA", LgId = "AL", G = 32, Ab = 21, R = 6, _2b = 1, _3b = 0, H = 5, Hr = 0, Rbi = 0, Sb = 1, Cs = 0, Bb = 0, So = 3, Hbp = 0, Sh = 0, Gidp = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied02", YearId = 1941, Stint = 1, TeamId = "PHA", LgId = "AL", G = 80, Ab = 219, R = 29, _2b = 6, _3b = 3, H = 53, Hr = 0, Rbi = 12, Sb = 2, Cs = 1, Bb = 20, So = 24, Hbp = 0, Sh = 1, Gidp = 4, });
            dbContext.Batting.Add(new Batting() { PlayerId = "collied02", YearId = 1942, Stint = 1, TeamId = "PHA", LgId = "AL", G = 20, Ab = 34, R = 6, _2b = 2, _3b = 0, H = 8, Hr = 0, Rbi = 4, Sb = 1, Cs = 0, Bb = 4, So = 2, Hbp = 0, Sh = 0, Gidp = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1923, Stint = 1, TeamId = "NYA", LgId = "AL", G = 13, Ab = 26, R = 6, _2b = 4, _3b = 1, H = 11, Hr = 1, Rbi = 9, Sb = 0, Cs = 0, Bb = 2, So = 5, Hbp = 0, Sh = 1, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1924, Stint = 1, TeamId = "NYA", LgId = "AL", G = 10, Ab = 12, R = 2, _2b = 1, _3b = 0, H = 6, Hr = 0, Rbi = 5, Sb = 0, Cs = 0, Bb = 1, So = 3, Hbp = 0, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1925, Stint = 1, TeamId = "NYA", LgId = "AL", G = 126, Ab = 437, R = 73, _2b = 23, _3b = 10, H = 129, Hr = 20, Rbi = 68, Sb = 6, Cs = 3, Bb = 46, So = 49, Hbp = 2, Sh = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1926, Stint = 1, TeamId = "NYA", LgId = "AL", G = 155, Ab = 572, R = 135, _2b = 47, _3b = 20, H = 179, Hr = 16, Rbi = 112, Sb = 6, Cs = 5, Bb = 105, So = 73, Hbp = 1, Sh = 18, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1927, Stint = 1, TeamId = "NYA", LgId = "AL", G = 155, Ab = 584, R = 149, _2b = 52, _3b = 18, H = 218, Hr = 47, Rbi = 175, Sb = 10, Cs = 8, Bb = 109, So = 84, Hbp = 3, Sh = 21, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1928, Stint = 1, TeamId = "NYA", LgId = "AL", G = 154, Ab = 562, R = 139, _2b = 47, _3b = 13, H = 210, Hr = 27, Rbi = 142, Sb = 4, Cs = 11, Bb = 95, So = 69, Hbp = 4, Sh = 16, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1929, Stint = 1, TeamId = "NYA", LgId = "AL", G = 154, Ab = 553, R = 127, _2b = 32, _3b = 10, H = 166, Hr = 35, Rbi = 126, Sb = 4, Cs = 4, Bb = 122, So = 68, Hbp = 5, Sh = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1930, Stint = 1, TeamId = "NYA", LgId = "AL", G = 154, Ab = 581, R = 143, _2b = 42, _3b = 17, H = 220, Hr = 41, Rbi = 174, Sb = 12, Cs = 14, Bb = 101, So = 63, Hbp = 3, Sh = 18, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1931, Stint = 1, TeamId = "NYA", LgId = "AL", G = 155, Ab = 619, R = 163, _2b = 31, _3b = 15, H = 211, Hr = 46, Rbi = 184, Sb = 17, Cs = 12, Bb = 117, So = 56, Hbp = 0, Sh = 2, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1932, Stint = 1, TeamId = "NYA", LgId = "AL", G = 156, Ab = 596, R = 138, _2b = 42, _3b = 9, H = 208, Hr = 34, Rbi = 151, Sb = 4, Cs = 11, Bb = 108, So = 38, Hbp = 3, Sh = 1, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1933, Stint = 1, TeamId = "NYA", LgId = "AL", G = 152, Ab = 593, R = 138, _2b = 41, _3b = 12, H = 198, Hr = 32, Rbi = 139, Sb = 9, Cs = 13, Bb = 92, So = 42, Hbp = 1, Sh = 1, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1934, Stint = 1, TeamId = "NYA", LgId = "AL", G = 154, Ab = 579, R = 128, _2b = 40, _3b = 6, H = 210, Hr = 49, Rbi = 165, Sb = 9, Cs = 5, Bb = 109, So = 31, Hbp = 2, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1935, Stint = 1, TeamId = "NYA", LgId = "AL", G = 149, Ab = 535, R = 125, _2b = 26, _3b = 10, H = 176, Hr = 30, Rbi = 119, Sb = 8, Cs = 7, Bb = 132, So = 38, Hbp = 5, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1936, Stint = 1, TeamId = "NYA", LgId = "AL", G = 155, Ab = 579, R = 167, _2b = 37, _3b = 7, H = 205, Hr = 49, Rbi = 152, Sb = 3, Cs = 4, Bb = 130, So = 46, Hbp = 7, Sh = 3, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1937, Stint = 1, TeamId = "NYA", LgId = "AL", G = 157, Ab = 569, R = 138, _2b = 37, _3b = 9, H = 200, Hr = 37, Rbi = 159, Sb = 4, Cs = 3, Bb = 127, So = 49, Hbp = 4, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1938, Stint = 1, TeamId = "NYA", LgId = "AL", G = 157, Ab = 576, R = 115, _2b = 32, _3b = 6, H = 170, Hr = 29, Rbi = 114, Sb = 6, Cs = 1, Bb = 107, So = 75, Hbp = 5, Sh = 1, });
            dbContext.Batting.Add(new Batting() { PlayerId = "gehrilo01", YearId = 1939, Stint = 1, TeamId = "NYA", LgId = "AL", G = 8, Ab = 28, R = 2, _2b = 0, _3b = 0, H = 4, Hr = 0, Rbi = 1, Sb = 0, Cs = 0, Bb = 5, So = 1, Hbp = 0, Sh = 0, Gidp = 2, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1951, Stint = 1, TeamId = "NY1", LgId = "NL", G = 121, Ab = 464, R = 59, _2b = 22, _3b = 5, H = 127, Hr = 20, Rbi = 68, Sb = 7, Cs = 4, Bb = 57, So = 60, Hbp = 2, Sh = 1, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1952, Stint = 1, TeamId = "NY1", LgId = "NL", G = 34, Ab = 127, R = 17, _2b = 2, _3b = 4, H = 30, Hr = 4, Rbi = 23, Sb = 4, Cs = 1, Bb = 16, So = 17, Hbp = 1, Sh = 0, Gidp = 2, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1954, Stint = 1, TeamId = "NY1", LgId = "NL", G = 151, Ab = 565, R = 119, _2b = 33, _3b = 13, H = 195, Hr = 41, Rbi = 110, Sb = 8, Cs = 5, Bb = 66, So = 57, Hbp = 2, Sh = 0, Sf = 7, Gidp = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1955, Stint = 1, TeamId = "NY1", LgId = "NL", G = 152, Ab = 580, R = 123, _2b = 18, _3b = 13, H = 185, Hr = 51, Rbi = 127, Sb = 24, Cs = 4, Bb = 79, So = 60, Ibb = 13, Hbp = 4, Sh = 0, Sf = 7, Gidp = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1956, Stint = 1, TeamId = "NY1", LgId = "NL", G = 152, Ab = 578, R = 101, _2b = 27, _3b = 8, H = 171, Hr = 36, Rbi = 84, Sb = 40, Cs = 10, Bb = 68, So = 65, Ibb = 20, Hbp = 1, Sh = 0, Sf = 3, Gidp = 16, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1957, Stint = 1, TeamId = "NY1", LgId = "NL", G = 152, Ab = 585, R = 112, _2b = 26, _3b = 20, H = 195, Hr = 35, Rbi = 97, Sb = 38, Cs = 19, Bb = 76, So = 62, Ibb = 15, Hbp = 1, Sh = 0, Sf = 6, Gidp = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1958, Stint = 1, TeamId = "SFN", LgId = "NL", G = 152, Ab = 600, R = 121, _2b = 33, _3b = 11, H = 208, Hr = 29, Rbi = 96, Sb = 31, Cs = 6, Bb = 78, So = 56, Ibb = 12, Hbp = 1, Sh = 0, Sf = 6, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1959, Stint = 1, TeamId = "SFN", LgId = "NL", G = 151, Ab = 575, R = 125, _2b = 43, _3b = 5, H = 180, Hr = 34, Rbi = 104, Sb = 27, Cs = 4, Bb = 65, So = 58, Ibb = 9, Hbp = 2, Sh = 0, Sf = 6, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1960, Stint = 1, TeamId = "SFN", LgId = "NL", G = 153, Ab = 595, R = 107, _2b = 29, _3b = 12, H = 190, Hr = 29, Rbi = 103, Sb = 25, Cs = 10, Bb = 61, So = 70, Ibb = 11, Hbp = 4, Sh = 0, Sf = 9, Gidp = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1961, Stint = 1, TeamId = "SFN", LgId = "NL", G = 154, Ab = 572, R = 129, _2b = 32, _3b = 3, H = 176, Hr = 40, Rbi = 123, Sb = 18, Cs = 9, Bb = 81, So = 77, Ibb = 15, Hbp = 2, Sh = 0, Sf = 4, Gidp = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1962, Stint = 1, TeamId = "SFN", LgId = "NL", G = 162, Ab = 621, R = 130, _2b = 36, _3b = 5, H = 189, Hr = 49, Rbi = 141, Sb = 18, Cs = 2, Bb = 78, So = 85, Ibb = 11, Hbp = 4, Sh = 0, Sf = 3, Gidp = 19, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1963, Stint = 1, TeamId = "SFN", LgId = "NL", G = 157, Ab = 596, R = 115, _2b = 32, _3b = 7, H = 187, Hr = 38, Rbi = 103, Sb = 8, Cs = 3, Bb = 66, So = 83, Ibb = 5, Hbp = 2, Sh = 0, Sf = 7, Gidp = 15, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1964, Stint = 1, TeamId = "SFN", LgId = "NL", G = 157, Ab = 578, R = 121, _2b = 21, _3b = 9, H = 171, Hr = 47, Rbi = 111, Sb = 19, Cs = 5, Bb = 82, So = 72, Ibb = 13, Hbp = 1, Sh = 1, Sf = 3, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1965, Stint = 1, TeamId = "SFN", LgId = "NL", G = 157, Ab = 558, R = 118, _2b = 21, _3b = 3, H = 177, Hr = 52, Rbi = 112, Sb = 9, Cs = 4, Bb = 76, So = 71, Ibb = 16, Hbp = 0, Sh = 2, Sf = 2, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1966, Stint = 1, TeamId = "SFN", LgId = "NL", G = 152, Ab = 552, R = 99, _2b = 29, _3b = 4, H = 159, Hr = 37, Rbi = 103, Sb = 5, Cs = 1, Bb = 70, So = 81, Ibb = 11, Hbp = 2, Sh = 1, Sf = 4, Gidp = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1967, Stint = 1, TeamId = "SFN", LgId = "NL", G = 141, Ab = 486, R = 83, _2b = 22, _3b = 2, H = 128, Hr = 22, Rbi = 70, Sb = 6, Cs = 0, Bb = 51, So = 92, Ibb = 7, Hbp = 2, Sh = 2, Sf = 3, Gidp = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1968, Stint = 1, TeamId = "SFN", LgId = "NL", G = 148, Ab = 498, R = 84, _2b = 20, _3b = 5, H = 144, Hr = 23, Rbi = 79, Sb = 12, Cs = 6, Bb = 67, So = 81, Ibb = 7, Hbp = 2, Sh = 0, Sf = 6, Gidp = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1969, Stint = 1, TeamId = "SFN", LgId = "NL", G = 117, Ab = 403, R = 64, _2b = 17, _3b = 3, H = 114, Hr = 13, Rbi = 58, Sb = 6, Cs = 2, Bb = 49, So = 71, Ibb = 7, Hbp = 3, Sh = 0, Sf = 4, Gidp = 8, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1970, Stint = 1, TeamId = "SFN", LgId = "NL", G = 139, Ab = 478, R = 94, _2b = 15, _3b = 2, H = 139, Hr = 28, Rbi = 83, Sb = 5, Cs = 0, Bb = 79, So = 90, Ibb = 3, Hbp = 3, Sh = 0, Sf = 6, Gidp = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1971, Stint = 1, TeamId = "SFN", LgId = "NL", G = 136, Ab = 417, R = 82, _2b = 24, _3b = 5, H = 113, Hr = 18, Rbi = 61, Sb = 23, Cs = 3, Bb = 112, So = 123, Ibb = 11, Hbp = 3, Sh = 1, Sf = 4, Gidp = 8, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1972, Stint = 1, TeamId = "SFN", LgId = "NL", G = 19, Ab = 49, R = 8, _2b = 2, _3b = 0, H = 9, Hr = 0, Rbi = 3, Sb = 3, Cs = 0, Bb = 17, So = 5, Ibb = 1, Hbp = 0, Sh = 1, Sf = 0, Gidp = 4, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1972, Stint = 2, TeamId = "NYN", LgId = "NL", G = 69, Ab = 195, R = 27, _2b = 9, _3b = 1, H = 52, Hr = 8, Rbi = 19, Sb = 1, Cs = 5, Bb = 43, So = 43, Ibb = 5, Hbp = 1, Sh = 3, Sf = 0, Gidp = 5, });
            dbContext.Batting.Add(new Batting() { PlayerId = "mayswi01", YearId = 1973, Stint = 1, TeamId = "NYN", LgId = "NL", G = 66, Ab = 209, R = 24, _2b = 10, _3b = 0, H = 44, Hr = 6, Rbi = 25, Sb = 1, Cs = 0, Bb = 27, So = 47, Ibb = 0, Hbp = 1, Sh = 1, Sf = 1, Gidp = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1941, Stint = 1, TeamId = "SLN", LgId = "NL", G = 12, Ab = 47, R = 8, _2b = 4, _3b = 0, H = 20, Hr = 1, Rbi = 7, Sb = 1, Bb = 2, So = 1, Hbp = 0, Sh = 0, Gidp = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1942, Stint = 1, TeamId = "SLN", LgId = "NL", G = 140, Ab = 467, R = 87, _2b = 32, _3b = 10, H = 147, Hr = 10, Rbi = 72, Sb = 6, Bb = 62, So = 25, Hbp = 2, Sh = 5, Gidp = 3, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1943, Stint = 1, TeamId = "SLN", LgId = "NL", G = 157, Ab = 617, R = 108, _2b = 48, _3b = 20, H = 220, Hr = 13, Rbi = 81, Sb = 9, Bb = 72, So = 18, Hbp = 2, Sh = 10, Gidp = 17, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1944, Stint = 1, TeamId = "SLN", LgId = "NL", G = 146, Ab = 568, R = 112, _2b = 51, _3b = 14, H = 197, Hr = 12, Rbi = 94, Sb = 7, Bb = 90, So = 28, Hbp = 5, Sh = 4, Gidp = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1946, Stint = 1, TeamId = "SLN", LgId = "NL", G = 156, Ab = 624, R = 124, _2b = 50, _3b = 20, H = 228, Hr = 16, Rbi = 103, Sb = 7, Bb = 73, So = 31, Hbp = 3, Sh = 2, Gidp = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1947, Stint = 1, TeamId = "SLN", LgId = "NL", G = 149, Ab = 587, R = 113, _2b = 30, _3b = 13, H = 183, Hr = 19, Rbi = 95, Sb = 4, Bb = 80, So = 24, Hbp = 4, Sh = 6, Gidp = 18, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1948, Stint = 1, TeamId = "SLN", LgId = "NL", G = 155, Ab = 611, R = 135, _2b = 46, _3b = 18, H = 230, Hr = 39, Rbi = 131, Sb = 7, Bb = 79, So = 34, Hbp = 3, Sh = 1, Gidp = 18, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1949, Stint = 1, TeamId = "SLN", LgId = "NL", G = 157, Ab = 612, R = 128, _2b = 41, _3b = 13, H = 207, Hr = 36, Rbi = 123, Sb = 3, Bb = 107, So = 38, Hbp = 2, Sh = 0, Gidp = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1950, Stint = 1, TeamId = "SLN", LgId = "NL", G = 146, Ab = 555, R = 105, _2b = 41, _3b = 7, H = 192, Hr = 28, Rbi = 109, Sb = 5, Bb = 87, So = 36, Hbp = 3, Sh = 0, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1951, Stint = 1, TeamId = "SLN", LgId = "NL", G = 152, Ab = 578, R = 124, _2b = 30, _3b = 12, H = 205, Hr = 32, Rbi = 108, Sb = 4, Cs = 5, Bb = 98, So = 40, Hbp = 1, Sh = 1, Gidp = 6, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1952, Stint = 1, TeamId = "SLN", LgId = "NL", G = 154, Ab = 578, R = 105, _2b = 42, _3b = 6, H = 194, Hr = 21, Rbi = 91, Sb = 7, Cs = 7, Bb = 96, So = 29, Hbp = 2, Sh = 0, Gidp = 11, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1953, Stint = 1, TeamId = "SLN", LgId = "NL", G = 157, Ab = 593, R = 127, _2b = 53, _3b = 9, H = 200, Hr = 30, Rbi = 113, Sb = 3, Cs = 4, Bb = 105, So = 32, Hbp = 0, Sh = 0, Gidp = 10, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1954, Stint = 1, TeamId = "SLN", LgId = "NL", G = 153, Ab = 591, R = 120, _2b = 41, _3b = 9, H = 195, Hr = 35, Rbi = 126, Sb = 1, Cs = 7, Bb = 103, So = 39, Hbp = 4, Sh = 0, Sf = 7, Gidp = 20, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1955, Stint = 1, TeamId = "SLN", LgId = "NL", G = 154, Ab = 562, R = 97, _2b = 30, _3b = 5, H = 179, Hr = 33, Rbi = 108, Sb = 5, Cs = 4, Bb = 80, So = 39, Ibb = 19, Hbp = 8, Sh = 2, Sf = 4, Gidp = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1956, Stint = 1, TeamId = "SLN", LgId = "NL", G = 156, Ab = 594, R = 87, _2b = 33, _3b = 6, H = 184, Hr = 27, Rbi = 109, Sb = 2, Cs = 0, Bb = 75, So = 39, Ibb = 15, Hbp = 3, Sh = 3, Sf = 7, Gidp = 19, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1957, Stint = 1, TeamId = "SLN", LgId = "NL", G = 134, Ab = 502, R = 82, _2b = 38, _3b = 3, H = 176, Hr = 29, Rbi = 102, Sb = 1, Cs = 1, Bb = 66, So = 34, Ibb = 19, Hbp = 2, Sh = 1, Sf = 8, Gidp = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1958, Stint = 1, TeamId = "SLN", LgId = "NL", G = 135, Ab = 472, R = 64, _2b = 35, _3b = 2, H = 159, Hr = 17, Rbi = 62, Sb = 0, Cs = 0, Bb = 72, So = 26, Ibb = 26, Hbp = 1, Sh = 0, Sf = 4, Gidp = 19, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1959, Stint = 1, TeamId = "SLN", LgId = "NL", G = 115, Ab = 341, R = 37, _2b = 13, _3b = 2, H = 87, Hr = 14, Rbi = 44, Sb = 0, Cs = 2, Bb = 60, So = 25, Ibb = 11, Hbp = 0, Sh = 0, Sf = 3, Gidp = 12, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1960, Stint = 1, TeamId = "SLN", LgId = "NL", G = 116, Ab = 331, R = 49, _2b = 17, _3b = 1, H = 91, Hr = 17, Rbi = 63, Sb = 1, Cs = 1, Bb = 41, So = 34, Ibb = 7, Hbp = 2, Sh = 0, Sf = 4, Gidp = 5, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1961, Stint = 1, TeamId = "SLN", LgId = "NL", G = 123, Ab = 372, R = 46, _2b = 22, _3b = 4, H = 107, Hr = 15, Rbi = 70, Sb = 0, Cs = 0, Bb = 52, So = 35, Ibb = 17, Hbp = 1, Sh = 0, Sf = 6, Gidp = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1962, Stint = 1, TeamId = "SLN", LgId = "NL", G = 135, Ab = 433, R = 57, _2b = 18, _3b = 1, H = 143, Hr = 19, Rbi = 82, Sb = 3, Cs = 0, Bb = 64, So = 46, Ibb = 4, Hbp = 3, Sh = 0, Sf = 5, Gidp = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "musiast01", YearId = 1963, Stint = 1, TeamId = "SLN", LgId = "NL", G = 124, Ab = 337, R = 34, _2b = 10, _3b = 2, H = 86, Hr = 12, Rbi = 58, Sb = 2, Cs = 0, Bb = 35, So = 43, Ibb = 9, Hbp = 2, Sh = 0, Sf = 5, Gidp = 3, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1914, Stint = 1, TeamId = "BOS", LgId = "AL", G = 5, Ab = 10, R = 1, _2b = 1, _3b = 0, H = 2, Hr = 0, Rbi = 2, Sb = 0, Bb = 0, So = 4, Hbp = 0, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1915, Stint = 1, TeamId = "BOS", LgId = "AL", G = 42, Ab = 92, R = 16, _2b = 10, _3b = 1, H = 29, Hr = 4, Rbi = 21, Sb = 0, Bb = 9, So = 23, Hbp = 0, Sh = 2, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1916, Stint = 1, TeamId = "BOS", LgId = "AL", G = 67, Ab = 136, R = 18, _2b = 5, _3b = 3, H = 37, Hr = 3, Rbi = 15, Sb = 0, Bb = 10, So = 23, Hbp = 0, Sh = 4, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1917, Stint = 1, TeamId = "BOS", LgId = "AL", G = 52, Ab = 123, R = 14, _2b = 6, _3b = 3, H = 40, Hr = 2, Rbi = 12, Sb = 0, Bb = 12, So = 18, Hbp = 0, Sh = 7, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1918, Stint = 1, TeamId = "BOS", LgId = "AL", G = 95, Ab = 317, R = 50, _2b = 26, _3b = 11, H = 95, Hr = 11, Rbi = 66, Sb = 6, Bb = 58, So = 58, Hbp = 2, Sh = 3, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1919, Stint = 1, TeamId = "BOS", LgId = "AL", G = 130, Ab = 432, R = 103, _2b = 34, _3b = 12, H = 139, Hr = 29, Rbi = 114, Sb = 7, Bb = 101, So = 58, Hbp = 6, Sh = 3, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1920, Stint = 1, TeamId = "NYA", LgId = "AL", G = 142, Ab = 457, R = 158, _2b = 36, _3b = 9, H = 172, Hr = 54, Rbi = 137, Sb = 14, Cs = 14, Bb = 150, So = 80, Hbp = 3, Sh = 5, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1921, Stint = 1, TeamId = "NYA", LgId = "AL", G = 152, Ab = 540, R = 177, _2b = 44, _3b = 16, H = 204, Hr = 59, Rbi = 171, Sb = 17, Cs = 13, Bb = 145, So = 81, Hbp = 4, Sh = 4, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1922, Stint = 1, TeamId = "NYA", LgId = "AL", G = 110, Ab = 406, R = 94, _2b = 24, _3b = 8, H = 128, Hr = 35, Rbi = 99, Sb = 2, Cs = 5, Bb = 84, So = 80, Hbp = 1, Sh = 4, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1923, Stint = 1, TeamId = "NYA", LgId = "AL", G = 152, Ab = 522, R = 151, _2b = 45, _3b = 13, H = 205, Hr = 41, Rbi = 131, Sb = 17, Cs = 21, Bb = 170, So = 93, Hbp = 4, Sh = 3, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1924, Stint = 1, TeamId = "NYA", LgId = "AL", G = 153, Ab = 529, R = 143, _2b = 39, _3b = 7, H = 200, Hr = 46, Rbi = 121, Sb = 9, Cs = 13, Bb = 142, So = 81, Hbp = 4, Sh = 6, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1925, Stint = 1, TeamId = "NYA", LgId = "AL", G = 98, Ab = 359, R = 61, _2b = 12, _3b = 2, H = 104, Hr = 25, Rbi = 66, Sb = 2, Cs = 4, Bb = 59, So = 68, Hbp = 2, Sh = 6, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1926, Stint = 1, TeamId = "NYA", LgId = "AL", G = 152, Ab = 495, R = 139, _2b = 30, _3b = 5, H = 184, Hr = 47, Rbi = 150, Sb = 11, Cs = 9, Bb = 144, So = 76, Hbp = 3, Sh = 10, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1927, Stint = 1, TeamId = "NYA", LgId = "AL", G = 151, Ab = 540, R = 158, _2b = 29, _3b = 8, H = 192, Hr = 60, Rbi = 164, Sb = 7, Cs = 6, Bb = 137, So = 89, Hbp = 0, Sh = 14, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1928, Stint = 1, TeamId = "NYA", LgId = "AL", G = 154, Ab = 536, R = 163, _2b = 29, _3b = 8, H = 173, Hr = 54, Rbi = 142, Sb = 4, Cs = 5, Bb = 137, So = 87, Hbp = 3, Sh = 8, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1929, Stint = 1, TeamId = "NYA", LgId = "AL", G = 135, Ab = 499, R = 121, _2b = 26, _3b = 6, H = 172, Hr = 46, Rbi = 154, Sb = 5, Cs = 3, Bb = 72, So = 60, Hbp = 3, Sh = 13, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1930, Stint = 1, TeamId = "NYA", LgId = "AL", G = 145, Ab = 518, R = 150, _2b = 28, _3b = 9, H = 186, Hr = 49, Rbi = 153, Sb = 10, Cs = 10, Bb = 136, So = 61, Hbp = 1, Sh = 21, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1931, Stint = 1, TeamId = "NYA", LgId = "AL", G = 145, Ab = 534, R = 149, _2b = 31, _3b = 3, H = 199, Hr = 46, Rbi = 163, Sb = 5, Cs = 4, Bb = 128, So = 51, Hbp = 1, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1932, Stint = 1, TeamId = "NYA", LgId = "AL", G = 133, Ab = 457, R = 120, _2b = 13, _3b = 5, H = 156, Hr = 41, Rbi = 137, Sb = 2, Cs = 2, Bb = 130, So = 62, Hbp = 2, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1933, Stint = 1, TeamId = "NYA", LgId = "AL", G = 137, Ab = 459, R = 97, _2b = 21, _3b = 3, H = 138, Hr = 34, Rbi = 103, Sb = 4, Cs = 5, Bb = 114, So = 90, Hbp = 2, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1934, Stint = 1, TeamId = "NYA", LgId = "AL", G = 125, Ab = 365, R = 78, _2b = 17, _3b = 4, H = 105, Hr = 22, Rbi = 84, Sb = 1, Cs = 3, Bb = 104, So = 63, Hbp = 2, Sh = 0, });
            dbContext.Batting.Add(new Batting() { PlayerId = "ruthba01", YearId = 1935, Stint = 1, TeamId = "BSN", LgId = "NL", G = 28, Ab = 72, R = 13, _2b = 0, _3b = 0, H = 13, Hr = 6, Rbi = 12, Sb = 0, Bb = 20, So = 24, Hbp = 0, Sh = 0, Gidp = 2, });
            dbContext.SaveChanges();
        }

        public static void BulkFieldingPlayerInsert(LahmansDbContext dbContext)
        {
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1954, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 116, Gs = 113, InnOuts = 3093, Po = 223, A = 5, E = 7, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1955, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "2B", G = 27, Gs = 26, InnOuts = 709, Po = 86, A = 84, E = 6, Dp = 23, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1955, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 126, Gs = 125, InnOuts = 3329, Po = 254, A = 9, E = 9, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1956, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 152, Gs = 152, InnOuts = 4048, Po = 316, A = 17, E = 13, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1957, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 150, Gs = 150, InnOuts = 4069, Po = 346, A = 9, E = 6, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1958, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 153, Gs = 153, InnOuts = 4083, Po = 305, A = 12, E = 5, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1959, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "3B", G = 5, Gs = 5, InnOuts = 126, Po = 2, A = 10, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1959, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 152, Gs = 149, InnOuts = 3980, Po = 261, A = 12, E = 5, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1960, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "2B", G = 2, Gs = 0, InnOuts = 6, Po = 1, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1960, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 153, Gs = 153, InnOuts = 4129, Po = 320, A = 13, E = 6, Dp = 6, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1961, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "3B", G = 2, Gs = 0, InnOuts = 27, Po = 2, A = 2, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1961, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 154, Gs = 154, InnOuts = 4101, Po = 377, A = 13, E = 7, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1962, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "1B", G = 1, Gs = 0, InnOuts = 3, Po = 1, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1962, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 153, Gs = 153, InnOuts = 4019, Po = 340, A = 11, E = 7, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1963, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 161, Gs = 161, InnOuts = 4338, Po = 267, A = 10, E = 6, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1964, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "2B", G = 11, Gs = 8, InnOuts = 186, Po = 14, A = 15, E = 1, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1964, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 139, Gs = 134, InnOuts = 3514, Po = 270, A = 13, E = 5, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1965, Stint = 1, TeamId = "ML1", LgId = "NL", Pos = "OF", G = 148, Gs = 148, InnOuts = 3928, Po = 298, A = 9, E = 4, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1966, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "2B", G = 2, Gs = 0, InnOuts = 9, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1966, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 158, Gs = 157, InnOuts = 4066, Po = 315, A = 12, E = 4, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1967, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "2B", G = 1, Gs = 0, InnOuts = 3, Po = 1, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1967, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 152, Gs = 152, InnOuts = 4044, Po = 321, A = 12, E = 7, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1968, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "1B", G = 14, Gs = 14, InnOuts = 309, Po = 88, A = 7, E = 2, Dp = 8, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1968, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 151, Gs = 143, InnOuts = 3874, Po = 330, A = 13, E = 3, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1969, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "1B", G = 4, Gs = 3, InnOuts = 78, Po = 32, A = 2, E = 0, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1969, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 144, Gs = 142, InnOuts = 3743, Po = 267, A = 11, E = 5, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1970, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "1B", G = 11, Gs = 10, InnOuts = 243, Po = 73, A = 4, E = 1, Dp = 6, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1970, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 125, Gs = 125, InnOuts = 3180, Po = 246, A = 6, E = 6, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1971, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "1B", G = 71, Gs = 72, InnOuts = 1845, Po = 629, A = 38, E = 3, Dp = 56, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1971, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 60, Gs = 59, InnOuts = 1548, Po = 104, A = 2, E = 2, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1972, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "1B", G = 109, Gs = 107, InnOuts = 2796, Po = 968, A = 66, E = 14, Dp = 79, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1972, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 15, Gs = 15, InnOuts = 354, Po = 28, A = 4, E = 3, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1973, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 105, Gs = 107, InnOuts = 2624, Po = 206, A = 5, E = 5, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1974, Stint = 1, TeamId = "ATL", LgId = "NL", Pos = "OF", G = 89, Gs = 89, InnOuts = 1992, Po = 142, A = 3, E = 2, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1975, Stint = 1, TeamId = "ML4", LgId = "AL", Pos = "OF", G = 3, Gs = 3, InnOuts = 63, Po = 2, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "aaronha01", YearId = 1976, Stint = 1, TeamId = "ML4", LgId = "AL", Pos = "OF", G = 1, Gs = 0, InnOuts = 6, Po = 1, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1905, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 41, Po = 85, A = 6, E = 4, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1906, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 96, Po = 208, A = 14, E = 9, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1907, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 150, Po = 238, A = 30, E = 11, Dp = 12, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1908, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 150, Po = 212, A = 23, E = 14, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1909, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 156, Po = 222, A = 24, E = 14, Dp = 7, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1910, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 137, Po = 305, A = 18, E = 14, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1911, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 146, Po = 376, A = 24, E = 18, Dp = 10, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1912, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 140, Po = 324, A = 21, E = 22, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1913, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "2B", G = 1, Po = 1, A = 0, E = 3, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1913, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 118, Po = 262, A = 22, E = 16, Dp = 8, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1914, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 96, Po = 177, A = 8, E = 10, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1915, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 156, Po = 328, A = 22, E = 18, Dp = 7, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1916, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "1B", G = 1, Po = 10, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1916, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 143, Po = 325, A = 18, E = 17, Dp = 9, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1917, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 152, Po = 373, A = 27, E = 11, Dp = 9, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1918, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "1B", G = 13, Po = 133, A = 12, E = 3, Dp = 6, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1918, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "2B", G = 1, Po = 1, A = 3, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1918, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "3B", G = 1, Po = 1, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1918, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 95, Po = 225, A = 12, E = 6, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1918, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 2, Po = 0, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1919, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 123, Po = 272, A = 19, E = 8, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1920, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 112, Po = 246, A = 8, E = 9, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1921, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 121, Po = 301, A = 27, E = 10, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1922, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 134, Po = 330, A = 14, E = 7, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1923, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 141, Po = 362, A = 14, E = 12, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1924, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 155, Po = 417, A = 12, E = 6, Dp = 8, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1925, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 105, Po = 267, A = 9, E = 15, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1925, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "P", G = 1, Po = 0, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1926, Stint = 1, TeamId = "DET", LgId = "AL", Pos = "OF", G = 55, Po = 109, A = 4, E = 6, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1927, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "OF", G = 127, Po = 243, A = 9, E = 8, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "cobbty01", YearId = 1928, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "OF", G = 85, Po = 154, A = 7, E = 6, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1906, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 1, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1906, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "3B", G = 1, Po = 1, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1906, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "SS", G = 3, Po = 8, A = 10, E = 2, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1907, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "SS", G = 6, Po = 11, A = 9, E = 4, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1908, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 47, Po = 111, A = 127, E = 14, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1908, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "OF", G = 10, Po = 13, A = 0, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1908, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "SS", G = 28, Po = 60, A = 61, E = 10, Dp = 7, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1909, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 152, Po = 373, A = 406, E = 27, Dp = 55, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1909, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "SS", G = 1, Po = 2, A = 4, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1910, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 153, Po = 402, A = 451, E = 25, Dp = 67, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1911, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 132, Po = 348, A = 349, E = 24, Dp = 49, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1912, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 153, Po = 387, A = 426, E = 38, Dp = 63, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1913, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 148, Po = 314, A = 449, E = 28, Dp = 54, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1914, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 152, Po = 354, A = 387, E = 23, Dp = 55, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1915, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 155, Po = 344, A = 487, E = 22, Dp = 54, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1916, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 155, Po = 346, A = 415, E = 19, Dp = 75, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1917, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 156, Po = 353, A = 388, E = 24, Dp = 68, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1918, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 96, Po = 231, A = 285, E = 14, Dp = 53, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1919, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 140, Po = 347, A = 401, E = 20, Dp = 66, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1920, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 153, Po = 449, A = 471, E = 23, Dp = 76, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1921, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 136, Po = 376, A = 458, E = 28, Dp = 84, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1922, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 154, Po = 406, A = 451, E = 21, Dp = 73, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1923, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 142, Po = 347, A = 430, E = 20, Dp = 77, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1924, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 150, Po = 396, A = 446, E = 20, Dp = 83, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1925, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 116, Po = 290, A = 346, E = 20, Dp = 74, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1926, Stint = 1, TeamId = "CHA", LgId = "AL", Pos = "2B", G = 101, Po = 228, A = 307, E = 15, Dp = 53, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1927, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 56, Po = 124, A = 150, E = 10, Dp = 31, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1927, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "SS", G = 1, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1928, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 2, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied01", YearId = 1928, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "SS", G = 1, Po = 0, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied02", YearId = 1939, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "2B", G = 1, Po = 1, A = 1, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied02", YearId = 1939, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "OF", G = 6, Po = 10, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied02", YearId = 1941, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "OF", G = 50, Po = 119, A = 3, E = 4, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "collied02", YearId = 1942, Stint = 1, TeamId = "PHA", LgId = "AL", Pos = "OF", G = 9, Po = 8, A = 0, E = 2, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1923, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 9, Po = 53, A = 3, E = 4, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1924, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 2, Po = 9, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1924, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 1, Po = 1, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1925, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 114, Po = 1126, A = 53, E = 13, Dp = 72, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1925, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 6, Po = 9, A = 0, E = 2, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1926, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 155, Po = 1566, A = 73, E = 15, Dp = 87, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1927, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 155, Po = 1662, A = 88, E = 15, Dp = 108, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1928, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 154, Po = 1488, A = 79, E = 18, Dp = 112, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1929, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 154, Po = 1458, A = 82, E = 9, Dp = 135, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1930, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 153, Po = 1298, A = 89, E = 15, Dp = 109, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1930, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 1, Po = 2, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1931, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 154, Po = 1352, A = 58, E = 13, Dp = 120, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1931, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 1, Po = 3, A = 0, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1932, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 156, Po = 1293, A = 75, E = 18, Dp = 101, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1933, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 152, Po = 1290, A = 64, E = 9, Dp = 102, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1934, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 153, Po = 1284, A = 80, E = 8, Dp = 126, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1934, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "SS", G = 1, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1935, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 149, Po = 1337, A = 82, E = 15, Dp = 96, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1936, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 155, Po = 1377, A = 82, E = 9, Dp = 128, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1937, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 157, Po = 1370, A = 74, E = 16, Dp = 113, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1938, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 157, Po = 1483, A = 100, E = 14, Dp = 157, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "gehrilo01", YearId = 1939, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 8, Po = 64, A = 4, E = 2, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1951, Stint = 1, TeamId = "NY1", LgId = "NL", Pos = "OF", G = 121, Po = 353, A = 12, E = 9, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1952, Stint = 1, TeamId = "NY1", LgId = "NL", Pos = "OF", G = 34, Po = 109, A = 6, E = 1, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1954, Stint = 1, TeamId = "NY1", LgId = "NL", Pos = "OF", G = 151, Gs = 151, InnOuts = 4039, Po = 448, A = 13, E = 7, Dp = 9, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1955, Stint = 1, TeamId = "NY1", LgId = "NL", Pos = "OF", G = 152, Gs = 152, InnOuts = 4084, Po = 407, A = 23, E = 8, Dp = 8, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1956, Stint = 1, TeamId = "NY1", LgId = "NL", Pos = "OF", G = 152, Gs = 150, InnOuts = 4029, Po = 415, A = 14, E = 9, Dp = 6, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1957, Stint = 1, TeamId = "NY1", LgId = "NL", Pos = "OF", G = 150, Gs = 149, InnOuts = 4061, Po = 422, A = 14, E = 9, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1958, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 151, Gs = 150, InnOuts = 4056, Po = 429, A = 17, E = 9, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1959, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 147, Gs = 143, InnOuts = 3844, Po = 353, A = 6, E = 6, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1960, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 152, Gs = 152, InnOuts = 4044, Po = 392, A = 12, E = 8, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1961, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 153, Gs = 151, InnOuts = 4005, Po = 385, A = 7, E = 8, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1962, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 161, Gs = 159, InnOuts = 4181, Po = 429, A = 6, E = 4, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1963, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 157, Gs = 155, InnOuts = 4161, Po = 397, A = 7, E = 8, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1963, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "SS", G = 1, Gs = 0, InnOuts = 3, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1964, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "1B", G = 1, Gs = 0, InnOuts = 21, Po = 6, A = 1, E = 0, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1964, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "3B", G = 1, Gs = 0, InnOuts = 17, Po = 0, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1964, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 155, Gs = 151, InnOuts = 4039, Po = 370, A = 10, E = 6, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1964, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "SS", G = 1, Gs = 0, InnOuts = 9, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1965, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 151, Gs = 148, InnOuts = 3826, Po = 337, A = 13, E = 6, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1966, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 150, Gs = 147, InnOuts = 3858, Po = 370, A = 8, E = 7, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1967, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 134, Gs = 123, InnOuts = 3226, Po = 277, A = 3, E = 7, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1968, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "1B", G = 1, Gs = 1, InnOuts = 27, Po = 9, A = 0, E = 0, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1968, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 142, Gs = 129, InnOuts = 3431, Po = 301, A = 7, E = 7, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1969, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "1B", G = 1, Gs = 1, InnOuts = 27, Po = 6, A = 0, E = 0, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1969, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 108, Gs = 96, InnOuts = 2601, Po = 199, A = 4, E = 5, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1970, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "1B", G = 5, Gs = 4, InnOuts = 105, Po = 34, A = 3, E = 0, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1970, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 129, Gs = 117, InnOuts = 3120, Po = 269, A = 6, E = 7, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1971, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "1B", G = 48, Gs = 39, InnOuts = 1116, Po = 384, A = 27, E = 11, Dp = 43, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1971, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 84, Gs = 77, InnOuts = 1962, Po = 192, A = 2, E = 6, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1972, Stint = 1, TeamId = "SFN", LgId = "NL", Pos = "OF", G = 14, Gs = 13, InnOuts = 339, Po = 29, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1972, Stint = 2, TeamId = "NYN", LgId = "NL", Pos = "1B", G = 11, Gs = 9, InnOuts = 252, Po = 75, A = 2, E = 1, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1972, Stint = 2, TeamId = "NYN", LgId = "NL", Pos = "OF", G = 49, Gs = 44, InnOuts = 1146, Po = 109, A = 3, E = 3, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1973, Stint = 1, TeamId = "NYN", LgId = "NL", Pos = "1B", G = 17, Gs = 14, InnOuts = 364, Po = 143, A = 4, E = 3, Dp = 9, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "mayswi01", YearId = 1973, Stint = 1, TeamId = "NYN", LgId = "NL", Pos = "OF", G = 45, Gs = 41, InnOuts = 1016, Po = 103, A = 2, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1941, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 11, Po = 20, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1942, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 135, Po = 296, A = 6, E = 5, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1943, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 155, Po = 376, A = 15, E = 7, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1944, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 146, Po = 353, A = 16, E = 5, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1946, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 114, Po = 1056, A = 65, E = 13, Dp = 119, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1946, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 42, Po = 110, A = 4, E = 2, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1947, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 149, Po = 1360, A = 77, E = 8, Dp = 138, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1948, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 2, Po = 7, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1948, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 155, Po = 347, A = 10, E = 7, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1949, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 1, Po = 11, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1949, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 156, Po = 326, A = 10, E = 3, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1950, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 69, Po = 628, A = 37, E = 3, Dp = 66, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1950, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 77, Po = 132, A = 2, E = 5, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1951, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 60, Po = 600, A = 32, E = 4, Dp = 60, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1951, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 91, Po = 216, A = 13, E = 6, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1952, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 25, Po = 204, A = 12, E = 1, Dp = 13, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1952, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 129, Po = 298, A = 6, E = 4, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1952, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "P", G = 1, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1953, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 157, Po = 294, A = 9, E = 5, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1954, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 10, Gs = 2, InnOuts = 92, Po = 36, A = 2, E = 2, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1954, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 152, Gs = 151, InnOuts = 4058, Po = 271, A = 13, E = 3, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1955, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 110, Gs = 106, InnOuts = 2840, Po = 925, A = 92, E = 8, Dp = 93, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1955, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 51, Gs = 48, InnOuts = 1133, Po = 75, A = 2, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1956, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 103, Gs = 103, InnOuts = 2621, Po = 870, A = 90, E = 7, Dp = 96, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1956, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 53, Gs = 53, InnOuts = 1400, Po = 84, A = 5, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1957, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 130, Gs = 129, InnOuts = 3331, Po = 1167, A = 99, E = 10, Dp = 131, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1958, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 124, Gs = 123, InnOuts = 3114, Po = 1019, A = 100, E = 13, Dp = 127, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1959, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 90, Gs = 88, InnOuts = 2058, Po = 623, A = 63, E = 7, Dp = 72, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1959, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 3, Gs = 2, InnOuts = 66, Po = 1, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1960, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "1B", G = 29, Gs = 26, InnOuts = 609, Po = 203, A = 17, E = 2, Dp = 16, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1960, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 59, Gs = 58, InnOuts = 1431, Po = 97, A = 2, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1961, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 103, Gs = 99, InnOuts = 2303, Po = 149, A = 9, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1962, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 119, Gs = 116, InnOuts = 2703, Po = 164, A = 6, E = 4, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "musiast01", YearId = 1963, Stint = 1, TeamId = "SLN", LgId = "NL", Pos = "OF", G = 96, Gs = 94, InnOuts = 1884, Po = 121, A = 1, E = 4, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1914, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "P", G = 4, Po = 0, A = 7, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1915, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "P", G = 32, Po = 17, A = 63, E = 2, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1916, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "P", G = 44, Po = 24, A = 83, E = 3, Dp = 6, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1917, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "P", G = 41, Po = 19, A = 101, E = 2, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1918, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "1B", G = 13, Po = 130, A = 6, E = 5, Dp = 8, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1918, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "OF", G = 59, Po = 121, A = 8, E = 7, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1918, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "P", G = 20, Po = 19, A = 58, E = 6, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1919, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "1B", G = 5, Po = 35, A = 4, E = 1, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1919, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "OF", G = 111, Po = 222, A = 14, E = 1, Dp = 6, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1919, Stint = 1, TeamId = "BOS", LgId = "AL", Pos = "P", G = 17, Po = 13, A = 35, E = 2, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1920, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 2, Po = 10, A = 0, E = 1, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1920, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 141, Po = 259, A = 21, E = 19, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1920, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "P", G = 1, Po = 1, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1921, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 2, Po = 8, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1921, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 152, Po = 348, A = 17, E = 13, Dp = 6, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1921, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "P", G = 2, Po = 1, A = 2, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1922, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 1, Po = 0, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1922, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 110, Po = 226, A = 14, E = 9, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1923, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 4, Po = 41, A = 1, E = 1, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1923, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 148, Po = 378, A = 20, E = 11, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1924, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 152, Po = 340, A = 18, E = 14, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1925, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 98, Po = 207, A = 15, E = 6, Dp = 3, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1926, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 2, Po = 10, A = 0, E = 0, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1926, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 149, Po = 308, A = 11, E = 7, Dp = 5, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1927, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 151, Po = 328, A = 14, E = 13, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1928, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 154, Po = 304, A = 9, E = 8, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1929, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 133, Po = 240, A = 5, E = 4, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1930, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 144, Po = 266, A = 10, E = 10, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1930, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "P", G = 1, Po = 0, A = 4, E = 0, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1931, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 1, Po = 5, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1931, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 142, Po = 237, A = 5, E = 7, Dp = 2, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1932, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 1, Po = 3, A = 0, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1932, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 128, Po = 209, A = 10, E = 9, Dp = 1, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1933, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "1B", G = 1, Po = 6, A = 0, E = 1, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1933, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 132, Po = 215, A = 9, E = 7, Dp = 4, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1933, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "P", G = 1, Po = 1, A = 1, E = 0, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1934, Stint = 1, TeamId = "NYA", LgId = "AL", Pos = "OF", G = 111, Po = 197, A = 3, E = 8, Dp = 0, });
            dbContext.Fielding.Add(new Fielding() { PlayerId = "ruthba01", YearId = 1935, Stint = 1, TeamId = "BSN", LgId = "NL", Pos = "OF", G = 26, Po = 39, A = 1, E = 2, Dp = 0, });
            dbContext.SaveChanges();
        }

        public static void ClearData(LahmansDbContext dbContext)
        {
            if (dbContext.People.Any())
            {
                dbContext.People.RemoveRange(dbContext.People);
            }

            if (dbContext.Fielding.Any())
            {
                dbContext.Fielding.RemoveRange(dbContext.Fielding);
            }

            if (dbContext.Batting.Any())
            {
                dbContext.Batting.RemoveRange(dbContext.Batting);
            }

            if (dbContext.Pitching.Any())
            {
                dbContext.Pitching.RemoveRange(dbContext.Pitching);
            }

            dbContext.SaveChanges();
        }
    }
}
