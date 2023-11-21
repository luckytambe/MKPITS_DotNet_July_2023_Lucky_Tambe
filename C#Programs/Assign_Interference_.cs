using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Interference_
{
    interface llonger
    {
        void logmassage(string message);
        void logerror(string errorMessage);
    }

    class ConsoleLogger : llonger
    {
        public void logmassage(string massage)
        {
            Console.WriteLine( massage);
        }
        
        public void logerror(string errorMessage)
        {
            Console.WriteLine("Massage Error " + errorMessage);
        }
    }

  

    internal class Program
    {
        static void Main(string[] args)
        {
            llonger ll = new ConsoleLogger();
            ll.logmassage("Massage Declear ");
            ll.logerror("Massage Error");

            Console.ReadKey();


        }
    }
}
