using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using second;


namespace first
{
    class employe
    {
        public void draw()
        {
            Console.WriteLine("Calling first");
        }
    }
}

namespace second
{
    class employe1
    {
        public void draw()
        {
            Console.WriteLine("Calling second");
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
        employe e = new employe();
            e.draw();

        employe1 e1 = new employe1();
        e1.draw();  

        Console.ReadKey();
        }
    }

