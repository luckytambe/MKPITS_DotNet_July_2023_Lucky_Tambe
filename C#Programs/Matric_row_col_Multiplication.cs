using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matric_row_col_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] aar1 = { { 1,5 }, { 2,3 } };
            int[,] aar2 = { { 6,7 }, { 9,8 } };
            int[,] arr3 = new int [2, 2];

            for( int r=0; r<2; r++ )
            {
                for (int c = 0; c < 2; c++)
                {
                    arr3[r,c] = aar1[r,c] * aar2[r,c];
                }
            }
            for (int r=0; r<2; r++)
            {
                for( int c=0; c<2;c++)
                {
                    Console.Write(arr3[r,c]+ "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
