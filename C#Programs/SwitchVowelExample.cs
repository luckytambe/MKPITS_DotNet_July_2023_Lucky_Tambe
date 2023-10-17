using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchVowelExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.WriteLine("Enter Cherecter");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':

                    Console.WriteLine("It is vowel");
                    break;

                default:
                    Console.WriteLine("It is not vowel");
                    break;        

            }
            Console.ReadKey();
        }
    }
}
