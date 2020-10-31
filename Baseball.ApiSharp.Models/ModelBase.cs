#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

namespace Baseball.ApiSharp.Models
{
    public class ModelBase
    {
        public string PlayerId { get; set; }
        public string TeamId { get; set; }
        public string LeagueId { get; set; }
        public short YearId { get; set; }

        /// <summary>
        ///  Zero or more tags
        /// </summary>
        public TagModel[] Tags { get; set; } = new TagModel[0];
    }
}
