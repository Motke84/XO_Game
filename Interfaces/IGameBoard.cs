using TicTacToe.Utils;

namespace TicTacToe.Interfaces
{
    public interface IGameBoard : IReloaded
    {
        Enums.Symbol Get(int x, int y);

        void Set(Enums.Symbol t, int x, int y);

        Enums.Symbol[,] Cells { get; set; }

        int Size { get; }
    }
}