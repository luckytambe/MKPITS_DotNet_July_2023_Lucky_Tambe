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
        public void deta()
        {
            Console.WriteLine("Calling deta first");
        }
    }
}

namespace second
{
    class get
    {
        public void deta() 
        {
            Console.WriteLine("Calling deta second");
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
        first.get f1 = new first.get();
        f1.deta();

        second .get f2 = new second.get();
        f2.deta();
        Console.ReadKey();
            
        }
    }

