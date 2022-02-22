using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class ExactWinningPosition
    {
        /// <summary>
        /// UC_5_putting winning position for player
        /// </summary>
        public static void PlayGame()
        {
            const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Posi = 100;
            int player_Posi = 0, DiceRoll;

            Console.WriteLine("Start the game");
            Console.WriteLine("Starting position player is: " + player_Posi);
            Random random = new Random();

            while (player_Posi < Winning_Posi)
            {
                DiceRoll = random.Next(1, 7);
                Console.WriteLine("Player get Dice Number " + DiceRoll);

                switch (random.Next(0, 3))
                {
                    case No_Play:
                        Console.WriteLine(" Player Position " + player_Posi);
                        break;

                    case Ladder:
                        player_Posi += DiceRoll;
                        if (player_Posi > Winning_Posi)
                        {
                            player_Posi -= DiceRoll;
                        }
                        Console.WriteLine("Ladder Player Position " + player_Posi);
                        break;
                    case Snake:
                        player_Posi -= DiceRoll;
                        if (player_Posi < 0)
                        {
                            player_Posi = 0;
                        }
                        Console.WriteLine("Snake Player Position " + player_Posi);
                        break;
                }
                Console.WriteLine(" Congratulations you Won");
            }

        }
    }
}
