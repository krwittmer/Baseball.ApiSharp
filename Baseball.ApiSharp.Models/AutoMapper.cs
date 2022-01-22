#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using AutoMapper;
using Baseball.ApiSharp.Data.Lahman;
using Baseball.ApiSharp.Data.Lahman.ExtendedSchema;

namespace Baseball.ApiSharp.Models
{
    public class AutoMapper
    {
        private readonly IMapper _theMapper;

        public AutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BatterModel, Batting>();
                cfg.CreateMap<FielderModel, Fielding>();
                cfg.CreateMap<PitcherModel, Pitching>();

                cfg.CreateMap<TagModel, Baseball.ApiSharp.Data.Lahman.Tag>();
            });
            _theMapper = config.CreateMapper();
        }

        public T MapObject<T>(object source)
        {
            return _theMapper.Map<T>(source);
        }
    }
}
