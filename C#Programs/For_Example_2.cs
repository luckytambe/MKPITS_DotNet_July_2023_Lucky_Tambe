using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int outercounter = 1; outercounter <= 3; outercounter++)
            {
                for (int innercounter = 1; innercounter <= 3; innercounter++)
                {
                    Console.Write(innercounter + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
