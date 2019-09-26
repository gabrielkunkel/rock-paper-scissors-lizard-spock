using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        
        public Human() 
        {
            
        }

        public override void GetGesture()
        {
            bool keepLooping = true;
            do
            {
                Console.WriteLine("Do you choose rock, paper, scissors, lizard, or Spock?");
                string response = Console.ReadLine();

                switch (response)
                {
                    case "rock":
                    case "paper":
                    case "scissors":
                    case "lizard":
                    case "Spock":
                        currentGesture = response;
                        keepLooping = false;
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("I don't understand. (If you want to quit type 'exit'.)");
                        break;
                }
            } while (keepLooping);

        }


        public override void Play(Player firstPlayer, Player secondPlayer)
        {
            bool continueGame = true;
            bool cats = true;

            do
            {
                do
                {
                    Console.WriteLine("First player's turn.");
                    firstPlayer.GetGesture();
                    Console.Clear();
                    Console.WriteLine("Second player's turn.");
                    secondPlayer.GetGesture();
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
                    Console.WriteLine("First Player won that round!");
                }
                else
                {
                    secondPlayer.playerScore += 1;
                    Console.Clear();
                    Console.WriteLine("Second Player won that round!");
                }

                // check if there's a game winner
                if (firstPlayer.playerScore == 2)
                {
                    Console.WriteLine("The First Player won the game!");
                    continueGame = false;
                }

                if (secondPlayer.playerScore == 2)
                {
                    Console.WriteLine("The Second Player won the game!");
                    continueGame = false;
                }

            } while (continueGame);
        }

    }
}
