using TicTacToe.UserControls;
using TicTacToe.Utils;

namespace TicTacToe.Interfaces
{
    public interface IGameMoveValidator
    {
        bool InvalidMove(IGameBoard board, CellCord cellCord);
    }
}