﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrey_Sort_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, };
            Array.Sort(arr);
            for (int i = 0 ; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
