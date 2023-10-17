using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEvenNumberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2 ;
          
            while(num <= 10)
            {
                if(num%2==0)
                {
                    Console.WriteLine("Number is = " + num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
