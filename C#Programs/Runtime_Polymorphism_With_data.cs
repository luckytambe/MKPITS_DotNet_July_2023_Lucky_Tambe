using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism_With_data
{
    public class Animal
    {
        public string color = "black";
    }

    public class Dog:Animal
    {
        public string color = "Grey";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);

            Console.ReadKey();
        }
    }
}
