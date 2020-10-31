#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.ComponentModel.DataAnnotations;

namespace Baseball.ApiSharp.Data.Lahman.ExtendedSchema
{
    public class Tag
    {
        [MaxLength(64)]
        public string TagId { get; set; }

        [MaxLength(512)]
        public string TagValue { get; set; }

        [MaxLength(1024)]
        public string DataFieldReferencesAsJson { get; set; }
    }
}
