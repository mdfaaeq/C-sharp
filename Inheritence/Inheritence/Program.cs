using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine("The speed is: " + car.speed);
            Console.WriteLine("The number of wheels is: " + car.wheels);
            car.go();
            Console.WriteLine();

            Console.WriteLine("The speed is: " + bicycle.speed);
            Console.WriteLine("The number of wheels is: " + bicycle.wheels);
            bicycle.go();
            Console.WriteLine();

            Console.WriteLine("The speed is: " + boat.speed);
            Console.WriteLine("The number of wheels is: " + boat.wheels);
            boat.go();
            Console.WriteLine();


            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }

    }

    class Car : Vehicle {

        public int wheels = 4;

    }

    class Bicycle : Vehicle
    {

        public int wheels = 2;

    }

    class Boat : Vehicle
    {

        public int wheels = 0;

    }
}
