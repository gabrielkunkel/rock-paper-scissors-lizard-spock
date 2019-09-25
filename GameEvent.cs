using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class GameEvent
    {
        string eventText;

        public GameEvent(string eventText)
        {
            this.eventText = eventText;
        }

        // RunEvent

        // Prompt

        // GetResponse

        public void Print()
        {
            Console.WriteLine(eventText);
        }

        public void PrintEach(string text)
        {
            Console.Write(text + " ");
        }
    }
}
