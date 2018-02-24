using TicTacToe.Interfaces;
using TicTacToe.Utils;

namespace TicTacToe.Entities.GameOverConditions
{
    public class VerticalWinCondition : IGameEndCondition
    {
  
        public bool ConditionMet(Enums.Symbol playerSymbol, IGameBoard board)
        {
            for (var column = 0; column < board.Size; column++)
            {
                var met = true;
                for (var row = 0; row < board.Size; row++)
                {
                    met = met && board.Get(column, row) == playerSymbol;
                }
                if (met)
                {
                    return true;
                }
            }
            return false;
        }

        public Enums.GameStatus GameStatus => Enums.GameStatus.PlayerWon;
    }
}
