using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-method returning array
namespace Arrey_Return_Display_Example
{
    internal class Program
    {
        static int[] display()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, };
            return num;
        }

        static void Main(string[] args)
        {
            int[] res = display();
            for(int i=0; i<res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
           Console.ReadKey();
        }
    }
}
