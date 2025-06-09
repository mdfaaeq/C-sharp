using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Daily Routing";

            message(msg);

            Console.ReadKey();
        }

        static void message(string msg) {
            Console.WriteLine(msg);
            Console.WriteLine("1. Wake up");
            Console.WriteLine("2. Eat");
            Console.WriteLine("3. Code");
            Console.WriteLine("4. Sleep");
            Console.WriteLine();
        }
    }
}
