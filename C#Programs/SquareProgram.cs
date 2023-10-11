using System;


namespace SquareProgramm
{
    internal class Program
    {
        public static void Main()
        {
            int num, square;

            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square = " + square);
            Console.ReadKey();
        }
        
    }
}
