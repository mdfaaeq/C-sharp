using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String interpolation allows embedding variables directly inside strings using the $ symbol.
            // Example: $"Result: {result}" is easier to read and less error-prone than "Result: " + result.

            string firstName = "Mohamed";
            string lastName = "Fazal";
            int age = 22;

            //Console.WriteLine("Hello " + firstName + " " + lastName);
            //Console.WriteLine("Your are " + age + " years old.");
            //Console.WriteLine();

            Console.WriteLine($"Hello {firstName} {lastName}");
            Console.WriteLine($"Your are {age} years old.");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
