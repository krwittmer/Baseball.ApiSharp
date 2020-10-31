using Baseball.ApiSharp.Data.Lahman.BaseEntities;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Batting : PositionEntityBase
    {
        public short? G { get; set; }
        public short? GBatting { get; set; }
        public short? Ab { get; set; }
        public short? R { get; set; }
        public short? H { get; set; }
        public short? _2b { get; set; }
        public short? _3b { get; set; }
        public short? Hr { get; set; }
        public short? Rbi { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public short? Bb { get; set; }
        public short? So { get; set; }
        public short? Ibb { get; set; }
        public short? Hbp { get; set; }
        public short? Sh { get; set; }
        public short? Sf { get; set; }
        public short? Gidp { get; set; }
    }
}
