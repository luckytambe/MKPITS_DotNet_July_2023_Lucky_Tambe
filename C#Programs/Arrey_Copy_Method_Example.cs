using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//array copy method
namespace Arrey_Copy_Method_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5};
            int[] num1 = new int[5];
            Array.Copy(num , num1 ,5);
            for(int i=0;i<num.Length;i++)
            {
                Console.WriteLine(num1[i]);
            }
            Console.ReadKey();
        }
    }
}
