using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ex2
{
    interface bank
    {
        void draw();
    }

    class Rectangle : bank
    {
        public void draw() 
        {
            Console.WriteLine("Calling from Rectangle draw");
        }
    }

    class circle : bank
    {
        public void draw()
        {
            Console.WriteLine("Calling for Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b;

            b = new Rectangle();
            b.draw();

            b = new circle();
            b.draw() ;

            Console.ReadKey();
        }
    }
}
