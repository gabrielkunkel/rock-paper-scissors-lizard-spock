using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        List<string> gestureOptions = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock" });

        public override void GetGesture()
        {
            Random rnd = new Random();
            int selector = rnd.Next(5);
            currentGesture = gestureOptions[selector];
        }

        public override void Play(Player firstPlayer, Player secondPlayer)
        {
            bool continueGame = true;
            bool cats = true;

            do
            {
                do
                {
                    Console.WriteLine("Your turn.");
                    firstPlayer.GetGesture();
                    Console.Clear();
                    secondPlayer.GetGesture();

                    // check for cats game
                    if (firstPlayer.currentGesture != secondPlayer.currentGesture)
                    {
                        cats = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("That was a cats game. You both chose " + firstPlayer.currentGesture);
                        Console.WriteLine("Redo!");
                        Console.WriteLine("3");
                        Thread.Sleep(1000);
                        Console.WriteLine("2");
                        Thread.Sleep(1000);
                        Console.WriteLine("1");
                        Thread.Sleep(1000);
                        Console.Clear();
                        cats = true;
                    }
                } while (cats);

                // add to score
                bool result = DoesFirstPlayerWin(firstPlayer.currentGesture, secondPlayer.currentGesture);
                if (result == true)
                {
                    firstPlayer.playerScore += 1;
                    Console.Clear();
                    Console.WriteLine("The computer chose " + secondPlayer.currentGesture + ".");
                    Console.WriteLine("You won that round!");
                }
                else
                {
                    secondPlayer.playerScore += 1;
                    Console.Clear();
                    Console.WriteLine("The computer chose " + secondPlayer.currentGesture + ".");
                    Console.WriteLine("The computer won that round!");
                }

                // check if there's a game winner
                if (firstPlayer.playerScore >= 2)
                {
                    Console.WriteLine("The First Player won the game!");
                    continueGame = false;
                }

                if (secondPlayer.playerScore >= 2)
                {
                    Console.WriteLine("The computer won the game!");
                    continueGame = false;
                }

            } while (continueGame);
        }

    }
}
