#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using Baseball.ApiSharp.Dal.EfStructures;
using Baseball.ApiSharp.Dal.ExtendedSchema;
using Baseball.ApiSharp.Dal.Repos;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class TagRelationshipsTest
    {
        // TODO: Adjust TestContextHelper to support DB or in-memory test configuration

        public TagRelationshipsTest()
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
        public void AddBasicRelationship()
        {
            var newRelationship = new TagRelationship
            {
                TagId = "id0001", DataEntityId = "dataEntityId0001", TagRelationshipId = "rel0001"
            };
            _dbContext.TagRelationships.Add(newRelationship);
            int savedCount = _dbContext.SaveChanges();
            Assert.Equal(1, savedCount);
        }

        [Fact]
        public async void AddTagDataToBatter()
        {
            var repository = new Repository(_dbContext);
            var manager = new TagRelationshipManager(repository, new LoggerFactory());
            var revisedTags = new List<Tag>
            {
                new Tag() {TagId = "Tag-1", TagValue = "Tag A"}, new Tag() {TagId = "Tag-2", TagValue = "Tag B"}
            };
            var results = await manager.UpdateTags("batter-player123", revisedTags);
            Assert.True(2 == results.Item1);
            Assert.True(0 == results.Item2);
        }

        [Fact]
        public async void AddAndDeleteTagDataToBatter()
        {
            var repository = new Repository(_dbContext);
            var manager = new TagRelationshipManager(repository, new LoggerFactory());
            var initialTags = new List<Tag>
            {
                new Tag() {TagId = "Tag-1", TagValue = "Tag A"}, new Tag() {TagId = "Tag-2", TagValue = "Tag B"}
            };
            var results = await manager.UpdateTags("batter-player123", initialTags, true);
            Assert.True(2 == results.Item1);
            Assert.True(0 == results.Item2);

            var revisedTags = new List<Tag>
            {
                new Tag() {TagId = "Tag-2", TagValue = "Tag B"}
            };
            var updatedResults = await manager.UpdateTags("batter-player123", revisedTags, true);
            Assert.True(0 == updatedResults.Item1);
            Assert.True(1 == updatedResults.Item2);
        }
    }
}
