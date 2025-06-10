using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objects can be identified by more than one type
            // For an example: Car, Bicycle, & Boat are indeed a Vehicle.

            Car car = new Car();
            Bicycle bicycle = new Bicycle();    
            Boat boat = new Boat();

            Vehicle[] vehicle = { car, bicycle, boat };

            foreach (Vehicle v in vehicle) {
                v.Go();
            }

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go() { }
    }

    class Car : Vehicle 
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
