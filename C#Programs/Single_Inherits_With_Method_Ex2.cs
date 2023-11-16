using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherits_With_Method_Ex2
{
    class person
    {
      public void Road()
        {
            Console.WriteLine("Road");
        }
    }
    class dance : person
    {
      public void Dance()
        {
            Console.WriteLine("Dancing");
        }
    
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            dance d = new dance();  
            d.Road();
            d.Dance();

            Console.ReadKey();
        }
    }
}
