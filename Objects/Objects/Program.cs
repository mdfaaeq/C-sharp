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
            Human human1 = new Human();
            human1.name = "Abhi";
            human1.age = 30;

            human1.Eat();
            human1.Sleep();

            Console.WriteLine();

            Human human2 = new Human();
            human2.name = "Rashidu";
            human2.age = 23;

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
