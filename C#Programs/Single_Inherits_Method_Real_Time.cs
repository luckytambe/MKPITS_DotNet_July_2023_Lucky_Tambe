using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherits_Method_Real_Time
{
    class Animal
    { 
       public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class dog : Animal 
    {
      public void bark()
        {
            Console.WriteLine("Barking");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            dog d = new dog();
            d.eat();
            d.bark();

            Console.ReadKey();

        }
    }
}
