﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseMonthExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Month Num");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Janury");
            }
            else if (num == 2)
            {
                Console.WriteLine("February");
            }
            else if (num == 3)
            {
                Console.WriteLine("March");
            }
            else if (num == 4)
            {
                Console.WriteLine("April");
            }
            else if (num == 5)
            {
                Console.WriteLine("May");
            }
            else if (num == 6)
            {
                Console.WriteLine("June");
            }
            else if (num == 7)
            {
                Console.WriteLine("Jully");
            }
            else if (num == 8)
            {
                Console.WriteLine("August");
            }
            else if (num == 9)
            {
                Console.WriteLine("September");
            }
            else if (num == 10)
            {
                Console.WriteLine("October");
            }
            else if (num == 11)
            {
                Console.WriteLine("November");
            }
            else if (num == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }
    }
}
