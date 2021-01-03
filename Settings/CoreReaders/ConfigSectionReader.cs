using Settings.ConfigSection;
using Settings.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Settings.CoreReaders
{
    /// <summary>
    /// Считыватель конфига из файла конфигурации.
    /// </summary>
    public sealed class ConfigSectionReader : IGameConfigReader
    {
        public GameConfig ReadConfig()
        {
            GameConfigSection config = (GameConfigSection)ConfigurationManager.GetSection("gameConfig");

            GameConfig gameConfig = config.Map();
            return gameConfig;
        }
    }
}
