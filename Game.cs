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

            // create human or computer player

            do
            {
                // creat



            } while (isGameNotDoneYet);

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

    }
}
