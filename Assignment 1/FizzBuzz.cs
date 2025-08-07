using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class FizzBuzz
    {
        public static void PrintFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)   // loop from 1 through 100
            {
                // check divisibility by both 3 and 5 first
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                // if not, check divisibility by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                // if not, check divisibility by 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                // if none of the above, print the number itself
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
