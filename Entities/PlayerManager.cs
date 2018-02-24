using WindowsFormsApplication5.Interfaces;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Entities
{
    
    public class PlayerManager : IPlayerManager
    {

        public PlayerManager(IPlayer playerOne, IPlayer playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            _turn = 0;
        }

        public IPlayer PlayerOne { get; set; }
        public IPlayer PlayerTwo { get; set; }

        private int _turn;

        public IPlayer Next()
        {
            return GetPlayer(++_turn);
        }

        public IPlayer GetCurrentPlayer()
        {
            return GetPlayer(_turn);
        }

        public void Reload()
        {
            _turn = 0;
        }

        private IPlayer GetPlayer(int turn)
        {
            return (turn & 1) == 0 ? PlayerOne : PlayerTwo;
        }
    }
}
