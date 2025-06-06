using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displaying on the console
            Console.Write("Greatings! ");
            Console.WriteLine("Time to start learning C#");

            // Making a beep noice
            Console.Beep();

            /*
             * Escape Sequence -> Represents
             * \a -> Bell (alert)
             * \b -> Backspace
             * \f -> Form feed
             * \n -> New Line
             * \r -> Carriage Return
             * \t -> Horizontal tab
             * \v -> Vertical tab
             * \' -> Single Quatation Mark
             * \" -> Double Quatation Mark
             * \\ -> backslash
             * \? -> Literal Question Mark
             */

            // Trying out a few escape sequence
            Console.WriteLine("\tEscape");
            Console.WriteLine("Es\bcape");

            // Trying to remove the quite press key until program finishes
            Console.ReadKey();
        }
    }
}
