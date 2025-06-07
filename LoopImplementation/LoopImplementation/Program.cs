using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop - Until the condition is true
            string name = "";
            while (name == "") {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            // For loop - Until a finite amount of times
            Console.WriteLine("The first for loop!");
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("The value is " + i);
            }

            Console.WriteLine("The second for loop!");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("The value is " + i);
            }

            Console.ReadKey();
        }
    }
}
