using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifre_Protected
{
    class student
    {
        protected int id;
        protected string name;

        public void display()
        {
            Console.WriteLine("id " + id);
            Console.WriteLine("Name " + name);
        }
    }

    class employe : student
    {

        public void getdata( int id , string name)
        {
            this.id = id;
            this.name = name;
        }

       public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employe e = new employe();
            e.getdata(1, "lucky");
            e.display();

            Console.ReadKey();
          
        }
    }
}
