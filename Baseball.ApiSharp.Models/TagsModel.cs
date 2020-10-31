#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System.Collections.Generic;

namespace Baseball.ApiSharp.Models
{
    public class TagsModel
    {
        public string SimpleTagData { get; set; }

        public string Delimiter { get; set; }

        public List<TagModel> RichTagData { get; set; }
    }
}
