using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = 20;
            String message;
            String message1;

            // Performance using if condition
            if (temperature >= 15)
            {
                message1 = "It's warm outside";
            }
            else
            {
                message1 = "It's cold outside";
            }
            Console.WriteLine(message1);

            // Performance using condition operator (condition) ? x : y
            // Since its return a value it needs to be assigned
            message = (temperature >= 15) ? "It's warm outside" : "It's cold outside";
            Console.WriteLine(message);

            Console.ReadKey();

        }
    }
}
