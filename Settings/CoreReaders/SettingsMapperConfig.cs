using AutoMapper;
using Settings.ConfigSection;
using Settings.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.CoreReaders
{
    public static class SettingsMapperConfig
    {
        private static readonly IMapper mapper;
        static SettingsMapperConfig()
        {
            MapperConfiguration conf = new MapperConfiguration(c =>
            {
                c.CreateMap<GameConfigSection, GameConfig>();

                c.CreateMap<InitialPlayerConfig, InitialPlayerConfigElement>();
                c.CreateMap<BattleConfig, BattleConfigElement>();
            });

            mapper = new Mapper(conf);
        }

        public static GameConfig Map(this GameConfigSection section)
        {
            return mapper.Map<GameConfigSection, GameConfig>(section);
        }
    }
}
