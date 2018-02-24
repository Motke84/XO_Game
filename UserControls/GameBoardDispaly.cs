using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToe.Interfaces;
using TicTacToe.Utils;

namespace TicTacToe.UserControls
{
    public partial class GameBoardDispaly : UserControl , IReloaded
    {
        public event EventHandler CellClicked;

        public GameBoardDispaly()
        {
            InitializeComponent();
        }

        private GameCellDisplay[,] _grid;

        public void GenerateCells(Enums.Symbol[,] grid)
        {
            int width = grid.GetLength(0); // width
            int height = grid.GetLength(1); // height
            _grid = new GameCellDisplay[width, height];


            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    var cell = new GameCellDisplay
                    {
                        CellCord = new CellCord() {X = i, Y = j},              
                        CellState = Enums.Symbol.Empty,
                    };

                    cell.Location = new Point(i * cell.Size.Height,
                        j * cell.Size.Height);

                    cell.CellClicked += CellOnCellClicked;

                    Controls.Add(cell);
                    _grid[i, j] = cell;
                }
            }

        }



        private void CellOnCellClicked(object sender, EventArgs eventArgs)
        {
            if (sender is GameCellDisplay cellDisplay)
                CellClicked?.Invoke(this, new CellClickArgs(cellDisplay.CellCord));
        }

        public void SetCell(CellCord cellCord, Enums.Symbol cellState)
        {
            _grid[cellCord.X, cellCord.Y].CellState = cellState;
        }

        public void Reload()
        {
            var width = _grid.GetLength(0); // width
            var height = _grid.GetLength(1); // height

            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    _grid[i, j].Reload();
                }
            }
        }
    }
}
