using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_PolyMorphism_Ex
{
    public class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing");
        }

    }

    public class rectangle : shape 
    {
        public override void draw()
        {
            Console.WriteLine("drawing Reactangle");
        }
    }

    public class circle : shape 
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            shape s = new shape();
            s.draw();

            rectangle r = new rectangle();
            r.draw();

            circle c = new circle();
            c.draw();

            Console.ReadKey();
        }
    }
}
