using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class SumofRotatedArryas
    {
        public static void SumOfRotatedArrays()
        {
            // read space-separated integers
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();
            int n = arr.Length;
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[n];

            // for each rotation count r = 1…k
            for (int r = 1; r <= k; r++)
            {
                int shift = r % n;  // effective shift
                                    // for each position i, add element from original at (i–shift)
                for (int i = 0; i < n; i++)
                    sum[i] += arr[(i - shift + n) % n];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
