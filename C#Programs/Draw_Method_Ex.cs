using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Method_Ex
{
    interface drawable
    {
        void draw();
    }

    class rectangle : drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }

    class circle : drawable
    {
        public  void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            drawable D;

            D = new rectangle();
            D.draw();

            D=new circle(); 
            D.draw();

            Console.ReadKey();
        }
    }
}
