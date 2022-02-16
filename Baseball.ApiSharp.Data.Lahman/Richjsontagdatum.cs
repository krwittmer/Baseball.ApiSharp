using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Richjsontagdatum
    {
        public int TagId { get; set; }
        public string TagRichDetail { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
