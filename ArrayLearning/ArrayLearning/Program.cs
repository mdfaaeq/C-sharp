using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array = a variable tbhat can store multiple values.
            string[] cars = { "BMW", "Toyota", "BYD" };

            cars[0] = "Tesla";

            for (int i = 0; i < cars.Length; i++) { 
                Console.WriteLine(cars[i]);
            }

            // Decalaring array with a fix size
            string[] bikes = new string[3];
            bikes[0] = "Yamaha";
            bikes[1] = "TVS";
            bikes[2] = "Suzuki";

            for (int i = 0; i < bikes.Length; i++)
            {
                Console.WriteLine(bikes[i]);
            }

            Console.ReadKey();
        }
    }
}
