using BattleshipLiteLibrary.Models;
using BattleshipLiteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static string AskForShot()
        {
            Console.Write("Please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }

        public static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}
