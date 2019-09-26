using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        Dictionary<string, string[]> beats = new Dictionary<string, string[]>();
        public int playerScore = 0;
        public string currentGesture;

        public Player()
        {
            beats.Add("rock", new string[] { "scissors", "lizard" });
            beats.Add("paper", new string[] { "rock", "Spock" });
            beats.Add("scissors", new string[] { "paper", "lizard" });
            beats.Add("lizard", new string[] { "Spock", "paper" });
            beats.Add("Spock", new string[] { "scissors", "rock" });

        }

        public virtual void GetGesture()
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


    }

    

}
