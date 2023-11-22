using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incapsulate_data
{
    class incapsulate
    {
        public int id { get; set;}

        public void display()
        {
            Console.WriteLine("Id " + id);  
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            incapsulate i= new incapsulate();
            i.id = 1;
            i.display();

            Console.ReadKey();
        }
    }
}
