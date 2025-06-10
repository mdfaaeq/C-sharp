using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car[] cars = new Car[3];

            //Car car1 = new Car("Toyota");
            //Car car2 = new Car("BYD");
            //Car car3 = new Car("Nissan");

            //cars[0] = car1;
            //cars[1] = car2;
            //cars[2] = car3;

            Car[] cars = { new Car("Toyota"), new Car("BYD"), new Car("Nissan") };

            foreach (Car c in cars)
            {
                Console.WriteLine(c.model);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public string model;

        public Car(string model) { 
            this.model = model;
        }
    }
}
