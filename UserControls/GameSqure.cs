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
    public partial class GameSqure : UserControl
    {    
        public event EventHandler SqureClicked;

        private Enums.SqureState _mSqureState;
       

        public GameSqure()
        {
            InitializeComponent();
        }

        public int SqureId { get; set; }

        public Enums.SqureState SqureStatus
        {
            get => _mSqureState;
            set
            {
                _mSqureState = value;
                switch (value)
                {
                    case Enums.SqureState.X:
                        pictureBox1.Image = Resources.X;
                        break;
                    case Enums.SqureState.O:
                        pictureBox1.Image = Resources.O;
                        break;
                    case Enums.SqureState.Empty:
                        pictureBox1.Image = Resources.Empty;
                        break;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (SqureStatus == Enums.SqureState.Empty)
                SqureClicked?.Invoke(this, new EventArgs());
            else
                MessageBox.Show(this, "Cannt click none empty squre");
        }


      

    }

    public class SqureClickArgs : EventArgs
    {
        public GameSqure GameSqure { get; }

        public SqureClickArgs(GameSqure gameSqure)
        {
            GameSqure = gameSqure;
        }
    }
}
