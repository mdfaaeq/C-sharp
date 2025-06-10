using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.speak();
            cat.speak();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("The dogs goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}
