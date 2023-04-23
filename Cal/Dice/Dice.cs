using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public static class Dice
    {
        static Random random = new Random();
        public static void Begin()
        {
            var a = AskForNumber();
            RollDie(a.Item1, a.Item2, a.Item3);
        }
        static void RollDie(int sides, int rolls, int dice)
        {
            if (dice == 0)
            {
                return;
            }
            if (dice == 1)
            {
                for (int i = 0; i < rolls; i++)
                {
                    Console.WriteLine("Roll " + (i + 1) + ": " + random.Next(1, sides - 1));
                }
                return;
            }
            for (int i = 0; i < rolls; i++)
            {
                Console.WriteLine("Roll " + (i + 1) + ": " + random.Next(1, sides + 1) + " + " + random.Next(1, sides + 1));
            }
            return;

        }
        static (int, int, int) AskForNumber()
        {
            int sides;
            int dice;
            int rolls;
            try
            {
                Console.WriteLine("How many sides should it have?");
                sides = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many dice? 1 or 2");
                dice = Convert.ToInt32(Console.ReadLine());
                if (dice > 1)
                {
                    Console.WriteLine("How many times should I roll them?");
                } else
                {
                    Console.WriteLine("How many times should I roll it?");
                }
                rolls = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            } catch 
            {
                Console.WriteLine("Enter a number");
                return (0,0,0);
            }
            return (sides, rolls, dice);
        }
    }
}
