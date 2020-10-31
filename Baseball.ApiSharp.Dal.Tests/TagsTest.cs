#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Linq;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Data.Lahman;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;
using Xunit;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class TagsTest
    {
        public TagsTest()
        {
            Setup();
        }

        private LahmansDbContext _dbContext;

        private void Setup()
        {
            var helper = new TestContextHelper();
            _dbContext = new LahmansDbContext(helper.Options);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void AddTagData()
        {
            int uniqueId = RandomNumberHelper.NextInteger();
            var tagData = new Tag() { DataFieldReferencesAsJson = "{ }", TagId = $"tagId-{uniqueId}", TagValue = $"tagValue" };
            _dbContext.Add(tagData);
            int saveCount = _dbContext.SaveChanges();
            Assert.Equal(1, saveCount);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void AddAndQueryTagData()
        {
            int uniqueId = RandomNumberHelper.NextInteger();
            var tagId = $"tagId-{uniqueId}";
            var tagValue = $"tagValue";
            var tagData = new Tag() { DataFieldReferencesAsJson = "{ }", TagId = tagId, TagValue = tagValue };
            _dbContext.Add(tagData);
            int saveCount = _dbContext.SaveChanges();
            Assert.Equal(1, saveCount);

            var tagFound = _dbContext.Tags.FirstOrDefault(t => t.TagId == tagId);
            Assert.Equal(tagValue, tagFound.TagValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void AddAndQueryDeleteTagData()
        {
            int uniqueId = RandomNumberHelper.NextInteger();
            var tagId = $"tagId-{uniqueId}";
            var tagValue = $"tagValue";
            var tagData = new Tag() {DataFieldReferencesAsJson = "{ }", TagId = tagId, TagValue = tagValue};
            _dbContext.Add(tagData);
            int saveCount = _dbContext.SaveChanges();
            Assert.Equal(1, saveCount);

            var tagFound = _dbContext.Tags.FirstOrDefault(t => t.TagId == tagId);
            Assert.Equal(tagValue, tagFound.TagValue);

            _dbContext.Tags.Remove(tagFound);
            int updatedCount = _dbContext.SaveChanges();
            Assert.Equal(1, updatedCount);

            var tagNotFound = _dbContext.Tags.Any(t => t.TagId == tagId);
            Assert.False(tagNotFound);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void AddBatterAndAddTag()
        {
            var entityId = "playerId";
            var newBatter = new Batting
            {
                PlayerId = entityId,
                LgId = "leagueId",
                TeamId = "teamId",
                Stint = 1,
                YearId = 2010,
                Hr =  120
            };
            // TODO: Persist batter 

            int uniqueId = RandomNumberHelper.NextInteger();
            var tagId = $"tagId-{uniqueId}";
            var tagValue = $"tagValue";
            var tagData = new Tag() { DataFieldReferencesAsJson = "{ Highlight = \"Hr was 120. Best year ever.\" }", TagId = tagId, TagValue = tagValue };
            // TODO: Persist tag data 

            var relationship = new TagRelationship {TagId = tagId, DataEntityId = entityId};
            // TODO: Persist tag relationship 

        }
    }
}
