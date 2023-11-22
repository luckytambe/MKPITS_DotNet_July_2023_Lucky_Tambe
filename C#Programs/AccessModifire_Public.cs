using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifire_Public
{
    class dtudent
    {
        public int id;
        public string name;

        public void display()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dtudent dt = new dtudent(); 
            dt.id = 1;
            dt.name = "chetan";

            dt.display();
            Console.ReadKey();
        }
    }
}
