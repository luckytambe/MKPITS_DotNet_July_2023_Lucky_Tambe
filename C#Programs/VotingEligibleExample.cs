using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingEligibleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter Num");
            num = Convert.ToInt32(Console.ReadLine());

            if(num >= 18)
            {
                Console.WriteLine("It is Eligible For Vote");
            }
            else
            {
                Console.WriteLine("It is Not Eligible For Vote");
            }
            Console.ReadKey();
        }
    }
}
