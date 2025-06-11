using System;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planet Details:\n");

            foreach (PlanetRadius planet in Enum.GetValues(typeof(PlanetRadius)))
            {
                int radius = (int)planet;
                double volume = Volume(planet);
                Console.WriteLine($"{planet,-8} | Radius: {radius,6} km | Volume: {volume:N2} cubic km");
            }

            Console.ReadKey();
        }

        public static double Volume(PlanetRadius radius)
        {
            // Volume of a sphere: (4/3) * π * r³
            return (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        }
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}
