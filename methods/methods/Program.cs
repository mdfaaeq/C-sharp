using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Daily Routing";
            message(msg);

            double x;
            double y;
            double result;
            Console.Write("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static void message(string msg) {
            Console.WriteLine(msg);
            Console.WriteLine("1. Wake up");
            Console.WriteLine("2. Eat");
            Console.WriteLine("3. Code");
            Console.WriteLine("4. Sleep");
            Console.WriteLine();
        }

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }
    }
}
