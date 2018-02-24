using WindowsFormsApplication5.Entities;

namespace WindowsFormsApplication5.Interfaces
{
    public interface IPlayerManager : IReloaded
    {
        Player Next();

        Player GetCurrentPlayer();

        void Reload();
    }
}