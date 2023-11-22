using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using second;


namespace first
{
    class obje
    {
        public void Draw()
        {
            Console.WriteLine("Calling namespace class One");
        }
    }
}

namespace second
{
    class obj1
    {
        public void Draw()
        {
            Console.WriteLine("Calling namespace second class");
        }
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
          obje boj = new obje();
        boj.Draw();

        obj1 b = new obj1();
        b.Draw();

        Console.ReadKey();

        }
    }

