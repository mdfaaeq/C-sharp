using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] cars = { "BMW", "Toyota", "BYD" };

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
