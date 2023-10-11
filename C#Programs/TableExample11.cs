using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter num");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<=10;i++)
            {
                Console.WriteLine(i * num=i);
            }
            Console.ReadKey();
        }
    }
}
