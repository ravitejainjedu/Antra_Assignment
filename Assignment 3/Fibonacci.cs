using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Fibonacci
    {
        // returns the nth Fibonacci number
        public static int FibonacciSeries(int n)
        {
            // base case: 1st or 2nd item is 1
            if (n == 1 || n == 2)
                return 1;
            // recursive case: sum of two previous
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}
