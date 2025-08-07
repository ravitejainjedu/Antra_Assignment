using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class MostFrequentNumber
    {
        public static void FindMostFrequentNumber()
        {
            // read and parse input
            int[] a = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

            var count = new Dictionary<int, int>();
            var firstIdx = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                int v = a[i];
                if (!count.ContainsKey(v))
                {
                    count[v] = 0;
                    firstIdx[v] = i;  // record first occurrence
                }
                count[v]++;
            }

            int maxFreq = count.Values.Max();
            // select numbers with max frequency, ordered by first occurrence
            var tied = count
                .Where(kv => kv.Value == maxFreq)
                .OrderBy(kv => firstIdx[kv.Key])
                .Select(kv => kv.Key)
                .ToList();

            if (tied.Count == 1)
            {
                Console.WriteLine(
                  $"The number {tied[0]} is the most frequent (occurs {maxFreq} times)"
                );
            }
            else
            {
                string list = string.Join(", ", tied);
                Console.WriteLine(
                  $"The numbers {list} have the same maximal frequency (each occurs {maxFreq} times). " +
                  $"The leftmost of them is {tied[0]}"
                );
            }
        }
    }
}
