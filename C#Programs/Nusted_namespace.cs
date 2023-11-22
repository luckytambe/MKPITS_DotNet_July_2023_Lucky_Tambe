using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using first.second;

namespace first
{
    class get
    {
        public void draw ()
        {
            Console.WriteLine("Namespace calling first");
        }
    }

    namespace second
    {
        class get
        {
            public void draw()
            {
                Console.WriteLine("namespace calling second");
            }
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
         first.get f1 = new first.get ();
        f1.draw (); 

        first.second.get f2 = new first.second.get ();
        f2.draw ();
        Console.ReadLine ();    

        }
    }

