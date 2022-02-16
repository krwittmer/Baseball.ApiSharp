using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Person
    {
        public Person()
        {
            Awardsplayers = new HashSet<Awardsplayer>();
            Awardssharemanagers = new HashSet<Awardssharemanager>();
            Awardsshareplayers = new HashSet<Awardsshareplayer>();
            Battingposts = new HashSet<Battingpost>();
            Battings = new HashSet<Batting>();
            Collegeplayings = new HashSet<Collegeplaying>();
            Fieldingofs = new HashSet<Fieldingof>();
            Fieldingofsplits = new HashSet<Fieldingofsplit>();
            Fieldingposts = new HashSet<Fieldingpost>();
            Fieldings = new HashSet<Fielding>();
            Halloffames = new HashSet<Halloffame>();
            Managers = new HashSet<Manager>();
            Managershalves = new HashSet<Managershalf>();
            Pitchingposts = new HashSet<Pitchingpost>();
            Pitchings = new HashSet<Pitching>();
        }

        public string PlayerId { get; set; }
        public int? BirthYear { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthDay { get; set; }
        public string BirthCountry { get; set; }
        public string BirthState { get; set; }
        public string BirthCity { get; set; }
        public int? DeathYear { get; set; }
        public int? DeathMonth { get; set; }
        public int? DeathDay { get; set; }
        public string DeathCountry { get; set; }
        public string DeathState { get; set; }
        public string DeathCity { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NameGiven { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public string Bats { get; set; }
        public string Throws { get; set; }
        public string Debut { get; set; }
        public string FinalGame { get; set; }
        public string RetroId { get; set; }
        public string BbrefId { get; set; }
        public DateOnly? BirthDate { get; set; }
        public DateOnly? DebutDate { get; set; }
        public DateOnly? FinalgameDate { get; set; }
        public DateOnly? DeathDate { get; set; }

        public virtual ICollection<Awardsplayer> Awardsplayers { get; set; }
        public virtual ICollection<Awardssharemanager> Awardssharemanagers { get; set; }
        public virtual ICollection<Awardsshareplayer> Awardsshareplayers { get; set; }
        public virtual ICollection<Battingpost> Battingposts { get; set; }
        public virtual ICollection<Batting> Battings { get; set; }
        public virtual ICollection<Collegeplaying> Collegeplayings { get; set; }
        public virtual ICollection<Fieldingof> Fieldingofs { get; set; }
        public virtual ICollection<Fieldingofsplit> Fieldingofsplits { get; set; }
        public virtual ICollection<Fieldingpost> Fieldingposts { get; set; }
        public virtual ICollection<Fielding> Fieldings { get; set; }
        public virtual ICollection<Halloffame> Halloffames { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Managershalf> Managershalves { get; set; }
        public virtual ICollection<Pitchingpost> Pitchingposts { get; set; }
        public virtual ICollection<Pitching> Pitchings { get; set; }
    }
}
