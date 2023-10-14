using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter character");
            ch = Convert.ToChar(Console.ReadLine());

            if(ch == 'a' || ch =='e' || ch =='i' || ch =='o' || ch == 'u')
            {
                Console.WriteLine("It is vowel");
            }
            else
            {
                Console.WriteLine("it is not vowel");
            }
            Console.ReadKey();
        }
    }
}
