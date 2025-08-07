using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Greetings
    {
        public static void PrintGreetings()
        {
            DateTime now = DateTime.Now;            // current date & time
            int h = now.Hour;                       // hour in 0–23

            if (h >= 5 && h < 12)                   // 05:00–11:59
                Console.WriteLine("Good Morning");
            if (h >= 12 && h < 17)                  // 12:00–16:59
                Console.WriteLine("Good Afternoon");
            if (h >= 17 && h < 21)                  // 17:00–20:59
                Console.WriteLine("Good Evening");
            if (h >= 21 || h < 5)                   // 21:00–23:59 or 00:00–04:59
                Console.WriteLine("Good Night");
        }

    }
}
