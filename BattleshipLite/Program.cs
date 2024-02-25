using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIDisplay.WelcomeMessage();

            PlayerInfoModel activePlayer = UILogic.CreatePlayer("Player 1");
            PlayerInfoModel opponent = UILogic.CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                UILogic.DisplayShotGrid(activePlayer);

                UILogic.RecordPlayerShot(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {
                    // Swap positions
                    (activePlayer, opponent) = (opponent, activePlayer);
                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            UIDisplay.IdentifyWinner(winner);

            Console.ReadLine();
        }

    }
}
