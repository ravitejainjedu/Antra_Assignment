using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class ReverseString
    {
        public static void ReverseStringExample()
        {
            // read input from console
            string input = Console.ReadLine();

            // convert to char array
            char[] chars = input.ToCharArray();

            // reverse the array in-place
            Array.Reverse(chars);

            // convert back to string and print
            string reversed = new string(chars);
            Console.WriteLine(reversed);
        }

        public static void ReverseStringWithLoop()
        {
            // read input from console
            string input = Console.ReadLine();

            // use StringBuilder for efficiency
            var sb = new StringBuilder();

            // append characters from end to start
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            // output the result
            Console.WriteLine(sb.ToString());
        }
    }
}
