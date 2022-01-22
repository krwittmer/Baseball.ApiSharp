using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Homegame
    {
        public int Id { get; set; }
        public int? Yearkey { get; set; }
        public string Leaguekey { get; set; }
        public string Teamkey { get; set; }
        public int? TeamId { get; set; }
        public string Parkkey { get; set; }
        public int? ParkId { get; set; }
        public string Spanfirst { get; set; }
        public string Spanlast { get; set; }
        public int? Games { get; set; }
        public int? Openings { get; set; }
        public int? Attendance { get; set; }
        public DateOnly? SpanfirstDate { get; set; }
        public DateOnly? SpanlastDate { get; set; }

        public virtual League LeaguekeyNavigation { get; set; }
        public virtual Park Park { get; set; }
        public virtual Team Team { get; set; }
    }
}
