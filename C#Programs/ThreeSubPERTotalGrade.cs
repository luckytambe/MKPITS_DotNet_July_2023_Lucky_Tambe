using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSubPERTotalGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, maths, bio, total;
            float per;
            string grade = null;

            Console.WriteLine("Enter Phy marks ");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter maths marks ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter bio marks ");
            bio = Convert.ToInt32(Console.ReadLine());

            total = phy + maths + bio;
            Console.WriteLine("Total Marks = " + total);

            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Per % = " + per);

            if (per >= 75 )
            {
                Console.WriteLine("Topper ");
            }
            else if (per >= 60 && per <= 75 )
            {
                Console.WriteLine("A class");
            }

            else if (per >=50 )
            {
                Console.WriteLine("class B ");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.ReadKey();





        }
    }
}
