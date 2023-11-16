using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_Ex
{
    class Student
    {
        public string name;
    }
    class person:Student
    {
        public int pno;
    
    }
   internal class Program
    {
        static void Main(string[] args)
        {
            person per = new person();
            per.name = "Chindi";
            per.pno = 8485;

            Console.WriteLine("Name : " + per.name);
            Console.WriteLine("Pno : "+per.pno);

            Console.ReadKey();
        }
    }
}
