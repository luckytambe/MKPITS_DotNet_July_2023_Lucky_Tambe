using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePrimeOrNotExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num  ;
            Console.WriteLine("Enter num");
            num=Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            int flag = 0;
            while (counter < num)
            {
                if(num%counter==0)
                {
                    
                    flag = 1;
                    counter++;
                    break;
                }
              
            }
            if (flag == 0)
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("it is not prime");
            }

            Console.ReadKey();
        }
    }
}
