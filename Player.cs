using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
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

        public abstract void Play(Player firstPlayer, Player secondplayer);

        public abstract void GetGesture();

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
