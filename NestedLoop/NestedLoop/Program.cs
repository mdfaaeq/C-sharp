using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Drawing a rechtangle using any symbols
            // Outer loop looks after the number of rows and the inner loop will be focusing on columns.

            Console.Write("How many rows? ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns? ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Whaty symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }   
    }
}
