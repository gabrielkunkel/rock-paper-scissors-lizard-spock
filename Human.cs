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
            startMessage = "First player's turn.";
            turnMessage = "Second player's turn.";
            firstPlayerWinRoundMessage = "First Player won that round!";
            secondPlayerWinRoundMessage = "Second Player won that round!";
            firstPlayerWinGameMessage = "First Player won the game!";
            secondPlayerWinGameMessage = "Second Player won the game!";
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
    }
}
