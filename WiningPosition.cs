using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class WiningPosition
    {
       
        public static void PlaySnakeAndLadder()
        {
            const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Posi = 100;
            int player_Posi = 0, DiceRoll;
            Console.WriteLine("Start the Game ");
            Console.WriteLine("Starting position player is: " + player_Posi);
            Random random = new Random();
            DiceRoll = random.Next(1, 7);

            while (player_Posi < Winning_Posi)
            {
   
                Console.WriteLine("Player gets Dice Number: " + DiceRoll);

                switch (random.Next(0, 3))
                {
                    case No_Play:
                        Console.WriteLine("No_Play");
                        break;

                    case Ladder:
                        player_Posi += DiceRoll;
                        Console.WriteLine(" Ladder " + player_Posi);
                        break;

                    case Snake:
                        player_Posi -= DiceRoll;
                        Console.WriteLine(" Snake " + player_Posi);
                        if (player_Posi < 0)
                        {
                            player_Posi = 0;
                        }
                        break;
                }
            }
        }

    }
}
