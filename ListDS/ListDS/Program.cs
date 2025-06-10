using System;
using System.Collections.Generic;

namespace ListDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing a list
            List<string> food = new List<string>();
            // Adding items to list
            food.Add("Pizza");
            food.Add("Burger");
            food.Add("Sandwich");
            food.Add("Masala");

            // Removing items from the lsit
            food.Remove("Masala");

            // Interting a intem to a specific index
            food.Insert(0, "Kottu");

            // Getting the count of the items in the list
            Console.WriteLine(food.Count);

            // Getting the index of a item
            Console.WriteLine(food.IndexOf("Sandwich"));

            // Getting the item of the last index
            Console.WriteLine(food.LastIndexOf("Burger"));

            // Checking if the item is there -> Gives answer of true/false
            Console.WriteLine(food.Contains("Pizza"));

            // Sorting Alphabatical
            food.Sort();

            // Sorting in reverse order
            food.Reverse();

            // Clear the list
            // food.Clear();

            // Converting a list into an array
            string[] foodArray = food.ToArray();

            foreach (string item in food) { 
                Console.WriteLine(item);
            }

            foreach (string itemArray in foodArray)
            {
                Console.WriteLine(itemArray);
            }

            Console.ReadKey();
        }
    }
}
