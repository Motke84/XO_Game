using WindowsFormsApplication5.Interfaces;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Entities
{
  
    public class GameBoard: IGameBoard
    {

        public GameBoard(int size)
        {
            Size = size;
            Cells = new Enums.Symbol[size,size];
        }

        public int Size { get; }

        public Enums.Symbol[,] Cells { get;  set; }
       

        public Enums.Symbol Get(int x, int y)
        {
            return Cells[x, y];
        }

        public void Set(Enums.Symbol t, int x, int y)
        {
            Cells[x, y] = t;
        }

        public void Reload()
        {
            var width = Cells.GetLength(0); // width
            var height = Cells.GetLength(1); // height

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    Cells[i, j] = Enums.Symbol.Empty;
                }
            }
        }
    }
}
