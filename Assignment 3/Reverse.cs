using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Reverse
    {
        // creates an array of the given length filled 1,2,…,length
        public static int[] GenerateNumbers(int length)
        {
            int[] nums = new int[length];
            for (int i = 0; i < length; i++)
                nums[i] = i + 1;
            return nums;
        }

        // reverses the array in place by swapping symmetric elements
        public static void ReverseArray(int[] arr)
        {
            int mid = arr.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }

        // prints each element followed by a space, then a newline
        public static void PrintNumbers(int[] arr)
        {
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
        }

    }
}
