#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Dal.Initialization.SampleData;
using Baseball.ApiSharp.Models;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Mvc.Models.ViewModels
{
    public class PlayerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string HomeTown { get; set; }

        public string FinalGame { get; set; }

        public List<PitcherViewModel> PitchingResults;
        public List<BatterViewModel> BatterResults;

        public IDictionary<string, string> PlayerData =  new SortedDictionary<string, string>();

        public static IList<string> BindFields = new List<string>();

        public void IterateNow(IDictionary<string, string> dictionaryData)
        {
            IEnumerator<string> enumerator = DefaultFirstKeys(dictionaryData);

            if (enumerator.MoveNext())
            {
                var key1 = enumerator.Current;
                var value1 = dictionaryData[key1];
            }
            if (enumerator.MoveNext())
            {
                var key2 = enumerator.Current;
                var value2 = dictionaryData[key2];
            }

            if (enumerator.MoveNext())
            {
                var key3 = enumerator.Current;
                var value3 = dictionaryData[key3];
            }
        }

        private static void SelectKeys()
        {
            ICollection<string> collection = new List<string>() { nameof(PlayerModel.FirstName), 
                nameof(PlayerModel.LastName), nameof(PlayerModel.DebutGameDate) };
        }

        private static IEnumerator<string> DefaultFirstKeys(IDictionary<string, string> dictionaryData)
        {
            var collection = dictionaryData.Keys;
            var enumerator = collection.GetEnumerator();
            return enumerator;
        }

        public string NextBindField()
        {
            return string.Empty;
        }
    }
}
