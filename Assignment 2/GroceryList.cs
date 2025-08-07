using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class GroceryList
    {
        public static void PrintGroceryList()
        {
            // holds the current list of items
            var items = new List<string>();

            while (true) // infinite loop
            {
                // prompt user
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string input = Console.ReadLine()?.Trim();
                if (input == null) continue; // no input—restart loop

                if (input == "--")
                {
                    // clear the list
                    items.Clear();
                    Console.WriteLine("List cleared.");
                }
                else if (input.StartsWith("+ "))
                {
                    // add new item (substring after "+ ")
                    string toAdd = input.Substring(2).Trim();
                    if (toAdd.Length > 0)
                    {
                        items.Add(toAdd);
                        Console.WriteLine($"Added \"{toAdd}\".");
                    }
                    else
                    {
                        Console.WriteLine("Nothing to add.");
                    }
                }
                else if (input.StartsWith("- "))
                {
                    // remove item (substring after "- ")
                    string toRemove = input.Substring(2).Trim();
                    if (items.Remove(toRemove))
                    {
                        Console.WriteLine($"Removed \"{toRemove}\".");
                    }
                    else
                    {
                        Console.WriteLine($"Item \"{toRemove}\" not found.");
                    }
                }
                else
                {
                    // unrecognized command
                    Console.WriteLine("Invalid command.");
                }

                // display current list
                if (items.Count == 0)
                {
                    Console.WriteLine("[empty]");
                }
                else
                {
                    Console.WriteLine("Current list:");
                    foreach (var item in items)
                    {
                        Console.WriteLine($"- {item}");
                    }
                }

                Console.WriteLine(); // blank line for readability
            }
        }
    }
}
