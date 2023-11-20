using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class shape
    {
        abstract public void draw();

    }

    class Rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("Code To draw Rectangle");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            shape s = new Rectangle();
            s.draw();

            Console.ReadKey();
        }
    }
}
