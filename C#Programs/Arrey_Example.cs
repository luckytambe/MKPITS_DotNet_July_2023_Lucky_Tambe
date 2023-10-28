using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2};

            Console.WriteLine("Old Value at index 0: " + numbers[0]);

   
            numbers[0] = 11;
            Console.WriteLine("New Value at index 0: " + numbers[0]);

            Console.ReadLine();
        }
    }
}
