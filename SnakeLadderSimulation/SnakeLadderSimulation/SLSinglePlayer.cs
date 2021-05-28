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
        public int RanDice;
        public void StartPlaying()
        {
            Console.WriteLine("Game Started! Good Luck "); //Start Game
            Random Random = new Random(); //Creating Random Object
            RanDice = Random.Next(1 , 6); // Rndom value in B/w 1 to 6
            Console.WriteLine("player Role Dice number is:" + " " + RanDice); // Printing Random Value on b/w 1 to 6
        }
    }
}
