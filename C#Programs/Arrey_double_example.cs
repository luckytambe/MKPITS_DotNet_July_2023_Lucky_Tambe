using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to create array of float , double
namespace Arrey_double_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number");
                num[i] = Convert.ToSingle(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(" solution is = {0}", num[i]);
            }
            Console.ReadKey();
        }
    }
}
