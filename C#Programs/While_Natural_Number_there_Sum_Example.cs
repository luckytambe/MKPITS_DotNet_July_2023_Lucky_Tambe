﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Natural_Number_there_Sum_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter = 1, sum = 0;
            Console.WriteLine("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (counter <= num)
            {
                if (counter % 2 != 0)
                {
                    Console.Write("{0} ", counter);
                    sum = sum + counter;
                }
                counter++;
            }
            Console.WriteLine("\nSum is " + sum);

            Console.ReadKey();

        }
    }
}
