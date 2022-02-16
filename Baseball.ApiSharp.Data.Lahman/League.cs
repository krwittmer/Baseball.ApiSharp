using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class League
    {
        public League()
        {
            Allstarfulls = new HashSet<Allstarfull>();
            Awardsplayers = new HashSet<Awardsplayer>();
            Awardssharemanagers = new HashSet<Awardssharemanager>();
            Awardsshareplayers = new HashSet<Awardsshareplayer>();
            Battingposts = new HashSet<Battingpost>();
            Battings = new HashSet<Batting>();
            Divisions = new HashSet<Division>();
            Fieldingofsplits = new HashSet<Fieldingofsplit>();
            Fieldingposts = new HashSet<Fieldingpost>();
            Fieldings = new HashSet<Fielding>();
            Homegames = new HashSet<Homegame>();
            Managers = new HashSet<Manager>();
            Managershalves = new HashSet<Managershalf>();
            Pitchingposts = new HashSet<Pitchingpost>();
            Pitchings = new HashSet<Pitching>();
            Teams = new HashSet<Team>();
            Teamshalves = new HashSet<Teamshalf>();
        }

        public string LgId { get; set; }
        public string League1 { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Allstarfull> Allstarfulls { get; set; }
        public virtual ICollection<Awardsplayer> Awardsplayers { get; set; }
        public virtual ICollection<Awardssharemanager> Awardssharemanagers { get; set; }
        public virtual ICollection<Awardsshareplayer> Awardsshareplayers { get; set; }
        public virtual ICollection<Battingpost> Battingposts { get; set; }
        public virtual ICollection<Batting> Battings { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<Fieldingofsplit> Fieldingofsplits { get; set; }
        public virtual ICollection<Fieldingpost> Fieldingposts { get; set; }
        public virtual ICollection<Fielding> Fieldings { get; set; }
        public virtual ICollection<Homegame> Homegames { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Managershalf> Managershalves { get; set; }
        public virtual ICollection<Pitchingpost> Pitchingposts { get; set; }
        public virtual ICollection<Pitching> Pitchings { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Teamshalf> Teamshalves { get; set; }
    }
}
