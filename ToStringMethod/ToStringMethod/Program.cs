using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Corolla", 2020, "Red");
            // Console.WriteLine(car.ToString());
            Console.WriteLine(car);

            Console.ReadKey();
        }
    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            return "This is a " + year + " " + color + " Color " + make + " " + model;
        }
    }
}
