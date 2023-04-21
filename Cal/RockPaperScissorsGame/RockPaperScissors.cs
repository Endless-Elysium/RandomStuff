using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public static class RockPaperScissors
    {
        static Random random;
        public static void GameStart()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Rock, paper, or scissors?");
            string input = Console.ReadLine();
            while (input == null)
            {
                input = Console.ReadLine();
            }
            input = input.ToLower();
            WinOrLose(input, Foe());
        }
        private static string Foe()
        {   
            random = new Random();
            switch(random.Next(0,4))
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
                default:
                    return "rock";
            }
        }
        private static void WinOrLose(string Input, string Foe)
        {
            if (Input == null)
            {
                Console.WriteLine("You did not say a proper move!");
            }
            if (Input == Foe)
            {
                Console.WriteLine("I picked " + Foe);
                Console.WriteLine("Tie");
                return;
            }
            if (Input == "rock" && Foe == "scissors" || Input == "paper" && Foe == "rock" || Input == "scissors" && Foe == "paper")
            {
                Console.WriteLine("I picked " + Foe);
                Console.WriteLine("You win!");
                return;
            } else
            {
                Console.WriteLine("I picked " + Foe);
                Console.WriteLine("You lose");
                Console.WriteLine("Deleting System32 in ");
                Console.WriteLine("3");
                Thread.Sleep(2000);
                Console.WriteLine("2");
                Thread.Sleep(2000);
                Console.WriteLine("1");
                Thread.Sleep(500);
                Console.WriteLine("ERROR 626f6f62730a Failed to find folder");
            }
        }
    }
}
