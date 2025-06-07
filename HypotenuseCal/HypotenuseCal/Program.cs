using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypotenuseCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();
        }
    }
}
