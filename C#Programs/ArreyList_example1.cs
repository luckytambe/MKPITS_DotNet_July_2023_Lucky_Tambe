using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArreyList_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Ar = new ArrayList();
            Ar.Add("Roman");
            Ar.Add("Suresh");
            Ar.Add("Eugin");

            foreach(object obj in Ar)
            {
                Console.WriteLine("Student name : " + obj);              
            }
            Console.ReadKey();
        }
    }
}
