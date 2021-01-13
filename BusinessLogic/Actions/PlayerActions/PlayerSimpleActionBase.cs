using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Actions.PlayerActions
{
    public abstract class PlayerSimpleActionBase : ActionBase<Guid>
    {
        protected PlayersGroup GetPlayerGroup(GameState state, Guid model)
        {

            var player = state.Players.FirstOrDefault(p => p.Id == model);

            if (player == null)
            {
                throw new Exception("Игрок не найден.");
            }

            var playerGroup = state.Groups.FirstOrDefault(gr => gr.PlayerIds.Contains(model));

            if (playerGroup == null)
            {
                throw new Exception("Не удалось определить группу игрока.");
            }

            return playerGroup;
        }
    }
}
