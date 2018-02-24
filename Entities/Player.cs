using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe.Utils;

namespace TicTacToe.Entities
{
    public class Player : IPlayer
    {
        public Player(string name, Enums.Symbol symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public string Name { get; }

        public int Score { get; set; }

        public Enums.Symbol Symbol { get; }
    }

    public interface IPlayer
    {
        string Name { get; }

        int Score { get; set; }

        Enums.Symbol Symbol { get; }
    }
}
