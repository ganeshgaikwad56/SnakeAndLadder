using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    /// <summary>
    /// UC_2_Finding Number
    /// </summary>
    public class RollingDie

    {
        public static void RollsTheDie()
        {
           

            Random random = new Random();
            int DiceRoll = random.Next(1,7);

           Console.WriteLine("The Number is :" + DiceRoll);
            
        }
    }
}
