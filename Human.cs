using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        
        public Human() 
        {
            
        }

        public void Play(Human firstPlayer, Human secondPlayer)
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
