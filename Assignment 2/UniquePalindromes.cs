using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class UniquePalindromes
    {
        public static void FindUniquePalindromes()
        {
            string text = "Hi, exe? ABBA! Hog fully a string: ExE. Bob";
            Console.WriteLine(string.Join(", ", ExtractPalindromes(text)));
        }

        static IEnumerable<string> ExtractPalindromes(string input)
        {
            var seen = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            // find words
            foreach (Match m in Regex.Matches(input, @"\b[A-Za-z]+\b"))
            {
                string word = m.Value;
                string lower = word.ToLower();
                string rev = new string(lower.Reverse().ToArray());
                if (lower == rev && !seen.ContainsKey(lower))
                    seen[lower] = word;
            }
            // sort by lowercase
            return seen.Values
                       .OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
        }
    }
}
