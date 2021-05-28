using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulation
{
    class SLSinglePlayer
    {
        public int StartPoint = 0; //initialize by 0
        public void StartPlaying()
        {
            Console.WriteLine("Game Started! Good Luck "); //Start Game
           
            Console.WriteLine("You are at " + StartPoint); //Main Start Point
        }
    }
}
