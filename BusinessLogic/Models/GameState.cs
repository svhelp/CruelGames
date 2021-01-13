using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    /// <summary>
    /// Состояние игры.
    /// </summary>
    public sealed class GameState
    {
        public List<Player> Players { get; set; } = new List<Player>();

        public List<PlayersGroup> Groups { get; set; } = new List<PlayersGroup>();
    }
}
