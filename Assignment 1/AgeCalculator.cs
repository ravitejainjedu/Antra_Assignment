using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class AgeCalculator
    {
        public static void CalculateAge()
        {
            // define birth date (year, month, day)
            DateTime birthDate = new DateTime(2001, 5, 15);

            // compute days lived
            int daysLived = (DateTime.Today - birthDate).Days;
            Console.WriteLine($"You are {daysLived} days old.");

            // compute days until next 10,000 day milestone
            int daysToNextAnniversary = 10000 - (daysLived % 10000);
            DateTime nextAnniv = DateTime.Today.AddDays(daysToNextAnniversary);
            Console.WriteLine($"Your next 10,000 day anniversary is on {nextAnniv:MMMM d, yyyy}.");
        }
    }
}
