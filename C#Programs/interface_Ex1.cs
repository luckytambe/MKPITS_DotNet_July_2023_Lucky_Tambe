using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Ex1
{
    interface shape
    {
       void draw();

    }

    class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("Call from Rectangle");
        }
    }

    class circle : shape
    {
        public void draw()
        {
            Console.WriteLine("Call for Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s;
            s = new rectangle();
            s.draw();

            s = new circle();   
            s.draw();

            Console.ReadKey();
        }
    }
}
