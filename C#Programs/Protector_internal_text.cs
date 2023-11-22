using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protector_internal_text
{
    class internaltext
    {
        protected internal int id;
        protected internal string name;

        public void display()
        {
            Console.WriteLine("id " + id);
            Console.WriteLine("Name " + name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            internaltext t = new internaltext();
            t.id = 1;
            t.name = "Rajesh";
            t.display();


            Console.ReadKey();  
        }
    }
}
