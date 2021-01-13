using Settings;
using Settings.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Game
    {
        private readonly GameConfig _config;
        private readonly GameState _gameState;

        public Game(IGameConfigReader configReader)
        {
            if (configReader == null)
                throw new ArgumentNullException("configReader");

            _config = configReader.ReadConfig();
            _gameState = new GameState();

            //_gameState.Initialize(_config.InitialPlayer);
        }

        public GameState State
        {
            get { return _gameState; }
        }
    }
}
