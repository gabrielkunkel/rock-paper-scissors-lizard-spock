using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            do
            {
                Console.WriteLine("Do you want to play against a human or the computer? (human/computer/quit)");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "human":
                        Game.Run("human");
                        break;
                    case "computer":
                        Game.Run("computer");
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("I don't understand.");
                        break;
                }
            } while (true);

        }


    }
}
