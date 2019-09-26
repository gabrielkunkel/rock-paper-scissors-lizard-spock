﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        string secondPlayerChoice;
        Player firstPlayer;
        Player secondPlayer;
        Dictionary<string, string[]> beats = new Dictionary<string, string[]>();
        bool cats = true;
        bool continueGame = true;

        public Game(string secondPlayerChoice)
        {
            this.secondPlayerChoice = secondPlayerChoice;
            beats.Add("rock", new string[] { "scissors", "lizard" });
            beats.Add("paper", new string[] { "rock", "Spock" });
            beats.Add("scissors", new string[] { "paper", "lizard" });
            beats.Add("lizard", new string[] { "Spock", "paper" });
            beats.Add("Spock", new string[] { "scissors", "rock" });
            // "rock", {"scissors", "lizard"}, {"rock smashes scissors", "rock crushes lizard"}

        }

        public void Run()
        {
            firstPlayer = new Human();

            do
            {
                if (secondPlayerChoice == "human")
                {
                    secondPlayer = new Human();
                    Play(firstPlayer, secondPlayer);
                    ResetGame();
                }
                else if (secondPlayerChoice == "computer")
                {
                    secondPlayer = new Computer();
                    Play(firstPlayer, secondPlayer);
                    ResetGame();
                }
                else
                {
                    Console.WriteLine("That doesn't make sense. Did you want to play a human or computer?");
                }

                PlayAgain();
                

            } while (secondPlayerChoice == "human" || secondPlayerChoice == "computer");


        }

        public void Play(Player firstPlayer, Player secondPlayer)
        {

            do
            {
                do
                {
                    PlayRound();
                    TestForCats();

                } while (cats);

                Score();
                CheckWinner();

            } while (continueGame);
        }


        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play again? (yes/no)");
            string response = Console.ReadLine();
            if(response != "yes")
            {
                Environment.Exit(0);
            }
        }

        public void ResetGame()
        {
            firstPlayer.playerScore = 0;
            secondPlayer.playerScore = 0;
        }

        public bool DoesFirstPlayerWin(string firstGesture, string secondGesture)
        {
            bool isWinner = false;

            foreach (string item in beats[firstGesture])
            {
                if (item == secondGesture)
                {
                    isWinner = true;
                }
            }

            return isWinner;
        }

        public void TestForCats() {
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
                Thread.Sleep(500);
                Console.WriteLine("2");
                Thread.Sleep(400);
                Console.WriteLine("1");
                Thread.Sleep(300);
                Console.Clear();
                cats = true;
            }
        }

        public void Score()
        {
            bool result = DoesFirstPlayerWin(firstPlayer.currentGesture, secondPlayer.currentGesture);
            if (result == true)
            {
                firstPlayer.playerScore += 1;
                Console.Clear();
                Console.WriteLine(firstPlayer.currentGesture + " vs. " + secondPlayer.currentGesture + ".");
                Console.WriteLine(secondPlayer.firstPlayerWinRoundMessage);
            }
            else
            {
                secondPlayer.playerScore += 1;
                Console.Clear();
                Console.WriteLine(firstPlayer.currentGesture + " vs. " + secondPlayer.currentGesture + ".");
                Console.WriteLine(secondPlayer.secondPlayerWinRoundMessage);
            }
        }

        public void CheckWinner()
        {
            if (firstPlayer.playerScore >= 2)
            {
                Console.WriteLine(secondPlayer.firstPlayerWinGameMessage);
                continueGame = false;
            }

            if (secondPlayer.playerScore >= 2)
            {
                Console.WriteLine(secondPlayer.secondPlayerWinGameMessage);
                continueGame = false;
            }
        }

        public void PlayRound()
        {
            Console.WriteLine(secondPlayer.startMessage);
            firstPlayer.GetGesture();
            Console.Clear();
            Console.WriteLine(secondPlayer.turnMessage);
            secondPlayer.GetGesture();
        }

    }
}
