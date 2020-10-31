#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.ComponentModel.DataAnnotations;

namespace Baseball.ApiSharp.Data.Lahman.ExtendedSchema
{
    public class TagRelationship
    {
        [MaxLength(64)]
        public string TagRelationshipId { get; set; }

        [MaxLength(64)]
        public string DataEntityId { get; set; }

        [MaxLength(64)]
        public string TagId { get; set; }
    }
}
