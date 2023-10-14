using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingPriceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selling , cost , profit;

            Console.WriteLine("Enter sell ");
            selling = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Cost :");
            cost = Convert.ToInt32(Console.ReadLine());

            profit = cost  - selling;

            if( selling >= cost )
            {
                Console.WriteLine("The profit amount is : ");
            }
            else
            {
                Console.WriteLine("The loss Amount is : ");
            }

            Console.WriteLine(" Amount is = " + profit);

            Console.ReadKey();


        }
    }
}
