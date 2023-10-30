using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Returning_Example
{
    internal class Program
    {
        static int[] display()
        {
            int[] num = { 1, 2, 3, 4, 5 };
            return num;

        }
        static void Main(string[] args)
        {
            int[] res=display();
            for(int i=0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
        
    }
}
