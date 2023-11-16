using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheris_Method_Ex2
{
    class car
    {
     public void Drive()
        {
            Console.WriteLine("Drive");
        }
    }
    class cat : car 
    {
      public void Cat()
        {
            Console.WriteLine("Walk");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            cat c = new cat();
            c.Drive();
            c.Cat();
            Console.ReadKey();
        }
    }
}
