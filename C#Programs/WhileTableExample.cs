using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num , counter=1 ,  result=0 ;
            Console.WriteLine("Enter num");
            num=Convert.ToInt32(Console.ReadLine());

            while (counter <= 10)
            {
                result = counter * num;
                Console.WriteLine("{0} x {1} = {2}",num,counter,result);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
