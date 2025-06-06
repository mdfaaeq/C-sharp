using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants - Immutable values which are known at compile time.
            // And also it doesn't change 

            const double pi = Math.PI;
            Console.WriteLine("The value of pi: " + pi);


            // Type casting - Converting a value to a different data type.
            // Converting double to int
            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine("Converting double to an int: " + b);
            Console.WriteLine("The data type of a is: " + a.GetType());
            Console.WriteLine("The data type of b is: " + b.GetType().Name);

            // Converting int to double
            int c = 123;
            double d  = Convert.ToDouble(c) + 0.1;

            Console.WriteLine("Converting int to an double: " + d);
            Console.WriteLine("The data type of c is: " + c.GetType());
            Console.WriteLine("The data type of d is: " + d.GetType().Name);

            // Converting int to a string
            int e = 321;
            String f = Convert.ToString(e);

            Console.WriteLine("Converting int to an string: " + f);
            Console.WriteLine("The data type of e is: " + e.GetType());
            Console.WriteLine("The data type of f is: " + f.GetType().Name);

            // Converting string into an char
            String g = "H";
            char h = Convert.ToChar(g);

            Console.WriteLine("Converting string into an char: " + h);
            Console.WriteLine("The data type of g is: " + g.GetType());
            Console.WriteLine("The data type of h is: " + h.GetType().Name);

            // Converting a string into a boolean
            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine("Converting a string into a boolean: " + j);
            Console.WriteLine("The data type of i is: " + i.GetType());
            Console.WriteLine("The data type of j is: " + j.GetType().Name);

            Console.ReadKey();
        }
    }
}
