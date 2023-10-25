using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Prime_Example
{
    internal class Program
    {
        static void prime( int num)
        {
            int counter = 2;
            int flag = 0;
            while (counter < num)
            {

                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            }
            if (flag==0)
            {
                Console.WriteLine("Prime No");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
            
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            prime(num);
            Console.ReadKey();
        }
    }
}
