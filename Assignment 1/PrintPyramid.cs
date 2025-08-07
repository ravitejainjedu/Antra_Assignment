using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class PrintPyramid
    {
        public static void PrintPyramidPattern()
        {
            // total number of pyramid levels
            int rows = 5;                               

            // outer loop: one iteration per line
            for (int i = 0; i < rows; i++)
            {
                // inner loop 1: print leading spaces
                for (int j = 0; j < rows - i - 1; j++)
                    Console.Write(' ');

                // inner loop 2: print stars (odd count: 1, 3, 5, ...)
                for (int k = 0; k < 2 * i + 1; k++)
                    Console.Write('*');

                Console.WriteLine();                    
            }
        }
    }
}
