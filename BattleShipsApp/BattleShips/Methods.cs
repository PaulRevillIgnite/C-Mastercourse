using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BattleShipLibrary;
using BattleShipLibrary.Models;

namespace BattleShips
{
    public class Methods
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to BattleShip!");
                        
            Console.WriteLine();
        }
        
        public static PlayerModel CreatePlayer(string PlayerTitle)
        {
            PlayerModel output = new PlayerModel();

            Console.WriteLine($"Player information for {PlayerTitle}");

            // Ask for name
            output.PlayersName = GetPlayerName();

            // Load grid
            GameLogic.InitialiseGrid(output);

            // Ask the user for their 5 ship placements
            PlaceShips(output);

            // Clear display
            Console.Clear();

            return output;
        }

        private static string GetPlayerName()
        {
            Console.Write("Type your name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static void PlaceShips(PlayerModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship {model.ShipLocations.Count + 1}? ");
                string location = Console.ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("Invalid location. Try again.");
                }
            }
            while (model.ShipLocations.Count < 5);
        }

        public static void DisplayShotGrid(PlayerModel activePlayer)
        {
            // Clear display
            Console.Clear();

            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($"{gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write("X  ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write("O  ");
                }
                else
                {
                    Console.Write("?  ");
                }
            }
        }

        public static void RecordPlayerShot(PlayerModel activePlayer, PlayerModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception)
                {
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please try again.");
                }
            }
            while (isValidShot == false);

            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

            DisplayShotResults(row, column, isAHit);
        }

        private static void DisplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                Console.WriteLine($"{row}{column} is a hit!");
            }
            else
            {
                Console.WriteLine($"{row}{column} is a miss.");
            }

            Console.ReadLine();
        }

        private static string AskForShot(PlayerModel player)
        {
            Console.Write($"\n\n{player.PlayersName}: Please enter your shot selection: ");
            string output = Console.ReadLine();
            Console.WriteLine();

            return output;
        }

        public static void IdentifyWinner(PlayerModel winner)
        {
            Console.WriteLine($"Congratulations to {winner.PlayersName} for winning!");
            Console.WriteLine($"{winner.PlayersName} took {GameLogic.GetShotCount(winner)} shots.");
        }
    }
}
