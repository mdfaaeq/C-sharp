using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the temperature outside: (C) ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <=25) {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }

            Console.ReadKey();
        }
    }
}
