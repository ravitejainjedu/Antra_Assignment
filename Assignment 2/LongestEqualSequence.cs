using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class LongestEqualSequence
    {
        public static void LongestSequenceofEqualElements() 
        {
            // read and parse input into an int array
            int[] a = Console.ReadLine()
                             .Split()            // split on whitespace
                             .Select(int.Parse)  // convert each token to int
                             .ToArray();

            int bestVal = a[0], bestLen = 1;
            int curVal = a[0], curLen = 1;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == curVal)
                {
                    curLen++;  // extend current run
                }
                else
                {
                    // new value: compare previous run to best
                    if (curLen > bestLen)
                    {
                        bestLen = curLen;
                        bestVal = curVal;
                    }
                    curVal = a[i];  // reset current run
                    curLen = 1;
                }
            }
            // final check after loop
            if (curLen > bestLen)
            {
                bestLen = curLen;
                bestVal = curVal;
            }

            // print bestVal repeated bestLen times
            Console.WriteLine(string.Join(" ", Enumerable.Repeat(bestVal, bestLen)));
        }
    }
}
