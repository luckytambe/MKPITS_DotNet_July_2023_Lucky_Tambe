using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExample_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter num");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i=0, j=0;i<=num;i++,j++)

            {
                Console.WriteLine("i= " + i);
                Console.Write("\t");
                Console.WriteLine("j= " + j);
            }
            Console.ReadKey();
        }
    }
}
