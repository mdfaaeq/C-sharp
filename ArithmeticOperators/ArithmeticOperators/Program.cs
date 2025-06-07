using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            // Addition
            //num = num + 2;
            //num += 2;
            //num++;

            // Subtraction
            //num = num - 1;
            //num -= 1;
            //num--;

            // Multiplication
            //num = num * 2;
            //num *= 2;

            // Division
            //num = num / 2;
            //num /= 2;

            int remainder = num % 3;

            Console.WriteLine("The value stored in num is " + num);

            Console.WriteLine("The remainder value is " + remainder);

            // Use of the math class
            double x = 3;
            double y = 5;
            
            // Calculating the power
            double a = Math.Pow(x, 2);
            Console.WriteLine("Power " + a);

            // Calculating the square root
            double b = Math.Sqrt(x);
            Console.WriteLine("Square Root " + b);

            // The absolute value of -3 is +3
            double x1 = -3;
            double c = Math.Abs(x1);
            Console.WriteLine("Absolute " + c);

            // The rounded value
            double x2 = 3.51;
            double d = Math.Round(x2);
            Console.WriteLine("Rounded value " + d);

            // Round up
            double e = Math.Ceiling(x2);
            Console.WriteLine("Round up " + e);

            // Round down
            double f = Math.Floor(x2);
            Console.WriteLine("Round down " + f);

            // Finding the maximum value
            double g = Math.Max(x, y);
            Console.WriteLine("Maximum value " + g);

            // Finding the minimum value
            double h = Math.Min(x, y);
            Console.WriteLine("Minimum value " + h);

            // Generating a random numbers
            Random random = new Random();
            // Guessing rolling a dice
            int num1 = random.Next(1, 7);
            Console.WriteLine(num1);

            double num2 = random.NextDouble();
            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
