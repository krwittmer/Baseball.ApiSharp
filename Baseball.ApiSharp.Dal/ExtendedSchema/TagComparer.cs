#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;

namespace Baseball.ApiSharp.Dal.ExtendedSchema
{
    class TagComparer : IEqualityComparer<Tag>
    {
        public bool Equals(Tag tag1, Tag tag2)
        {
            if (tag2 != null && (tag1 != null && tag1.TagId == tag2.TagId))
            {
                return true;
            }
            return false;
        }
        public int GetHashCode(Tag obj)
        {
            return obj.TagId.GetHashCode();
        }
    }
}
