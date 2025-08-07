using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class ReverseWords
    {
        public static void ReverseWordsInString()
        {
            var lines = new[] {
            "C# is not C++, and PHP is not Delphi!",
            "The quick brown fox jumps over the lazy dog /Yes! Really!!!/."
        };
            foreach (var line in lines)
                Console.WriteLine(ReverseWord(line));
        }

        static string ReverseWord(string input)
        {
            // separators definition
            var seps = new HashSet<char>(". ,;:=()&[]'\"/\\\\!?\u0020".Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            var tokens = new List<string>();
            var words = new List<string>();
            // split into tokens
            int i = 0;
            while (i < input.Length)
            {
                if (seps.Contains(input[i]))
                {
                    tokens.Add(input[i].ToString());
                    i++;
                }
                else
                {
                    int j = i;
                    while (j < input.Length && !seps.Contains(input[j])) j++;
                    var w = input[i..j];
                    tokens.Add(w);
                    words.Add(w);
                    i = j;
                }
            }
            words.Reverse();
            int wi = 0;
            // rebuild
            for (int k = 0; k < tokens.Count; k++)
            {
                if (!string.IsNullOrEmpty(tokens[k]) && !seps.Contains(tokens[k][0]))
                {
                    tokens[k] = words[wi++];
                }
            }
            return string.Concat(tokens);
        }
    }
}
