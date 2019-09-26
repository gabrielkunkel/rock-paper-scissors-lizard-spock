using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {
        List<string> gestureOptions = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock" });

        public Computer()
        {
            startMessage = "Your turn";
            turnMessage = "Computer's turn.";
            firstPlayerWinRoundMessage = "You won that round!";
            secondPlayerWinRoundMessage = "The computer won that round!";
            firstPlayerWinGameMessage = "You won the game!";
            secondPlayerWinGameMessage = "The computer won the game!";
    }

        public override void GetGesture()
        {
            Random rnd = new Random();
            int selector = rnd.Next(5);
            currentGesture = gestureOptions[selector];
        }

    }
}
