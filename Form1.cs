using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication5.Entities;
using WindowsFormsApplication5.Entities.GameOverConditions;
using WindowsFormsApplication5.Interfaces;
using WindowsFormsApplication5.UserControls;
using WindowsFormsApplication5.Utils;
using SolidTacToe.GameOverConditions;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form, IGamgeDisplay
    {

        private GameManager _gameManager;
        public delegate void ShowMessageDelegate(string message);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamePanel.Enabled = false;

            gameBoardDispaly1.CellClicked += GameBoardOnCellClicked;

        }

        private void GameBoardOnCellClicked(object sender, EventArgs eventArgs)
        {
            if (eventArgs is CellClickArgs cellClickArgs)
                _gameManager.CellWasClicked(cellClickArgs.CellCord);
        }

        private void GameManagerOnGameEnds(object sender, EventArgs eventArgs)
        {
            GameEventArgs args = eventArgs as GameEventArgs;

            if (InvokeRequired)
            {
                //Invoke(new ShowMessageDelegate(ShowMessgae), args);
            }
            else
            {
                ShowMessgae(args);
            }
        }

        private void ShowMessgae(GameEventArgs args)
        {
            MessageBox.Show(this, args.ToString());

            var msg = MessageBox.Show(this, "Do you wish to try again?", "New Game", MessageBoxButtons.YesNo);

            if (msg == DialogResult.No)
                Close();
            else
            {
              //  _gameManager.Reload();
            }
        }


        private void btn_startGame_Click(object sender, EventArgs e)
        {

            string player1 = txt_player1.Text;
            string player2 = txt_player2.Text;

            IPlayerManager playerManager = new PlayerManager(player1, player2);

            IGameBoard board = new GameBoard(3);

            var conditions = new List<IGameEndCondition>()
            {
                new DiagonalWinCondition(),
                new HorizontalWinCondition(),
                new NoMovesLeftCondition(),
                new VerticalWinCondition()
            };

            _gameManager = new GameManager(this, playerManager, board, conditions);

            gamePanel.Enabled = true;
            playerPanel.Enabled = false;
        }

        public void GenerateBoard(Enums.Symbol[,] grid)
        {
            gameBoardDispaly1.GenerateCells(grid);
        }

        public void ShowMessage(string messgae)
        {
            gameLabel.Text = messgae;
        }

        public void SetCell(CellCord cellCord, Enums.Symbol cellState)
        {
            gameBoardDispaly1.SetCell(cellCord, cellState);
        }

        public void GameEnded()
        {
            gameBoardDispaly1.Enabled = false;
            var msg = MessageBox.Show(this, "Do you wish to play again?", "New Game", MessageBoxButtons.YesNo);

            if (msg == DialogResult.No)
                Close();
            else
            {
                gameBoardDispaly1.Reload();
                gameBoardDispaly1.Enabled = true;
                _gameManager.Reload();
            }
        }
    }

    public interface IGamgeDisplay
    {
        void GenerateBoard(Enums.Symbol[,] grid);
        void ShowMessage(string messgae);
        void SetCell(CellCord cellCord, Enums.Symbol cellState);
        void GameEnded();
    }
}
