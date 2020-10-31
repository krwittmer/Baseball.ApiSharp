#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;
using System.Collections.Generic;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;
using Baseball.ApiSharp.Models;

namespace Baseball.ApiSharp.Dal.ExtendedSchema
{
    public class TagTransformer
    {
        public static List<Tag> Transform(TagsModel model)
        {
            var tags = new List<Tag>();

            if (!string.IsNullOrWhiteSpace(model.SimpleTagData))
            {
                var charDelimiter = '|';
                var delimiter = model.Delimiter;
                if (!string.IsNullOrWhiteSpace(delimiter) && delimiter.Length == 1)
                {
                    charDelimiter = delimiter[0];
                }
                tags.AddRange(Transform(model.SimpleTagData, charDelimiter));
            }
            else if (model.RichTagData != null && model.RichTagData.Count > 0)
            {
                tags.AddRange(Transform(model.RichTagData));
            }

            return tags;
        }

        public static List<Tag> Transform(string tagValues, char delimiter = '|')
        {
            var tagValuesSeparated = tagValues.Split(delimiter);
            var tags = new List<Tag>();
            foreach (var tagValue in tagValuesSeparated)
            {
                var tagData = new Tag() {TagId = Guid.NewGuid().ToString(), TagValue = tagValue.Trim()};
                tags.Add(tagData);
            }

            return tags;
        }

        public static List<Tag> Transform(List<TagModel> tagModels)
        {
            var tags = new List<Tag>();
            foreach (var model in tagModels)
            {
                var tagData = new Tag() { TagId = model.TagId, TagValue = model.TagValue, DataFieldReferencesAsJson = model.DataFieldReferencesAsJson };
                tags.Add(tagData);
            }

            return tags;
        }
    }
}