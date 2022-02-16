using System;
using System.Collections.Generic;

namespace Baseball.ApiSharp.Data.Lahman
{
    public partial class Tag
    {
        public string TagId { get; set; }
        public string TagValue { get; set; }
        public string DataFieldReferencesAsJson { get; set; }
    }
}
