using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_Arreylist_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList();
            A1.Add("Lucy");
            A1.Add("jucy");
            A1.Add("Cucy");
            A1.Sort();
            foreach(object b in A1) 
            {
              Console.WriteLine(b);
            }
            Console.WriteLine("Capacity " + A1.Capacity);
            Console.WriteLine("Count " + A1.Count);

            Console.ReadKey();
        }

        
    }
}
