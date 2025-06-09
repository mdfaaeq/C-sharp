using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            double result = 0;
            bool perform = true;
            int option;
            string response;

            for (int i = 0; i < 18; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.WriteLine("Calculator Program");

            for (int i = 0; i < 18; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            while (perform) { 
                Console.WriteLine("Select one of the below option, ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("Enter number from (1-4): ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option) { 
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine(result);
                        break;
                    case 4:
                        result = num1 / num2;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Please enter a number between (1-4).");
                        break;
                }

                Console.Write("Would you like to continue (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    perform = true;
                }
                else if (response == "N")
                {
                    perform = false;
                }
                else
                {
                    Console.WriteLine("Please enter (Y/N).");
                }
            }

                Console.ReadKey();
        }
    }
}
