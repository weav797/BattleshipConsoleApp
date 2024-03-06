using BattleshipLiteLibrary.Models;
using BattleshipLiteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BattleshipLite
{
    public class UIDisplay
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by Paul Weaver");
            Console.WriteLine();
        }

        public static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulations to {winner.UsersName} for winning!");
            Console.WriteLine($"{winner.UsersName} took {GameLogic.GetShotCount(winner)} shots.");
        }

        public static string AskForShot(PlayerInfoModel player)
        {
            Console.WriteLine();
            Console.Write($"{player.UsersName}, please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }

        public static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static string AskForGridSize()
        {
            string output;
            bool validInput = false;
            
            Console.WriteLine();
            Console.WriteLine("We have added a new feature for you to decide if you want to\n" +
                "use the normal 5x5 grid or our new 7x7 grid.");
            Console.WriteLine();
            do
            {
                Console.Write("Please select what grid size you want: ");
                output = Console.ReadLine();
                validInput = UILogic.ValidateGridSize(output);

            } while (validInput == false);

            return output;
        }

    }
}
