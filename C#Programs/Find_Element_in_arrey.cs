using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Element_in_arrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5,6,7,8,9};
            int flag = 0;
            int number;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<num.Length; i++)
            {
                if (num[i]== number)
                {
                    flag = 1;
                    break;
                }
               
            }
            if ( flag == 1)
            {
                Console.WriteLine(" Number Found in Arrey {0}", number);
            }
            else
            {
                Console.WriteLine(" Number is not Found");
            }
            
             
            Console.ReadKey();
            
        }
    }
}
