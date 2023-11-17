using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    public class baseclass
    {
      public virtual void show()
        {
            Console.WriteLine("hello from base class show method");
        }
    }

    public class childclass : baseclass
    {
        public override void show()
        {
            Console.WriteLine("Hello From Child class Show Method");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            childclass c = new childclass();
            c.show();

            Console.ReadKey();
        }
    }
}
