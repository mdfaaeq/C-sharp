using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota");
            Car car2 = new Car("Honda");
            Car car3 = new Car("Ford");

            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();
            
            Console.ReadKey();
        }
    }

    class Car
    {
        string make;
        public static int numberOfCars;

        public Car(string make)
        {
            this.make = make;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
