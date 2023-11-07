using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_With_Different_Types_Parameter
{
    class Calculate
    {
      public void addition(int n1, int n2) 
        {
            int res = 0;
            res = n1 + n2;
            Console.WriteLine("Res = " + res);
        }
        public void addition(float n1, float n2)
        {
            float res = 0;
            res = n1 + n2;
            Console.WriteLine("Res = " + res);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();

            calc.addition(2, 4);

            Console.WriteLine("For Float");

            calc.addition(8.5f, 4.8f);

            Console.ReadKey();

        }
    }
}
