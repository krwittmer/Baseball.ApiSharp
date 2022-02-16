#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

#pragma warning disable 1591
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Data.Lahman.BaseEntities;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;
using Baseball.ApiSharp.Models;
using Microsoft.Extensions.Logging;

namespace Baseball.ApiSharp.Dal.ExtendedSchema
{
    public class TagRelationshipManager
    {
        private readonly ILogger<TagRelationshipManager> _logger;
        private readonly IRepository _repository;

        public TagRelationshipManager(IRepository repository, ILoggerFactory factory)
        {
            _repository = repository;
            _logger = factory?.CreateLogger<TagRelationshipManager>();
        }

        public async Task<(int, int)> UpdateTags(string playerId, List<Tag> revisedTags, bool disableAsync = false)
        {
            var existingTags = LoadTags(playerId);

            // Use the Except method to identify the set of tags to add as new relationships.
            var newTags = revisedTags.Except(existingTags, new TagComparer());
            var newTagList = newTags.ToList();
            foreach (var newTag in newTagList)
            {
                var theTag = await CreateOrGetNewTag(newTag);

                var newRelationship = new TagRelationship
                    {TagRelationshipId = Guid.NewGuid().ToString(), DataEntityId = playerId, TagId = theTag.TagId};
                if (disableAsync)
                {
                    _ = _repository.Create(newRelationship);
                }
                else
                {
                    await _repository.Create(newRelationship);
                }
            }

            var addedTagsCount = newTagList.Count();

            // Use the Except method to identify the set of tags to remove as relationships.
            var deletedTags = existingTags.Except(revisedTags, new TagComparer());
            var deletedTagList = deletedTags.ToList();
            foreach (var tagToDelete in deletedTagList)
            {
                var relationshipToDelete =
                    _repository.Filter<TagRelationship>(r =>
                        r.DataEntityId == playerId && r.TagId == tagToDelete.TagId);
                if (disableAsync)
                {
                    _ = _repository.Delete(relationshipToDelete);
                }
                else
                {
                    await _repository.Delete(relationshipToDelete);
                }
            }

            var deletedTagsCount = deletedTagList.Count();

            return (addedTagsCount, deletedTagsCount);
        }

        private async Task<Tag> CreateOrGetNewTag(Tag tag)
        {
            _logger.LogInformation("Filtering on matching tag value");
            var tags = _repository.Filter<Tag>(t => t.TagValue == tag.TagValue).ToList();
            if (!tags.Any()) // TODO: find a better way do to this!
            {
                _logger.LogInformation("No matching tag found. Creating a new tag");
                await _repository.Create(tag, true);
                _logger.LogInformation($"Tag {tag.TagId} persisted.");
            }
            else
            {
                var existingTag = tags.First();
                tag = existingTag;
                _logger.LogInformation($"Taking the first matching tag. Matching tag {tag.TagId}.");
            }

            return tag;
        }

        private List<Tag> LoadTags(string playerId)
        {
            var tags = new List<Tag>();
            if (!(_repository.GetContext() is LahmansDbContext context)) return tags;
            var tagResults = from t in context.Tags
                join tr in context.TagRelationships on t.TagId equals tr.TagId
                where tr.DataEntityId == playerId
                select t;
            tags.AddRange(tagResults.ToList());
            return tags;
        }

        public void ClearTags(ModelBase model)
        {
            model.Tags = new TagModel[0];
            _repository.Update(model);
            _repository.SaveChanges();
        }

        public IEnumerable<EntityBase> GetBattersByTag(string tagValue)
        {
            var battingResults = new List<EntityBase>();
            if (!(_repository.GetContext() is LahmansDbContext context)) return battingResults;
            var queryResults = from t in context.Tags
                where t.TagValue == tagValue
                join tr in context.TagRelationships on t.TagId equals tr.TagId
                join b in context.Batting on tr.DataEntityId equals b.PlayerId
                select b;
            // TODO: if (queryResults.Any()) battingResults.AddRange(queryResults.ToList());

            return battingResults;
        }

        // TODO: _repository.Dispose();

        public void AppendTags(ICollection<BatterModel> batterModels)
        {
            var playerId = batterModels.First().PlayerId;
            foreach (var batter in batterModels)
            {
                var tags = LoadTags(playerId);
                var tagModels = Mapper.Map<TagModel>(tags.AsQueryable());
                batter.Tags = tagModels.ToArray();
            }
        }
    }
}