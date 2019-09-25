using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Dictionary<string, string[]> beats = new Dictionary<string, string[]>();
        string secondPlayerChoice;
        bool didFirstPlayerWinGame;
        bool isGameNotDoneYet = true;

        public Game(string secondPlayerChoice)
        {
            this.secondPlayerChoice = secondPlayerChoice;
            beats.Add("rock", new string[] { "scissors", "lizard" });
            beats.Add("paper", new string[] { "rock", "Spock" });
            beats.Add("scissors", new string[] { "paper", "lizard" });
            beats.Add("lizard", new string[] { "Spock", "paper" });
            beats.Add("Spock", new string[] { "scissors", "rock" });

        }

        public void Run()
        {
            Human firstPlayer = new Human();
            Human secondPlayer = new Human(); // todo: add computer option

            do
            {
                firstPlayer.GetGesture();
                Console.Clear();
                secondPlayer.GetGesture();

                // add to score
                bool result = DoesFirstPlayerWin(firstPlayer.currentGesture, secondPlayer.currentGesture);
                if (result == true)
                {
                    firstPlayer.playerScore += 1;
                    Console.WriteLine("First Player won that round!");
                }
                else
                {
                    secondPlayer.playerScore += 1;
                    Console.WriteLine("Second Player won that round!");
                }
               
                // check if there's a game winner
                if (firstPlayer.playerScore == 2)
                {
                    Console.WriteLine("The First Player won the game!");
                    isGameNotDoneYet = false;
                }

                if (secondPlayer.playerScore == 2)
                {
                    Console.WriteLine("The Second Player won the game!");
                    isGameNotDoneYet = false;
                }

            } while (isGameNotDoneYet);

            PlayAgain();
        }

        public bool DoesFirstPlayerWin(string firstGesture, string secondGesture)
        {
            bool isWinner = false;

            foreach (string item in beats[firstGesture])
            {
                if(item == secondGesture)
                {
                    isWinner = true;
                }
            }
            
            return isWinner;
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

    }
}
