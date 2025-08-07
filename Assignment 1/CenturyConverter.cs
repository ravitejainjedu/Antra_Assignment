using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class CenturyConverter
    {
        public static void ConvertCenturiesToTime()
        {
            // read centuries
            Console.Write("Enter number of centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            // centuries → years
            int years = centuries * 100;

            // years → days (accounting for leap years)
            // leap years = years/4 − years/100 + years/400
            int leapDays = years / 4 - years / 100 + years / 400;
            int days = years * 365 + leapDays;

            // days → hours → minutes → seconds → milliseconds
            long hours = (long)days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;

            // beyond long’s range, use BigInteger
            BigInteger microseconds = (BigInteger)milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            // output
            Console.WriteLine(
                $"{centuries} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{milliseconds} milliseconds = {microseconds} microseconds = " +
                $"{nanoseconds} nanoseconds");
        }
    }
}
