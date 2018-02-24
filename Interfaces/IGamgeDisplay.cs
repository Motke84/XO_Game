using TicTacToe.Utils;

namespace TicTacToe.Interfaces
{
    public interface IGamgeDisplay
    {
        void GenerateBoard(Enums.Symbol[,] grid);
        void ShowMessage(string messgae);
        void SetCell(CellCord cellCord, Enums.Symbol cellState);
        void GameEnded(string messgae);
    }
}