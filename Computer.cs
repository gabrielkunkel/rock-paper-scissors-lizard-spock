﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        List<string> gestureOptions = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock", });

        public override void GetGesture()
        {
            Random rnd = new Random();
            int selector = rnd.Next(1, 6);
            currentGesture = gestureOptions[selector];
        }

        public void Play(Human firstPlayer, Computer secondPlayer)
        {
            bool isGameNotDoneYet = true;
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
                        // todo: insert thread wait + Console.Clear();
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
                if (firstPlayer.playerScore == 2)
                {
                    Console.WriteLine("The First Player won the game!");
                    isGameNotDoneYet = false;
                }

                if (secondPlayer.playerScore == 2)
                {
                    Console.WriteLine("The computer won the game!");
                    isGameNotDoneYet = false;
                }

            } while (isGameNotDoneYet);
        }

    }
}
