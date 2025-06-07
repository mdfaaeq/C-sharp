using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getting the name from the user
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // The order does matter inif statements 

            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }

            // Getting the age from the user
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // The order does matter inif statements 

            if (age > 100) {
                Console.WriteLine("You are too old to sign up!");
            } else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }

            Console.ReadKey();
        }
    }
}
