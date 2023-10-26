using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program to accept 3 character in an array
namespace Accept_3_character_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = new char[3];

            for(int i =0;i <ch .Length;i++)
            {
                Console.WriteLine("enter Character : ");
                ch[i]=Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write("{0}", ch[i]);
            }
            Console.ReadKey();  


        }
    }
}
