#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Dal.ExtendedSchema;
using Xunit;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class TagsTransformationTest
    {
        [Fact]
        public void Test3TagsWithSpace()
        {
            var tags  = TagTransformer.Transform("abc | bcd | cde");
            Assert.NotNull(tags);
            Assert.Equal("bcd", tags[1].TagValue);
        }

        [Fact]
        public void Test3Tags()
        {
            var tags = TagTransformer.Transform("tag1|tag2|tag3");
            Assert.NotNull(tags);
            Assert.Equal("tag2", tags[1].TagValue);
        }

    }
}
