using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Counting
    {
        public static void CountingbyIncrements()
        {
            for (int step = 1; step <= 4; step++)   // outer loop: step = 1,2,3,4
            {
                for (int n = 0; n <= 24; n += step) // inner loop: n = 0→24 by 'step'
                {
                    Console.Write(n);
                    if (n + step <= 24)            // print comma except after last
                        Console.Write(",");
                }
                Console.WriteLine();               // move to next line
            }
        }
    }
}
