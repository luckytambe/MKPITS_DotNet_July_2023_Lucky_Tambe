using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_Ref_Example
{
    internal class Program
    {
        static void Display( int radius, ref float area , ref float circum)
        {
            
            circum = 2 * 3.14f * radius;
            area = 3.14f * radius * radius;
        }

        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("Enter Radius : ");
            radius=Convert.ToInt32(Console.ReadLine());
            float area =0 , circum = 0 ;
            Display ( radius, ref area , ref circum );
            Console.WriteLine("area is = " + area);
            Console.WriteLine("Circum is = " + circum);
            Console.ReadKey();

            
             

        }
    }
}
