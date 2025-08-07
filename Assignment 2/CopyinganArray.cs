using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class CopyinganArray
    {
        public static void CopyArray()
        {
            // 1. Create and populate the original array with 10 items
            int[] original = new int[10] { 5, 12, 7, 3, 9, 14, 2, 8, 11, 6 };

            // 2. Create the copy array using Length of the original
            int[] copy = new int[original.Length];

            // 3. Copy each element via a loop
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }

            // 4. Print both arrays to verify
            Console.WriteLine("Original array:");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i] + " ");
            }
            Console.WriteLine();  // line break

            Console.WriteLine("Copied array:");
            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write(copy[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
