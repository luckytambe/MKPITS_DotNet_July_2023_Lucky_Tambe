﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_using_subtring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine((5));
            }
            catch(NullReferenceException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}

// they showing Error If We Removing Substring then they showing output 