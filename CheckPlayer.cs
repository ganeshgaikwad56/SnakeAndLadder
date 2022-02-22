using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class CheckPlayer
    {
        /// <summary>
        /// Checks the player whether No_Play,Snake,Ladder
        /// </summary>
        public static void CheckThePlayer()
        {
            const int No_Play = 0, Ladder = 1, Snake = 2;
            int player_Posi = 0, DiceRoll;
            Console.WriteLine("Start the Game ");
            Console.WriteLine("Starting position player is: " + player_Posi);
            Random random = new Random();
            DiceRoll = random.Next(1, 7);

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
                        break;
                }
            
        }
    }
}
