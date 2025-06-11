using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetterUseCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);
            car.Speed = 5000;

            Console.WriteLine(car.Speed);

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

        public int Speed {  
            get { return this.speed; } 
            set { this.speed = value; }
        }
    }
}
