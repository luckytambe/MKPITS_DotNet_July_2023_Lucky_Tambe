using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArreyList_PracticEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add(2);
            a1.Add(3);

            foreach(object ob in a1)
            {
                Console.WriteLine(ob);
            }
            Console.ReadKey();  
        }
    }
}
