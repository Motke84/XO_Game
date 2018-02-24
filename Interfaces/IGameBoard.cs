using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Interfaces
{
    public interface IGameBoard : IReloaded
    {
        Enums.Symbol Get(int x, int y);

        void Set(Enums.Symbol t, int x, int y);

        Enums.Symbol[,] Cells { get; set; }

        int Size { get; }
    }
}