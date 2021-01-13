using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Actions.PlayerActions
{
    /// <summary>
    /// Модель для переименования игрока.
    /// </summary>
    public sealed class PlayerRenameActionModel
    {
        public Guid PlayerId { get; set; }

        public string Name { get; set; }
    }
}
