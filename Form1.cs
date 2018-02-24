using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToe.Entities;
using TicTacToe.Entities.GameOverConditions;
using TicTacToe.Interfaces;
using TicTacToe.UserControls;
using TicTacToe.Utils;
using SolidTacToe.GameOverConditions;

namespace TicTacToe
{
    public partial class Form1 : Form, IGamgeDisplay
    {
        private const int Size = 3;
        private GameManager _gameManager;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            var player1 = txt_player1.Text;
            var player2 = txt_player2.Text;

            IPlayer playerOne = new Player(player1, Enums.Symbol.X);
            IPlayer playerTwo = new Player(player2, Enums.Symbol.O);

            IPlayerManager playerManager = new PlayerManager(playerOne, playerTwo);

            IGameBoard board = new GameBoard(Size);

            var conditions = new List<IGameEndCondition>()
            {
                new DiagonalWinCondition(),
                new HorizontalWinCondition(),
                new NoMovesLeftCondition(),
                new VerticalWinCondition()
            };

            IGameMoveValidator gameMoveValidator = new GameMoveValidator();

            _gameManager = new GameManager(this, playerManager, board, gameMoveValidator, conditions);

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

        public void GameEnded(string messgae)
        {
            gameBoardDispaly1.Enabled = false;
            var msg = MessageBox.Show(this, "Do you wish to play again?", messgae, MessageBoxButtons.YesNo);

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
}
