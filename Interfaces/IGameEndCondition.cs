using TicTacToe.Entities;
using TicTacToe.Utils;

namespace TicTacToe.Interfaces
{
    public interface IGameEndCondition
    {
        bool ConditionMet(Enums.Symbol playerSymbol, IGameBoard board);

        Enums.GameStatus GameStatus { get; }
       
    }
}