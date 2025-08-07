using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class GuessRandomNumber
    {
        public static void RandomNumberGeneration()
        {
            // create a Random instance
            Random rng = new Random();

            // generate a number in [1,3]
            int correctNumber = rng.Next(3) + 1;

            // prompt
            Console.Write("Guess a number between 1 and 3: ");

            // read and convert to int (assumes valid integer input)
            int guessedNumber = int.Parse(Console.ReadLine());

            // check range first
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range (1–3).");
            }
            // guess too low
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Too low!");
            }
            // guess too high
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("Too high!");
            }
            // correct guess
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
