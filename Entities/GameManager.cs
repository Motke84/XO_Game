using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.UserControls;
using WindowsFormsApplication5.Utils;

namespace WindowsFormsApplication5.Entities
{
    public class GameManager
    {
        private readonly List<GameSqure> _list;
        private readonly List<Player> _players;
        public event EventHandler GameEnds;


        public Player CurrentPlayer { get; set; }

        public GameManager(List<GameSqure> list)
        {
            _players = new List<Player>();
            _list = list;
            _list.ForEach(sq =>
            {
                sq.SqureClicked += SqureWasOnClicked;

            });
        }

        private void SqureWasOnClicked(object sender, EventArgs eventArgs)
        {
            if (!(sender is GameSqure gameSqure))
                return;

            gameSqure.SqureStatus = CurrentPlayer.State;


            Task.Factory.StartNew(() =>
            {
                Player player = null;
                var gameState = CheckWinningPlayer(ref player);
                switch (gameState)
                {
                    case Enums.GameStatus.NoneWon:
                        GameEnds(this, new GameEventArgs("A Tie", gameState));
                        break;
                    case Enums.GameStatus.PlayerWon:
                        GameEnds(this, new GameEventArgs(player.Name, gameState));
                        break;
                }
            });
        }

        private void ContinueWithGame()
        {
            if (CurrentPlayer == _players.Last())
                CurrentPlayer = _players.First();
            else
            {
                int index = CurrentPlayer.Id;
                CurrentPlayer = _players[index];
            }
        }

        public Enums.GameStatus CheckWinningPlayer(ref Player winningPlayer)
        {
            #region Horzontal Winning Condtion

            //Winning Condition For First Row   

            if (FindIfSquresAreEqual(_list[0], _list[1], _list[2]))
            {
                winningPlayer = FindWinningPlayer(_list[0].SqureStatus);
                return Enums.GameStatus.PlayerWon;

            }
            //Winning Condition For Second Row   
            if (FindIfSquresAreEqual(_list[3], _list[4], _list[5]))
            {
                winningPlayer = FindWinningPlayer(_list[3].SqureStatus);
                return Enums.GameStatus.PlayerWon;
            }
            //Winning Condition For Third Row   
            if (FindIfSquresAreEqual(_list[6], _list[7], _list[8]))
            {
                winningPlayer = FindWinningPlayer(_list[6].SqureStatus);
                return Enums.GameStatus.PlayerWon;
            }
            #endregion

            #region vertical Winning Condtion
            //Winning Condition For First Column       
            if (FindIfSquresAreEqual(_list[0], _list[3], _list[6]))
            {
                winningPlayer = FindWinningPlayer(_list[0].SqureStatus);
                return Enums.GameStatus.PlayerWon;
            }
            //Winning Condition For Second Column  
            if (FindIfSquresAreEqual(_list[1], _list[4], _list[7]))
            {
                winningPlayer = FindWinningPlayer(_list[1].SqureStatus);
                return Enums.GameStatus.PlayerWon;
            }
            //Winning Condition For Third Column  
            if (FindIfSquresAreEqual(_list[2], _list[5], _list[8]))
            {
                winningPlayer = FindWinningPlayer(_list[2].SqureStatus);
                return Enums.GameStatus.PlayerWon;
            }
            #endregion

            #region Diagonal Winning Condition

            if (FindIfSquresAreEqual(_list[0], _list[4], _list[8]))
            {
                winningPlayer = FindWinningPlayer(_list[0].SqureStatus);
                return Enums.GameStatus.PlayerWon;
            }

            if (FindIfSquresAreEqual(_list[2], _list[4], _list[6]))
            {
                winningPlayer = FindWinningPlayer(_list[2].SqureStatus);
                return Enums.GameStatus.PlayerWon;
            }
            #endregion

            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match  
            if (_list.All(sq => sq.SqureStatus != Enums.SqureState.Empty))
            {
                return Enums.GameStatus.NoneWon;
            }
            #endregion


            ContinueWithGame();
            return Enums.GameStatus.Continue;

        }

        private bool FindIfSquresAreEqual(GameSqure gameSqure1, GameSqure gameSqure2, GameSqure gameSqure3)
        {
            return  (gameSqure1.SqureStatus != Enums.SqureState.Empty &&
                gameSqure2.SqureStatus != Enums.SqureState.Empty &&
                gameSqure3.SqureStatus != Enums.SqureState.Empty &&
                gameSqure1.SqureStatus == gameSqure2.SqureStatus &&
                gameSqure2.SqureStatus == gameSqure3.SqureStatus) ;
        }

        Player FindWinningPlayer(Enums.SqureState state)
        {
            return _players.First(pl => pl.State == state);
        }


        public void CreateNewPlayers(List<string> playerNames)
        {
            _players.Add(new Player(1, playerNames[0], Enums.SqureState.X));
            _players.Add(new Player(2, playerNames[1], Enums.SqureState.O));
            CurrentPlayer = _players[0];
        }

        internal void Reload()
        {
            CurrentPlayer = _players.First();
            _list.ForEach(sq => sq.SqureStatus = Enums.SqureState.Empty);
        }
    }

    public class GameEventArgs : EventArgs
    {
        private Enums.GameStatus _gameState;
        private string _name;
   
        public GameEventArgs(string name, Enums.GameStatus gameState)
        {
            _name = name;
            _gameState = gameState;
        }

        public string Name => _name;

        public Enums.GameStatus GameState => _gameState;

        public override string ToString()
        {
            return _gameState == Enums.GameStatus.NoneWon ? 
                "A Tie" : 
                $"player: {_name} won";
        }
    }
}
