using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "Black");
            Car car2 = Copy(car1);

            ChangeColor(car1, "Blue");

            Console.WriteLine(car1.color + " " + car1.model);
            Console.WriteLine(car2.color + " " + car2.model);

            Console.ReadKey();
        }

        public static void ChangeColor(Car car, string color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }

    class Car
    {
        public string model;
        public string color;
        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}

