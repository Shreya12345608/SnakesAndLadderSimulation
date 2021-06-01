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
        int StartPoint1 = 0;  //initialize by 0
        public int RanDice = 0;
        public int count;
        public int randomeNumber;
        public string play;
     
        public int No_Play = 0; 
        public int Ladder = 1;
        public int Snake = 2;
        public void StartPlaying()
        {
            Console.WriteLine("Game Started! Good Luck "); //Start Game
           while (StartPoint != 100)  // Start Poinnt ! =100
            {
              
                Random Random = new Random(); //Creating Random Object
                RanDice = Random.Next(1, 7); // Rndom value in B/w 1 to 6
                Console.WriteLine("player Role Dice number is:" + " " + RanDice); // Printing Random Value on b/w 1 to 6
                randomeNumber = Random.Next(0, 3);  //Choice to check its snake or ladder

            if(randomeNumber == 0)
            {
                play = "No_Play";
            }
            else if(randomeNumber == 1)
            {
                play = "Ladder";
            }
            else if (randomeNumber == 2)
            {
                play = "Snake";
            }
            Console.WriteLine("Dice value:" + play); // taking input Choice
                switch (play) //Switch Case 
                {
                    //For No Play
                    case "No_Play":                            // if ComputerChoice = 0
                        Console.WriteLine("No Moves");
                        count++;
                        break;
                    case "Ladder":                             // if ComputerChoice = 1
                        StartPoint += RanDice;           //  StartPoint = StartPoint+RandDice
                        count++;
                        if (StartPoint > 100)           // checking StartPoint> 100
                        {
                          
                            StartPoint -=StartPoint;     //  StartPoint = StartPoint-StartPoint
                       }
                        Console.WriteLine("Position of the Player:" + StartPoint);
                        break;
                    case "Snake":                                  // if ComputerChoice = 2
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
                Console.WriteLine("Dice Role to Win the Game is " + count); // Dice Role to Win the Game is will ( count)

            }

        }
    }
}
