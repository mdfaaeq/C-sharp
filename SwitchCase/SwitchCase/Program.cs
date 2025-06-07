using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch - An alternative to if statements
            Console.Write("What day is it today: ");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Tuesday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Wednesday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Thursday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Friday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Saturday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Sunday":
                    Console.WriteLine("It is " + day);
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;

            }

            Console.ReadKey();
        }
    }
}
