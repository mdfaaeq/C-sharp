using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza piz1 = new Pizza("Wheat", "Tomato", "Mozzarella", "Pepperoni");
            Pizza piz2 = new Pizza("Wheat", "Tomato", "Mozzarella");
            Pizza piz3 = new Pizza("Wheat", "Tomato");
            Pizza piz4 = new Pizza("Wheat");
            Pizza piz5 = new Pizza(); // default constructor

            Console.WriteLine(piz1);
            Console.WriteLine(piz2);
            Console.WriteLine(piz3);
            Console.WriteLine(piz4);
            Console.WriteLine(piz5);

            Console.ReadLine();
        }
    }

    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        public Pizza(string bread)
        {
            this.bread = bread;
        }

        // Default constructor
        public Pizza()
        {
            this.bread = "Plain";
            this.sauce = "None";
            this.cheese = "None";
            this.topping = "None";
        }

        // Override ToString to show pizza details
        public override string ToString()
        {
            return $"Pizza [Bread: {bread}, Sauce: {sauce}, Cheese: {cheese}, Topping: {topping}]";
        }
    }
}
