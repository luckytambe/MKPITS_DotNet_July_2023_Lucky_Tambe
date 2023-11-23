using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ArryList_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList();
            A1.Add(1);
            A1.Add(2);
            A1.Add(3);
            A1.Add(4);
            A1.Add(5);
            A1.Add(6);

            foreach(Object obj in A1)
            {
                Console.WriteLine(obj);
            }

            A1.Insert(1, 3);

            Console.WriteLine("Insert Integer");
            foreach( object obj in A1)
            {
                Console.WriteLine(obj);
            }


Console.ReadKey();

        }
    }
}
