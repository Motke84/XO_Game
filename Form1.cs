using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication5.Entities;
using WindowsFormsApplication5.UserControls;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {

        private GameManager _gameManager;
        public delegate void ShowMessageDelegate(GameEventArgs args);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamePanel.Enabled = false;
            var squres = gamePanel.Controls.OfType<GameSqure>().OrderBy(sq => sq.SqureId).ToList();

            _gameManager = new GameManager(squres);
            _gameManager.GameEnds+= GameManagerOnGameEnds;
            
        }

        private void GameManagerOnGameEnds(object sender, EventArgs eventArgs)
        {
            GameEventArgs args = eventArgs as GameEventArgs;

            if (this.InvokeRequired)
            {
                this.Invoke(new ShowMessageDelegate(ShowMessgae), args);
            }
            else
            {
                ShowMessgae(args);
            }
        }

        private void ShowMessgae(GameEventArgs args)
        {
            MessageBox.Show(this, args.ToString());

            var msg = MessageBox.Show(this, "Do you wish to try again?");

            if (msg == DialogResult.No)
                Close();
            else
            {
                _gameManager.Reload();
            }
        }

      
        private void btn_startGame_Click(object sender, EventArgs e)
        {
            _gameManager.CreateNewPlayers( new List<string> { txt_player1.Text , txt_player2.Text});

            gamePanel.Enabled = true;
            playerPanel.Enabled = false;
        }
    }
}
