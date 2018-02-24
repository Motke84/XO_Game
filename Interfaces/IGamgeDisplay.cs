using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Interfaces
{
    public interface IGamgeDisplay
    {
        void GenerateBoard(Enums.Symbol[,] grid);
        void ShowMessage(string messgae);
        void SetCell(CellCord cellCord, Enums.Symbol cellState);
        void GameEnded(string messgae);
    }
}