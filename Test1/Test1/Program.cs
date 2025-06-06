using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accepting user inputs

            Console.WriteLine("What's your name? ");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your name is " + name + " and your age is " + age + " years old.");

            Console.ReadKey();
        }
    }
}
