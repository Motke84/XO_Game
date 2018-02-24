using WindowsFormsApplication5.Entities;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Interfaces
{
    public interface IGameEndCondition
    {
        bool ConditionMet(Enums.Symbol playerSymbol, IGameBoard board);

        Enums.GameStatus GameStatus { get; }
       
    }
}