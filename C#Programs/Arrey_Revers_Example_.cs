using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//example of Revers method
//Print Revers in this Out Put 
namespace Arrey_Revers_Example_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 5, 8, 9, };
            Array.Reverse(num);
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
