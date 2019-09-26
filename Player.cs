using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        public int playerScore = 0;
        public string currentGesture;
        public string startMessage;
        public string turnMessage;
        public string firstPlayerWinRoundMessage;
        public string secondPlayerWinRoundMessage;
        public string firstPlayerWinGameMessage;
        public string secondPlayerWinGameMessage;

        public Player()
        {
       
        }

        public abstract void GetGesture();


    }

    

}
