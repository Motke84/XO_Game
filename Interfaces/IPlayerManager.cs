using WindowsFormsApplication5.Entities;

namespace WindowsFormsApplication5.Interfaces
{
    public interface IPlayerManager : IReloaded
    {
        IPlayer Next();

        IPlayer GetCurrentPlayer();
    }
}