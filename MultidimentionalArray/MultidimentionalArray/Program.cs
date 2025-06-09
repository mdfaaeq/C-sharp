using System;

namespace MultidimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multidimensional array of car models grouped by brand
            string[,] parkingLot = {
                { "Mustang", "F-150", "Explorer" },    // Ford
                { "Corvette", "Camaro", "Silverado" }, // Chevrolet
                { "Corolla", "Camry", "Rav4" }          // Toyota
            };

            parkingLot[0, 2] = "Fusion";

            foreach (string car in parkingLot) { 
                Console.WriteLine(car);
            }
            Console.WriteLine();

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {

                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write($" {parkingLot[i, j]}");
                }

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
