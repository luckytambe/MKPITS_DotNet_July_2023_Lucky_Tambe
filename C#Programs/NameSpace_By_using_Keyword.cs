using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using second;

namespace first
{
    class get
    {
        public void main()
        {
            Console.WriteLine("Calling first main class");
        }
    }
}

namespace second
{
    class get
    {
        public void main() 
        {

            Console.WriteLine("Calling second class");
        }
    }
}


    internal class Program
    {
        static void Main(string[] args)
        {
        first.get g1 = new first.get();
        g1.main();

        second.get g2 = new second.get();
        g2.main();

        Console.ReadKey();
        }
    }

