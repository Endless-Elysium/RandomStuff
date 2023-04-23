using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public static class Timer
    {
        public static void BeginTimer() 
        {
            Console.WriteLine("How long?");
            Console.WriteLine("Enter in Seconds");
            int Time = Convert.ToInt32(Console.ReadLine()) * 1000;
            Console.WriteLine("Timer Start");
            Thread.Sleep(Time / 2);
            Console.WriteLine((Time / 2) / 1000 + " Seconds remaing");
            Thread.Sleep(Time / 2);
            Console.WriteLine("Timer End");
        }
    }
}
