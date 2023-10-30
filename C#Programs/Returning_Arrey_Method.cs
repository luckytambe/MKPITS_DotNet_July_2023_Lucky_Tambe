using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returning_Arrey_Method
{
    internal class Program
    {
      static void Display( int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++ )
            {
                Console.WriteLine(num[i]);
                sum = sum + num[i];
            }
            Console.WriteLine("Sum is = " + sum);
           
        }
       static void Main(string[] args)
        {
                int[] num = { 1, 2, 8, 9, 10 };
                Display(num);

            Console.ReadKey();

        }
       
        
        
    }
    
}
