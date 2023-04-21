using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPS;
using Cal;
using Lottery;

namespace TheHub
{
    internal class TheHub
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press");
                Console.WriteLine("    1 for Calculator");
                Console.WriteLine("    2 for RockPaperScissors");
                Console.WriteLine("    3 for Lottery");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        NumberMachine.GameStart();
                        break;
                    case "2":
                        RockPaperScissors.GameStart();
                        break;
                    case "3":
                        Gamble.GameStart();
                        break;
                }   
            }
        }
    }
}
