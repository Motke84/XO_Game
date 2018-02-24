using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Entities.GameOverConditions;
using TicTacToe.Interfaces;
using TicTacToe.UserControls;
using TicTacToe.Utils;

namespace TicTacToe.Entities
{
    public class GameManager : IGameManager, IReloaded
    {
        private readonly IGamgeDisplay _gameDisplay;
        private readonly IPlayerManager _playerManager;
        private readonly IGameBoard _board;
        private readonly IGameMoveValidator _gameMoveValidator;
        private readonly List<IGameEndCondition> _conditions;

        public IPlayer CurrentPlayer { get; set; }

        public GameManager(IGamgeDisplay gameDisplay,
            IPlayerManager playerManager,
            IGameBoard board,
            IGameMoveValidator gameMoveValidator,
            List<IGameEndCondition> conditions)
        {
            _gameDisplay = gameDisplay;
            _board = board;
            _gameMoveValidator = gameMoveValidator;
            _conditions = conditions;
            _playerManager = playerManager;

            _gameDisplay.GenerateBoard(_board.Cells);

            CurrentPlayer = _playerManager.GetCurrentPlayer();
            _gameDisplay.ShowMessage($"Player: {CurrentPlayer.Name} Turn");
        }

        public void CellWasClicked(CellCord cellCord)
        {
            if (_gameMoveValidator.InvalidMove(_board, cellCord))
                _gameDisplay.ShowMessage($"Player: {CurrentPlayer.Name} Not Valid Move");
            else
            {
                UpdateBoard(cellCord);

                var condition = _conditions.FirstOrDefault(e => e.ConditionMet(CurrentPlayer.Symbol, _board));

                if (condition == null)
                {
                    GameContinues();
                }
                else
                {
                    GameEnded(condition);
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

        private void GameEnded(IGameEndCondition condition)
        {
            string msg = string.Empty;

            switch (condition.GameStatus)
            {
                case Enums.GameStatus.PlayerWon:
                    msg = $"Player {CurrentPlayer.Name} Won";
                    break;
                case Enums.GameStatus.Tie:
                    msg = "It's a Tie";
                    break;
            }

            _gameDisplay.ShowMessage(msg);
            _gameDisplay.GameEnded(msg);
        }

        private void GameContinues()
        {
            CurrentPlayer = _playerManager.Next();
            _gameDisplay.ShowMessage($"Player: {CurrentPlayer.Name} Turn");
        }

        private void UpdateBoard(CellCord cellCord)
        {
            _board.Set(CurrentPlayer.Symbol, cellCord.X, cellCord.Y);
            _gameDisplay.SetCell(cellCord, CurrentPlayer.Symbol);
        }

    }
}
