using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication5.UserControls;
using WindowsFormsApplication5.Utils;

namespace TicTacToe
{
    static class ExtensionMethods
    {
        #region Cell Extension Methods

        public static int DiagonalRelatives(this GameCell cell, GameCell[,] grid)
        {
            int relatives = 0;

            for (var x = 0; x < 3; x++)
            {
                if (grid[x, x].CellStatus.Equals(cell.CellStatus)) { relatives++; }
            }

            return relatives - 1;
        }

        public static int DiagonalRelatives2(this GameCell cell, GameCell[,] grid)
        {
            int relatives = 0;

            for (var x = 0; x < 3; x++)
            {
                if (grid[x, 2 - x].CellStatus.Equals(cell.CellStatus)) { relatives++; }
            }

            return relatives - 1;
        }

        public static int HorizontalRelatives(this GameCell cell, GameCell[,] grid)
        {
            int relatives = 0;
            int rowNum = grid.IndexOf(cell).Item2;

            for (var x = 0; x < 3; x++)
            {
                //Find row of cell
                if (grid[x, rowNum].CellStatus.Equals(cell.CellStatus)) { relatives++; }
            }

            return relatives - 1;
        }
        public static int VerticalRelatives(this GameCell cell, GameCell[,] grid)
        {
            int relatives = 0;
            int colNum = grid.IndexOf(cell).Item1;

            for (var y = 0; y < 3; y++)
            {
                //Find row of cell
                if (grid[colNum, y].CellStatus.Equals(cell.CellStatus)) { relatives++; }
            }

            return relatives - 1;
        }

        #endregion

        #region Cell[] Extension Methods

        public static GameCell[] GetEmptyCells(this GameCell[,] cells)
        {
            var emptyCells = new List<GameCell>();

            foreach (var cell in cells)
            {
                if (cell.CellStatus == Enums.Mark.Empty)
                {
                    emptyCells.Add(cell);
                }
            }

            return emptyCells.ToArray();
        }

        public static Tuple<int, int> IndexOf(this GameCell[,] cells, GameCell cell)
        {
            for (var x = 0; x < cells.GetLength(0); x++)
            {
                for (var y = 0; y < cells.GetLength(1); y++)
                {
                    if (cells[x, y].Equals(cell))
                    {
                        return new Tuple<int, int>(x, y);
                    }
                }
            }

            //If code reaches this point, then it didn't find anything, return -1
            return new Tuple<int, int>(-1, -1);
        }

        #endregion
    }
}
