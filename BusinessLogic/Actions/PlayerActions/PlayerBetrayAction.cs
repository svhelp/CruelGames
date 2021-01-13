using BusinessLogic.Models;
using Settings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Actions.PlayerActions
{
    public class PlayerBetrayAction : PlayerSimpleActionBase
    {
        protected override ActionResultBase ProcessCore(GameState state, GameConfig config, Guid model)
        {
            var playerGroup = GetPlayerGroup(state, model);

            if (playerGroup.SoloPlayerId == model)
            {
                playerGroup.SoloPlayerCooperates = false;
                return new ActionResultBase();
            }

            if (playerGroup.GroupPlayerLeaderId == model)
            {
                playerGroup.GroupCooperates = false;
                return new ActionResultBase();
            }

            throw new Exception("Игроку недоступно данное действие.");
        }
    }
}
