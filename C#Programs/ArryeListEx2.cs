using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace ArryeListEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);

            foreach (object obj in ar)
            {
                Console.WriteLine("number list : " + obj);
            }
            Console.ReadKey();
        }
    }
}
