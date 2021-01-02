using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    /// <summary>
    /// Настройки игры.
    /// </summary>
    public sealed class GameConfig
    {
        public InitialPlayerConfig InitialPlayerConfig { get; set; } = new InitialPlayerConfig();

        public BattleConfig BattleConfig { get; set; } = new BattleConfig();

        public int PrivateDiscussionTime { get; set; }

        public int PublicDiscussionTime { get; set; }

        public int WinPointsThreshold { get; set; }

        public int LosePointsThreshold { get; set; }
    }
}
