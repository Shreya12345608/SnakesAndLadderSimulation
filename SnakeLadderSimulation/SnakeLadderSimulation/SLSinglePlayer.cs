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
        public int RanDice = 0;
        public int ComputerChoice;
        int Option = 0;
        public void StartPlaying()
        {
            Console.WriteLine("Game Started! Good Luck "); //Start Game
            while (StartPoint != 100)  // Start Poinnt ! =100
            {
              
                Random Random = new Random(); //Creating Random Object
                RanDice = Random.Next(1, 6); // Rndom value in B/w 1 to 6
                Console.WriteLine("player Role Dice number is:" + " " + RanDice); // Printing Random Value on b/w 1 to 6
                ComputerChoice = Random.Next(0, 2);  //Choice to check its snake or ladder
                Console.WriteLine("Dice value:" + ComputerChoice); // taking input Choice
                switch (ComputerChoice) //Switch Case 
                {
                    //For No Play
                    case 0:                            // if ComputerChoice = 0
                        Console.WriteLine("No Play");
                        break;
                    case 1:                             // if ComputerChoice = 1
                        StartPoint += RanDice;           //  StartPoint = StartPoint+RandDice
                        if (StartPoint > 100)           // checking StartPoint> 100
                        {
                          
                            StartPoint -=StartPoint;     //  StartPoint = StartPoint-StartPoint
                        }
                        Console.WriteLine("Exact Position :" + StartPoint);
                       // Console.WriteLine("Got Ladder:" + StartPoint);
                        break;
                    case 2:                                  // if ComputerChoice = 2
                        StartPoint -= RanDice;              //  StartPoint = StartPoint-RandDice
                        if (StartPoint < 0)                 // 0<0 den it will again start
                        {
                            StartPoint = 0;
                        }
                        Console.WriteLine("Snake Attack:" + StartPoint);
                        Console.WriteLine(StartPoint); // If snake attack StartPoint will be 0 (initial Poistion = 0)
                        break;
                    default:
                        Console.WriteLine("Invalid Option");  //If other than 0 to 2
                        break;
                }
               
            }

        }
    }
}
