using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic is not specific to a particular data type

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            DisplayElement(intArray);
            DisplayElement(doubleArray);
            DisplayElement(stringArray);

            Console.ReadKey();
        }

        //public static void DisplayElement(int[] array)
        //{
        //    foreach (int i in array) { 
        //        Console.Write(i+ " ");
        //    }
        //    Console.WriteLine();
        //}

        //public static void DisplayElement(double[] array)
        //{
        //    foreach (double i in array)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();
        //}

        //public static void DisplayElement(string[] array)
        //{
        //    foreach (string i in array)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();
        //}

        // Rather thane having the methods we can have one method which accepts all the data type.
        public static void DisplayElement<T>(T[] array)
        {
            foreach (T i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
