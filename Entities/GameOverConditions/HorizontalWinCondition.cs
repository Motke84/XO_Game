
using TicTacToe.Entities;
using TicTacToe.Entities.GameOverConditions;
using TicTacToe.Interfaces;
using TicTacToe.Utils;

namespace SolidTacToe.GameOverConditions
{
    /// <summary>
    /// Represents a game over condition where the game was won horizontally
    /// </summary>
    public class HorizontalWinCondition : IGameEndCondition
    {
  
        public bool ConditionMet(Enums.Symbol playerSymbol, IGameBoard board)
        {
            for (var row = 0; row < board.Size; row++)
            {
                var met = true;
                for (var column = 0; column < board.Size; column++)
                {
                    met = met && board.Get(column, row) == playerSymbol;
                }

                if (met)
                    return true;
            }
            return false;
        }

        public Enums.GameStatus GameStatus => Enums.GameStatus.PlayerWon;
    }
}
