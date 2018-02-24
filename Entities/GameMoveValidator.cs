using WindowsFormsApplication5.Interfaces;
using WindowsFormsApplication5.UserControls;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Entities
{
   
    public class GameMoveValidator : IGameMoveValidator
    {
        
        public bool InvalidMove(IGameBoard board , CellCord cellCord)
        {
            return board.Get(cellCord.X, cellCord.Y) != Enums.Symbol.Empty;
        }
    }
}
