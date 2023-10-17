using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desination;
            int bonus = 0;
            Console.WriteLine("Enter desination");
            desination = Convert.ToString(Console.ReadLine());

            switch (desination)
            {
                case"manager":
                    bonus = 10000;
                    break;

                case "peun":
                    bonus = 5000;
                    break;

                case "clerk":
                    bonus = 2000;
                    break;


            }
            Console.WriteLine(" bonus is = " + bonus);
            Console.ReadKey();

        }
    }
}
