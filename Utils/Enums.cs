using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication5.Utils
{
    public class Enums
    {
        public enum CellState
        {
            Empty,
            X,
            O,
        }

        public enum GameStatus
        {
            Continue,
            NoneWon,
            PlayerWon,
        }
        
    }
}
