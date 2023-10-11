using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2Num
{
    internal class Program
    {
        static void Main ()
        {
            int num1, num2, add;
            Console.WriteLine("Enter Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("addition = " + add);
            Console.ReadLine();
        }
    }
}
