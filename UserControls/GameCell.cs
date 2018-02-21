using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication5.Properties;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.UserControls
{
    public partial class GameCell : UserControl
    {    
        public event EventHandler SqureClicked;

        private Enums.CellState _mSqureState;
       

        public GameCell()
        {
            InitializeComponent();
        }

        public int SqureId { get; set; }

        public Enums.CellState SqureStatus
        {
            get => _mSqureState;
            set
            {
                _mSqureState = value;
                switch (value)
                {
                    case Enums.CellState.X:
                        pictureBox1.Image = Resources.X;
                        break;
                    case Enums.CellState.O:
                        pictureBox1.Image = Resources.O;
                        break;
                    case Enums.CellState.Empty:
                        pictureBox1.Image = Resources.Empty;
                        break;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (SqureStatus == Enums.CellState.Empty)
                SqureClicked?.Invoke(this, new EventArgs());
            else
                MessageBox.Show(this, "Cannt click none empty squre");
        }


      

    }

    public class SqureClickArgs : EventArgs
    {
        public GameCell GameSqure { get; }

        public SqureClickArgs(GameCell gameSqure)
        {
            GameSqure = gameSqure;
        }
    }
}
