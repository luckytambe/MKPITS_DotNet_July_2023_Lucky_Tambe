using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose__Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 2, 3 }, { 4, 5 } };
            int[,] arr2 = { { 1, 6 }, { 7, 9 } };
            int[,] arr3 = new int [2, 2];

            for (int r=0; r<2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    arr3[r,c]= arr1[c,r] + arr2[r,c];
                }
            }
            for( int r=0; r<2;r++)
            {
                for(int c = 0;c < 2; c++)
                {
                    Console.Write(arr3[r, c]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
