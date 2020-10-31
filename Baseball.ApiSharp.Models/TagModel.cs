#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

namespace Baseball.ApiSharp.Models
{
    public class TagModel
    {
        public string TagId { get; set; }

        public string TagValue { get; set; }

        // TODO: Newtonsoft.Json.Serialization.
        public string DataFieldReferencesAsJson { get; set; }
    }
}
