using TicTacToe.Interfaces;
using TicTacToe.UserControls;
using TicTacToe.Utils;

namespace TicTacToe.Entities
{
   
    public class GameMoveValidator : IGameMoveValidator
    {
        
        public bool InvalidMove(IGameBoard board , CellCord cellCord)
        {
            return board.Get(cellCord.X, cellCord.Y) != Enums.Symbol.Empty;
        }
    }
}
