#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;
using Microsoft.EntityFrameworkCore;

namespace Baseball.ApiSharp.Dal.EfStructures
{
    public partial class LahmansDbContext : DbContext
    {
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagRelationship> TagRelationships { get; set; }

    }
}
