using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Team
    {
        public Team()
        {
            Allstarfulls = new HashSet<Allstarfull>();
            Battingposts = new HashSet<Battingpost>();
            Battings = new HashSet<Batting>();
            Fieldingofsplits = new HashSet<Fieldingofsplit>();
            Fieldingposts = new HashSet<Fieldingpost>();
            Fieldings = new HashSet<Fielding>();
            Homegames = new HashSet<Homegame>();
            Managers = new HashSet<Manager>();
            Managershalves = new HashSet<Managershalf>();
            Pitchingposts = new HashSet<Pitchingpost>();
            Pitchings = new HashSet<Pitching>();
            Teamshalves = new HashSet<Teamshalf>();
        }

        public int Id { get; set; }
        public short YearId { get; set; }
        public string LgId { get; set; }
        public string TeamId { get; set; }
        public string FranchId { get; set; }
        public string DivId { get; set; }
        public int? DivId1 { get; set; }
        public short? TeamRank { get; set; }
        public short? G { get; set; }
        public short? Ghome { get; set; }
        public short? W { get; set; }
        public short? L { get; set; }
        public string DivWin { get; set; }
        public string Wcwin { get; set; }
        public string LgWin { get; set; }
        public string Wswin { get; set; }
        public short? R { get; set; }
        public short? Ab { get; set; }
        public short? H { get; set; }
        public short? _2b { get; set; }
        public short? _3b { get; set; }
        public short? Hr { get; set; }
        public short? Bb { get; set; }
        public short? So { get; set; }
        public short? Sb { get; set; }
        public short? Cs { get; set; }
        public short? Hbp { get; set; }
        public short? Sf { get; set; }
        public short? Ra { get; set; }
        public short? Er { get; set; }
        public double? Era { get; set; }
        public short? Cg { get; set; }
        public short? Sho { get; set; }
        public short? Sv { get; set; }
        public int? Ipouts { get; set; }
        public short? Ha { get; set; }
        public short? Hra { get; set; }
        public short? Bba { get; set; }
        public short? Soa { get; set; }
        public int? E { get; set; }
        public int? Dp { get; set; }
        public double? Fp { get; set; }
        public string Name { get; set; }
        public string Park { get; set; }
        public int? Attendance { get; set; }
        public int? Bpf { get; set; }
        public int? Ppf { get; set; }
        public string TeamIdbr { get; set; }
        public string TeamIdlahman45 { get; set; }
        public string TeamIdretro { get; set; }

        public virtual Division DivId1Navigation { get; set; }
        public virtual Teamsfranchise Franch { get; set; }
        public virtual League Lg { get; set; }
        public virtual ICollection<Allstarfull> Allstarfulls { get; set; }
        public virtual ICollection<Battingpost> Battingposts { get; set; }
        public virtual ICollection<Batting> Battings { get; set; }
        public virtual ICollection<Fieldingofsplit> Fieldingofsplits { get; set; }
        public virtual ICollection<Fieldingpost> Fieldingposts { get; set; }
        public virtual ICollection<Fielding> Fieldings { get; set; }
        public virtual ICollection<Homegame> Homegames { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Managershalf> Managershalves { get; set; }
        public virtual ICollection<Pitchingpost> Pitchingposts { get; set; }
        public virtual ICollection<Pitching> Pitchings { get; set; }
        public virtual ICollection<Teamshalf> Teamshalves { get; set; }
    }
}
