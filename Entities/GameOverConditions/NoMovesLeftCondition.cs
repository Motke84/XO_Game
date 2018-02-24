
using TicTacToe.Interfaces;
using TicTacToe.Utils;

namespace TicTacToe.Entities.GameOverConditions
{
    /// <summary>
    /// Represents a game over condition where there are no more moves left in the game. You need to be careful to check this condition after all win conditions.
    /// </summary>
    public class NoMovesLeftCondition : IGameEndCondition
    {
      
        public bool ConditionMet(Enums.Symbol playerSymbol, IGameBoard board)
        {
            for (var x = 0; x < board.Size; x++)
            {
                for (var y = 0; y < board.Size; y++)
                {
                    if (board.Get(x, y) == Enums.Symbol.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public Enums.GameStatus GameStatus => Enums.GameStatus.Tie;
    }
}