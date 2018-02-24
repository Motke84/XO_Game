using WindowsFormsApplication5.UserControls;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Interfaces
{
    public interface IGameMoveValidator
    {
        bool InvalidMove(IGameBoard board, CellCord cellCord);
    }
}