using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.Entities.GameOverConditions;
using WindowsFormsApplication5.Interfaces;
using WindowsFormsApplication5.UserControls;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Entities
{
    public class GameManager : IReloaded
    {
        private readonly IGamgeDisplay _gameDisplay;
        private readonly IPlayerManager _playerManager;
        private readonly IGameBoard _board;
        private readonly List<IGameEndCondition> _conditions;

        public Player CurrentPlayer { get; set; }

        public GameManager(IGamgeDisplay gameDisplay ,
            IPlayerManager playerManager, 
            IGameBoard board,
            List<IGameEndCondition> conditions)
        {
            _gameDisplay = gameDisplay;
            _board = board;
            _conditions = conditions;
            _playerManager = playerManager;

            _gameDisplay.GenerateBoard(_board.Cells);

            CurrentPlayer = _playerManager.GetCurrentPlayer();
            _gameDisplay.ShowMessage($"Player: {CurrentPlayer.Name} Turn");
        }

        public void CellWasClicked(CellCord cellCord)
        {
            if (_board.Get(cellCord.X, cellCord.Y) != Enums.Symbol.Empty)
                _gameDisplay.ShowMessage($"Player: {CurrentPlayer.Name} Not Valid Move");
            else
            {
                _board.Set(CurrentPlayer.Symbol,cellCord.X, cellCord.Y);
                _gameDisplay.SetCell(cellCord, CurrentPlayer.Symbol);

                var condition = _conditions.FirstOrDefault(e => e.ConditionMet(CurrentPlayer.Symbol, _board));

                if (condition == null)
                {
                    CurrentPlayer = _playerManager.Next();
                    _gameDisplay.ShowMessage($"Player: {CurrentPlayer.Name} Turn");
                }
                else
                {
                    switch (condition.GameStatus)
                    {
                        case Enums.GameStatus.PlayerWon:
                            _gameDisplay.ShowMessage($"Player {CurrentPlayer.Name} Won");
                            break;
                        case Enums.GameStatus.Tie:
                            _gameDisplay.ShowMessage("No Player Won");
                            break;
                    }

                    _gameDisplay.GameEnded();
                }

            }
        }

        public void Reload()
        {
            _playerManager.Reload();
            CurrentPlayer = _playerManager.GetCurrentPlayer();
            _board.Reload();
            _gameDisplay.ShowMessage($"Player: {CurrentPlayer.Name} Turn");
        }
    }
}
