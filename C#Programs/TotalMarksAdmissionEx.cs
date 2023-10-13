using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalMarksAdmissionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int math , phy , che ,total;

            Console.WriteLine("Enter Maths");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phy");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter che");
            che = Convert.ToInt32(Console.ReadLine());

            total = math + phy + che;

            Console.WriteLine(" Total is =  " + total);

            if (total >=180 )
            {
                Console.WriteLine("It is Eligible");
            }
            else
            {
                Console.WriteLine("It is Not Eligible");
            }
            
            Console.ReadKey();
        }
    }
}
