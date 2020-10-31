using Baseball.ApiSharp.Data.Lahman.BaseEntities;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Fielding : PositionEntityBase
    {
        public string Pos { get; set; }
        public short? G { get; set; }
        public short? Gs { get; set; }
        public short? InnOuts { get; set; }
        public short? Po { get; set; }
        public short? A { get; set; }
        public short? E { get; set; }
        public short? Dp { get; set; }
        public short? Pb { get; set; }
        public short? Wp { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public double? Zr { get; set; }
    }
}
