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

        public void GetGesture()
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
                        Console.WriteLine("I don't understand. (If you want to quit type 'exit'.");
                        break;
                }
            } while (keepLooping);

        }


    }
}
