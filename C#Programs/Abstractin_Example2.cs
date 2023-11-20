using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractin_Example2
{
    abstract class shape
    {
        abstract public void draw();
    }

    class current : shape
    {
        public override void draw()
        {
            Console.WriteLine("Excicuted");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            shape s = new current();
            s.draw();
            Console.ReadKey();  
        }
    }
}
