using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Welcome to Snake Ladder Sumulation Program");
            //initialize Point 0
            SLSinglePlayer SinglerPlayer = new SLSinglePlayer();
            SinglerPlayer.StartPlaying();
            Console.ReadKey();
        }
    }
}
