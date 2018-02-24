using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToe.Interfaces;
using TicTacToe.Properties;
using TicTacToe.Utils;

namespace TicTacToe.UserControls
{
    public partial class GameCellDisplay : UserControl, IReloaded
    {    
        public event EventHandler CellClicked;

        private Enums.Symbol _cellState;
       

        public GameCellDisplay()
        {
            InitializeComponent();
            
        }

        public CellCord CellCord { get; set; }

        [Description("Set control state"), Category("Data")]
        public Enums.Symbol CellState
        {
            get => _cellState;
            set
            {
                _cellState = value;
                switch (value)
                {
                    case Enums.Symbol.X:
                        pictureBox1.Image = Resources.X;
                        break;
                    case Enums.Symbol.O:
                        pictureBox1.Image = Resources.O;
                        break;
                    case Enums.Symbol.Empty:
                        pictureBox1.Image = Resources.Empty;
                        break;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { 
                CellClicked?.Invoke(this, new CellClickArgs(CellCord));
        }


        public void Reload()
        {
            CellState = Enums.Symbol.Empty;
        }
    }

    public class CellClickArgs : EventArgs
    {
        public CellCord CellCord { get; }

        public CellClickArgs(CellCord cellCord)
        {
            CellCord = cellCord;
        }
    }
}
