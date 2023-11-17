using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism_Ex2
{
    public class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing");
        }
    }

    public class Rectangle : shape 
    {
        public override void draw()
        {
            Console.WriteLine("Rectangle Calling");
        }
    }

    public class Circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("Circle Call");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            shape s;
            s= new shape();
            s.draw();

            shape r;
            r = new Rectangle();
            r.draw();

            shape c; 
            c = new Circle();
            c.draw();

            Console.ReadKey();
              
        }
    }
}
