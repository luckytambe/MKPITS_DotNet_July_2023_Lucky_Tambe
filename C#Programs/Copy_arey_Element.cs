using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_arey_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number1 = new int[3];
            int[] number2 = new int[3];

            for(int i = 0; i < number1.Length; i++)
            {
                Console.WriteLine("Enter Number1");
                number1[i] = Convert.ToInt32(number1[i]);
            }
            for(int i=0;i < number1.Length; i++)
            {
                number1[i] = number2[i];
            }
            Console.WriteLine("{0},{0}", number1, number2);

            Console.ReadLine(); 
        }
    }
}
