using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        string secondPlayerChoice;
        Player firstPlayer;
        Player secondPlayer;
        
        public Game(string secondPlayerChoice)
        {
            this.secondPlayerChoice = secondPlayerChoice;
          }

        public void Run()
        {
            firstPlayer = new Human();

            do
            {
                if (secondPlayerChoice == "human")
                {
                    secondPlayer = new Human();
                    secondPlayer.Play(firstPlayer, secondPlayer);
                    firstPlayer.playerScore = 0;
                    secondPlayer.playerScore = 0;
                }
                else if (secondPlayerChoice == "computer")
                {
                    secondPlayer = new Computer();
                    secondPlayer.Play(firstPlayer, secondPlayer);
                }
                else
                {
                    Console.WriteLine("That doesn't make sense. Did you want to play a human or computer?");
                }

                PlayAgain();
                

            } while (secondPlayerChoice == "human" || secondPlayerChoice == "computer");


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



    }
}
