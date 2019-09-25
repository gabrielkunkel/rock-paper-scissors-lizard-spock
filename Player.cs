using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {

        public int playerScore;
        public string currentGesture;

        public virtual string CreateGesture()
        {
            return "a string";
        }

    }
}
