using Settings.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Settings
{
    /// <summary>
    /// Интерфейс чтения конфига игры.
    /// </summary>
    public interface IGameConfigReader
    {
        GameConfig ReadConfig();
    }
}
