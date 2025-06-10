using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        /**
         * What is an Interface?
         *
         * An interface is like a list of rules (methods) that a class must follow.
         * It doesn't say *how* things should be done, just *what* needs to be done.
         * 
         * Think of it as a contract: if a class agrees to follow it, the class
         * has to include all the methods listed in the interface.
         *
         * Why use interfaces?
         * - They help different parts of a program work together.
         * - They make code easier to update or change later.
         * - They allow one class to work in many different ways, depending on how it’s written.
         */

        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
    }
    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
            Console.WriteLine();
        }
    }

    class Hawk : IPredator
    {
        public void Hunt() 
        {
            Console.WriteLine("The hawk is searching for food!");
            Console.WriteLine();
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
            Console.WriteLine();
        }
    }
}
