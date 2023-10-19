using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to print prime no between 1 and 20
namespace For_Prime_number_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0 ;
            int num;
            int count = 2;

            for (num = 3; num <= 20; num++)
            {
                flag = 0;
                count = 2;
                for (count = 2; count < num; count++)
                {
                    if (num % 2 == 0)
                    {
                        flag = 1;
                        break;

                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(num);
                }
                
            }

            Console.ReadKey();
        }
    }
}
