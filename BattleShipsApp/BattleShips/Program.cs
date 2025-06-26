using BattleShipLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods.Welcome();

            PlayerModel activePlayer = Methods.CreatePlayer("Player 1");
            PlayerModel opponent = Methods.CreatePlayer("Player 2");
            PlayerModel winner = null;

            do
            {
                Methods.DisplayShotGrid(activePlayer);

                Methods.RecordPlayerShot(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {
                    // Swap players using a temp variable
                    //PlayerModel tempHolder = opponent;
                    //opponent = activePlayer;
                    //activePlayer = tempHolder;

                    // Swap players using a Tuple. Does the same as above
                    (activePlayer, opponent) = (opponent, activePlayer); 
                }
                else
                {
                    winner = activePlayer;
                }
            }
            while (winner == null);

            Methods.IdentifyWinner(winner);

            Console.ReadLine();
        }
    }
}
