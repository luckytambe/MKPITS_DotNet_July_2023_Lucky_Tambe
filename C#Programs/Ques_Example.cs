﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Ques_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("Amit");
            q.Enqueue("Manish");
            q.Enqueue("Garg");
            q.Enqueue("Wilson");

            Console.WriteLine("Current queue: ");
            foreach (string c in q)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            q.Enqueue("Varun");
            q.Enqueue("Himesh");
            Console.WriteLine("Current queue: ");
            foreach (string c in q) Console.Write(c + " ");
            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            string ch = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            ch = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.ReadLine();
        }

    }
}
