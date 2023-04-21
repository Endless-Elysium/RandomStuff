using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public static class Gamble
    {
        static int Money = 0;
        static int Winnings = 0;
        static bool Play = true;
        static Random random = new Random();
        static int[] Winning5Numbers;
        static int[] Winning7Numbers;
        static int[] PlayerNumbers = new int[7];
        static int Wins = 0;
        static int Loses = 0;
        public static void GameStart()
        {
            Money = 17;
            while (Play)
            {
                Play = false;
                Console.WriteLine("Would you like to play !LUCKY!5s or AMAZ-ING7s?");
                Console.WriteLine("Lucky fives cost 6 to play");
                Console.WriteLine("Amazing sevens cost 10 to play");
                Console.WriteLine("You have " + Money);
                string input = Console.ReadLine();
                if (input == null || input == "5")
                {
                    LuckyFives();
                }
                else if (input == "69")
                {
                    CreatePlayersNumber(7);
                    for (int i = 5000000; i > 0; i--)
                    {
                        Console.WriteLine("Remaining:" + i);
                        SuperSevens();
                    }
                }
                else
                {
                    AmazingSevens();
                }
                Console.WriteLine("Would you like to play again?");
                input = Console.ReadLine();
                input = input.ToLower();
                if (input != null || input == "y" || input == "yes")
                {
                    Play = true;
                } else
                {
                    return;
                }
            }
        }
        private static void LuckyFives()
        {
            Console.WriteLine("You are playing !LUCKY!5s");
            int Cost = 6;
            Money -= Cost;
            Winnings = 100000;
            GenerateWinning5Numbers();
            CreatePlayersNumber(5);
            Console.WriteLine("---------------------");
            Console.WriteLine("Yours:   " + PlayerNumbers[0] + " " + PlayerNumbers[1] + " " + PlayerNumbers[2] + " " + PlayerNumbers[3] + " " + PlayerNumbers[4]);
            Console.WriteLine("Winning: " + Winning5Numbers[0] + " " + Winning5Numbers[1] + " " + Winning5Numbers[2] + " " + Winning5Numbers[3] + " " + Winning5Numbers[4]);
            if (!Conpare5Numbers())
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You win!");
                Money += Winnings;
            }
        }
        private static void AmazingSevens()
        {
            Console.WriteLine("You are playing AMAZ-ING7s");
            int Cost = 10;
            Money -= Cost;
            Winnings = 5000000;
            GenerateWinning7Numbers();
            CreatePlayersNumber(7);
            Console.WriteLine("---------------------");
            Console.WriteLine("Yours:   " + PlayerNumbers[0] + " " + PlayerNumbers[1] + " " + PlayerNumbers[2] + " " + PlayerNumbers[3] + " " + PlayerNumbers[4] + " " + PlayerNumbers[5] + " " + PlayerNumbers[6]);
            Console.WriteLine("Winning: " + Winning7Numbers[0] + " " + Winning7Numbers[1] + " " + Winning7Numbers[2] + " " + Winning7Numbers[3] + " " + Winning7Numbers[4] + " " + Winning7Numbers[5] + " " + Winning7Numbers[6]);
            if (!Conpare7Numbers())
            {
                Console.WriteLine("You lose");
            } else
            {
                Console.WriteLine("You win!");
                Money += Winnings;
            }
        }
        private static void SuperSevens()
        {
            Console.WriteLine("Wins: " + Wins);
            Console.WriteLine("Loses: " + Loses);
            Console.WriteLine("Money: " + Money);
            int Cost = 10;
            Money -= Cost;
            Winnings = 5000000;
            GenerateWinning7Numbers();
            Console.WriteLine("---------------------");
            Console.WriteLine("Yours:   " + PlayerNumbers[0] + " " + PlayerNumbers[1] + " " + PlayerNumbers[2] + " " + PlayerNumbers[3] + " " + PlayerNumbers[4] + " " + PlayerNumbers[5] + " " + PlayerNumbers[6]);
            Console.WriteLine("Winning: " + Winning7Numbers[0] + " " + Winning7Numbers[1] + " " + Winning7Numbers[2] + " " + Winning7Numbers[3] + " " + Winning7Numbers[4] + " " + Winning7Numbers[5] + " " + Winning7Numbers[6]);
            if (!Conpare7Numbers())
            {
                Console.WriteLine("You lose");
                Loses += 1;
            }
            else
            {
                Console.WriteLine("You win!");
                Wins += 1;
                Money += Winnings;
            }
        }
        private static bool Conpare5Numbers()
        {
            int Matching = 0;
            for (int i = 0; i < 5; i++)
            {
                if (Winning5Numbers[i] == PlayerNumbers[i])
                {
                    Matching++;
                }
            }
            if (Matching == 5)
            {
                return true;
            }
            return false;
        }
        private static bool Conpare7Numbers()
        {
            int Matching = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Winning7Numbers[i] == PlayerNumbers[i])
                {
                    Matching++;
                }
            }
            if (Matching == 6)
            {
                return true;
            }
            return false;
        }
        private static void GenerateWinning5Numbers()
        {
            Winning5Numbers = new int[5];
            for (int i = 0; i < 5;  i++)
            {
                Winning5Numbers[i] = random.Next(1, 51);
            }
            Winning5Numbers = Winning5Numbers.Distinct().ToArray();
            if (Winning5Numbers.Length < 5)
            {
                GenerateWinning5Numbers();
            }
        }
        private static void GenerateWinning7Numbers()
        {
            Winning7Numbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Winning7Numbers[i] = random.Next(1, 99);
            }
            Winning7Numbers = Winning7Numbers.Distinct().ToArray();
            if (Winning7Numbers.Length <= 6)
            {
                GenerateWinning7Numbers();
            }
        }
        private static void CreatePlayersNumber(int Amount)
        {
            for (int i = 0; i < Amount; i++)
            {
                try
                {
                    Console.WriteLine("Number " + (i + 1));
                    Console.WriteLine("What is your number?");
                    PlayerNumbers[i] = Convert.ToInt32(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Please enter a number!");
                    i--;
                } 
            }
        }
    }
}
