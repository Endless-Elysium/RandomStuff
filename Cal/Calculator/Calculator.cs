namespace Cal
{
    public static class NumberMachine
    {
        public static void GameStart()
        {
            Console.WriteLine("Calculator");
            do
            {
                Console.WriteLine();
                Console.WriteLine("What operation do you want? ");
                Console.WriteLine("    +, ++ for 3 Numbers");
                Console.WriteLine("    -, -- for 3 Numbers");
                Console.WriteLine("    x, xx for 3 Numbers");
                Console.WriteLine("    /, // for 3 Numbers");
                Console.WriteLine("    % for remainder");
                string Input = Console.ReadLine();
                Console.WriteLine("First Number?");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Number?");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = 0;
                if (Input.Length > 1)
                {
                    Console.WriteLine("Third Number?");
                    z = Convert.ToInt32(Console.ReadLine());
                }
                int Result = 0;
                switch (Input)
                {
                    case "+":
                        Result = AddTwo(x, y);
                        break;
                    case "-":
                        Result = MinusTwo(x, y);
                        break;
                    case "x":
                        Result = MultiTwo(x, y);
                        break;
                    case "/":
                        Result = DivideTwo(x, y);
                        break;
                    case "++":
                        Result = AddThree(x, y, z);
                        break;
                    case "--":
                        Result = MinusThree(x, y, z);
                        break;
                    case "xx":
                        Result = MultiThree(x, y, z);
                        break;
                    case "//":
                        Result = DivideThree(x, y, z);
                        break;
                    case "%":
                        Result = Mod(x, y);
                        break;
                }
                Console.WriteLine();
                Console.Write("The result is ");
                Console.Write(Result);
            } while(true);
        }
        static int AddTwo(int x, int y) { return x + y; }
        static int AddThree(int x, int y, int z) { return x + y + z; }
        static int MinusTwo(int x, int y) { return x - y; }
        static int MinusThree(int x, int y, int z) { return x - y - z; }
        static int MultiTwo(int x, int y) { return x * y; }
        static int MultiThree(int x, int y, int z) { return x * y* z; }
        static int DivideTwo(int x, int y) 
        {
            try
            {
                return x / y; 
            } catch (Exception)
            {
                Console.WriteLine("You can't divide zero!");
                return 0;
            }
        }
        static int DivideThree(int x, int y, int z) 
        { 
            try
            {
                return x / y / z;
            } catch(Exception)
            {
                Console.WriteLine("You can't divide zero!");
                return 0;
            }
        }
        static int Mod(int x, int y) 
        { 
            try
            {
            return x % y; 
            } catch
            {
                Console.WriteLine("You can't divide zero!");
                return 0;
            }
        }
    }
}