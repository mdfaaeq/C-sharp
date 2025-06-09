using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", 2020, "Red");
            Car car2 = new Car("Honda", "Civic", 2021, "Blue");
            Car car3 = new Car("Ford", "Mustang", 2019, "Black");

            car1.Drive();
            car2.Drive();
            car3.Drive();

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

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }

    }
}
