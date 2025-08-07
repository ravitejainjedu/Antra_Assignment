using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class PrimeNumberCalculator
    {
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            // ensure we start at 2 (smallest prime)
            for (int i = Math.Max(2, startNum); i <= endNum; i++)
            {
                bool isPrime = true;
                // test divisors up to √i
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    primes.Add(i);
            }
            return primes.ToArray();
        }
    }
}
