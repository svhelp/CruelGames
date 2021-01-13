using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// Состояние игры.
    /// </summary>
    public sealed class GameState
    {
        public List<Player> Players { get; set; } = new List<Player>();
    }
}
