using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_By_Pass_value_Example
{
    internal class Program
    {
        static int num = 20;
        static void lucky(int num)
        {
            num = 20; // shered value me apn jo class lete hai vo imp hai 
            Console.WriteLine("Sheared value is = " + num);
        }

        static void Main(string[] args)
        {
            int num=10; // Local value Jo bhi input me dete hai 
            lucky(num);
            Console.WriteLine("Input Local Value is = " + num);

            Console.ReadKey();

        }
    }
}
