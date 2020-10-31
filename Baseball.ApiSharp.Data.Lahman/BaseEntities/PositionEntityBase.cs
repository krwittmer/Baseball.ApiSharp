#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

namespace Baseball.ApiSharp.Data.Lahman.BaseEntities
{
    public class PositionEntityBase : EntityBase
    {
        public short YearId { get; set; }
        public short Stint { get; set; }
        public string TeamId { get; set; }
        public string LgId { get; set; }
    }
}
