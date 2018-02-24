using TicTacToe.Entities;

namespace TicTacToe.Interfaces
{
    public interface IPlayerManager : IReloaded
    {
        IPlayer Next();

        IPlayer GetCurrentPlayer();
    }
}