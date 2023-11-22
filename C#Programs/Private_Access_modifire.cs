using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Access_modifire
{

   

        internal class Program
        {
        class text
        {
            private int id;
            private string name;

            private void display()
            {
                Console.WriteLine("Id " + id);
                Console.WriteLine("Name " + name);
            }

        
        static void Main(string[] args)
            {
                text t = new text();
                t.id = 1;
                t.name = "raku";
                t.display();

                Console.ReadKey();
            }
        }
    }
}