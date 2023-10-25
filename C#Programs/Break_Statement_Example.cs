using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int count = 1 ;
           
            while (count <=  40)
            {
                Console.WriteLine(count);
                if (count == 35)
                {
                    break;
                }
                count++;
                
            }
            Console.ReadKey();
        }
        
    }
}
