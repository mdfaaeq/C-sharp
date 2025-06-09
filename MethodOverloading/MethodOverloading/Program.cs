using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1;
            double result2;

            result1 = Multiply(12.2, 2);
            result2 = Multiply(12.2, 2, 4);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

    }
}
