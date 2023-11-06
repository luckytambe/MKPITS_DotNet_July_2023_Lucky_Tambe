using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_With_DIff_Example2
{
    class MKPITS
    {
        static int srno;
        static string name;
        static string Course;

     static MKPITS()
        {
            srno = 1;
            name = "Sarang";
            Course = "JAVA";
        }

        public void dsiplay()
        {
            Console.WriteLine("Srno = "+ srno+"\n");
            Console.WriteLine("Name = "+name+"\n");
            Console.WriteLine("Course = "+Course +"\n");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MKPITS sb = new MKPITS();
            sb.dsiplay();

            Console.ReadKey();

        }
    }
}
