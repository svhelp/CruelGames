using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    /// <summary>
    /// Состояние группы игроков.
    /// </summary>
    public class PlayersGroup
    {
        public Guid SoloPlayerId { get; set; }

        public bool? SoloPlayerCooperates { get; set; }

        public Guid GroupPlayerLeaderId { get; set; }

        public bool? GroupCooperates { get; set; }

        public List<Guid> PlayerIds { get; set; } = new List<Guid>();
    }
}
