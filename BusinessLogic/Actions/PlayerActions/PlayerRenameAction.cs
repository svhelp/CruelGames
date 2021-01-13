using BusinessLogic.Models;
using Settings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Actions.PlayerActions
{
    /// <summary>
    /// Переименовать игрока.
    /// </summary>
    public class PlayerRenameAction : ActionBase<PlayerRenameActionModel>
    {
        protected override ActionResultBase ProcessCore(GameState state, GameConfig config, PlayerRenameActionModel model)
        {
            var player = state.Players.FirstOrDefault(p => p.Id == model.PlayerId);

            if (player == null)
            {
                return new ActionResultBase("Игрок для переименования не найден.");
            }

            player.Name = model.Name;

            return new ActionResultBase();
        }
    }
}
