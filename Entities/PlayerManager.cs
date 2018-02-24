using WindowsFormsApplication5.Interfaces;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Entities
{
    
    public class PlayerManager : IPlayerManager
    {

        public PlayerManager(string playerOneName, string playerTwoName)
        {
            _turn = 0;
            PlayerOne = new Player(playerOneName, Enums.Symbol.X);
            PlayerTwo = new Player(playerTwoName, Enums.Symbol.O);
        }

        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        private int _turn;

        public Player Next()
        {
            return GetPlayer(++_turn);
        }

        public Player GetCurrentPlayer()
        {
            return GetPlayer(_turn);
        }

        public void Reload()
        {
            _turn = 0;
        }

        private Player GetPlayer(int turn)
        {
            return (turn & 1) == 0 ? PlayerOne : PlayerTwo;
        }
    }
}
