#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using System.Threading.Tasks;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;
using Baseball.ApiSharp.Models;

namespace Baseball.ApiSharp.Api.Interfaces
{
    public interface IMyTagsHelper
    {
        void AppendTags(IEnumerable<ModelBase> models);
        Task<TagRelationship> GetOrCreateTagRelationship(string tagDataTagId, string entityId);
        Task<Tag> GetOrCreateTag(string tagValue);
    }
}
