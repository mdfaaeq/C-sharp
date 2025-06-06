using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring a variable
            int x;
            x = 123; // Intializing

            int y = 321;

            int z = x + y;

            int age = 21;

            double height = 300.5;

            bool alive = false;

            char symbol = '@';

            String name = "Mohamed";

            String username = symbol + name;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Your age is " + age);

            Console.WriteLine("Your height is " + height + "cm");

            Console.WriteLine("Are you alive? " + alive);

            Console.WriteLine("Your symbol is: " + symbol);

            Console.WriteLine("Your username is: " + username);

            Console.ReadKey();
        }
    }
}
