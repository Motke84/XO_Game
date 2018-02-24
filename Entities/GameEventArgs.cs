using System;
using TicTacToe.Utils;

namespace TicTacToe.Entities
{
    public class GameEventArgs : EventArgs
    {
        private readonly Enums.GameStatus _gameState;
        private readonly string _name;
   
        public GameEventArgs(string name, Enums.GameStatus gameState)
        {
            _name = name;
            _gameState = gameState;
        }

        public string Name => _name;

        public Enums.GameStatus GameState => _gameState;

        public override string ToString()
        {
            return 
                $"player: {_name} won";
        }
    }
}