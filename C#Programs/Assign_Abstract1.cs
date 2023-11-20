using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Abstract
{
    abstract class shape
    {
        public abstract void draw();
       
    }

    class circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("-------Circle method-------");
        }
    }

   
    class square : shape
    {
        public override void draw()
        {
            Console.WriteLine("------Square method------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape c = new circle();
            c.draw();

            shape s = new square(); 
            s.draw();

            Console.ReadKey();


        }
    }
}
