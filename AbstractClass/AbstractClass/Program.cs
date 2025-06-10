using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle bicycle = new Bicycle();
            Vehicle boat = new Boat();

            DisplayVehicle(car);
            DisplayVehicle(bicycle);
            DisplayVehicle(boat);

            Console.ReadKey();
        }

        static void DisplayVehicle(Vehicle vehicle)
        {
            Console.WriteLine("The speed is: " + vehicle.Speed);
            Console.WriteLine("The number of wheels is: " + vehicle.Wheels);
            vehicle.go();
            Console.WriteLine();
        }
    }

    abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract int Wheels { get; }
        public abstract void go();
    }

    class Car : Vehicle
    {
        public override int Wheels => 4;

        public Car()
        {
            Speed = 120;
        }

        public override void go()
        {
            Console.WriteLine("The car is driving!");
        }
    }

    class Bicycle : Vehicle
    {
        public override int Wheels => 2;

        public Bicycle()
        {
            Speed = 20;
        }

        public override void go()
        {
            Console.WriteLine("The bicycle is pedaling!");
        }
    }

    class Boat : Vehicle
    {
        public override int Wheels => 0;

        public Boat()
        {
            Speed = 30;
        }

        public override void go()
        {
            Console.WriteLine("The boat is sailing!");
        }
    }
}
