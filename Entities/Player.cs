using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Entities
{
    public class Player
    {
        public Player(int id, string name, Enums.SqureState state)
        {
            Name = name;
            State = state;
            Id = id;
        }

        public string Name { get; }

        public int Id { get; }

        public int Score { get; set; }

        public Enums.SqureState State { get; }
    }
}
