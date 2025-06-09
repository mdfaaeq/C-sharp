using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The 'params' keyword allows a method to accept a variable number of arguments.
            // In this case, the CheckOut method can take any number of double values as input.
            // These values are passed as an array to the method.

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25); // Passing multiple item prices to calculate total
            Console.WriteLine(total); // Output the total amount
            Console.ReadKey(); // Wait for user input before closing the console window
        }

        // This method calculates the total of all the prices passed to it.
        // The 'params' keyword allows passing any number of double values.
        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price; // Add each price to the total
            }

            return total; // Return the total amount
        }
    }
}
