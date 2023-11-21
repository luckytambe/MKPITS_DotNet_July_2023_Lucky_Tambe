using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_inheritance
{
    class Animal
    {
        public string color = "white";
    }

    class Dog : Animal 
    {
        public string color = "red";

        public void displaycolor()
        {
            Console.WriteLine("Dog color :" + color);
            Console.WriteLine("Animal Color :" + base.color);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog D = new Dog();
            D.displaycolor();

            Console.ReadKey();
        }
    }
}
