using TicTacToe.Interfaces;
using TicTacToe.Utils;

namespace TicTacToe.Entities.GameOverConditions
{
 
    public class DiagonalWinCondition : IGameEndCondition
    {

        public bool ConditionMet(Enums.Symbol playerSymbol, IGameBoard board)
        {
            var met = true;
            for (var i = 0; i < board.Size; i++)
            {
                if (board.Get(i, i) != playerSymbol)
                {
                    met = false;
                    break;
                }
            }

            if (met)
            {
                return true;
            }

            met = true;
            var j = 0;
            for (var i = board.Size - 1; i >= 0; i--)
            {
                if (board.Get(j, i) != playerSymbol)
                {
                    met = false;
                    break;
                }
                j++;
            }

            return met;
        }

        public Enums.GameStatus GameStatus => Enums.GameStatus.PlayerWon;
    }
}
