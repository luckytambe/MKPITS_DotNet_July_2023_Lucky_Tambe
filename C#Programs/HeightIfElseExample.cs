using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightIfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cm ;

            Console.WriteLine("Enter num");
            cm = Convert.ToInt32(Console.ReadLine());

            if (cm  <= 150 )
            {
                Console.WriteLine(" It is Dwarf. ");
            }
            else if ( cm >=150 && cm <=170 )
            {
                Console.WriteLine("avrage ");
            }
            else
            {
                Console.WriteLine("Tall ");
            }
    
            Console.ReadKey();
        }
    }
}
