using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetterUseCases
{
    // Auto-implemented property: the compiler creates a private backing field automatically.
    // Useful for simple get/set scenarios where no additional logic is required.
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);
            car.Speed = 5000;

            Car scar = new Car("Toyota");

            Console.WriteLine(car.Speed);
            Console.WriteLine(scar.Model);

            Console.ReadKey();
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed) 
        { 
            this.speed = speed;
        }

        // Below is the auto implementation property
        public string Model { get; set; }

        public Car(string model)
        {
            this.Model = model;
        }

        public int Speed {  
            get { return this.speed; } 
            set { this.speed = value; }
        }

    }
}
