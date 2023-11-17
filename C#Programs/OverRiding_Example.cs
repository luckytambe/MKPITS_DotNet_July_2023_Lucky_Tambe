using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRiding_Example
{
    internal class Program
    {
        public class animal
        {
           public virtual void eat ()
            {
                Console.WriteLine("Eat");
            }
        }

        public class dog : animal
        { 
          public virtual void dogie()
            {
                Console.WriteLine("Eating");
            }
        }

        static void Main(string[] args)
        {
            animal a = new animal();
            a.eat();
            Console.ReadKey();
        }
    }
}
