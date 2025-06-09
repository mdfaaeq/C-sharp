using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Note: Dividing a double by zero does NOT throw an exception in C#.
            // Instead, it returns Infinity (∞) or NaN according to IEEE 754 rules.

            double x;
            double y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine("Result: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally {
                Console.WriteLine("Calculation is done...");
            }
        }
    }
}

