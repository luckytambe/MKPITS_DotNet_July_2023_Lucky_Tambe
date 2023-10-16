using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElEctric_Bill_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int idno, unit;
            float total = 0, charge = 0, surcharge = 0, finalamt = 0;

            Console.WriteLine("Enter idno");
            idno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter unit");
            unit = Convert.ToInt32(Console.ReadLine());

            if (unit < 190)
            {
                charge = 1.20f;
            }
            else if (unit > 200 && unit < 400)
            {
                charge = 1.50f;
            }
            else if (unit > 400 && unit < 600)
            {
                charge = 1.80f;
            }
            else
            {
                charge = 2.00f;
            }

        total = unit * charge;
         
            Console.WriteLine(" Enter Details  idno = {0} ,  name = {1}  ,  unit = {2} ,", idno, name, unit);
            Console.WriteLine("Per unit is = " + charge);
            Console.WriteLine(" Total amount = " + total);

            if (total >= 400)
            {
                surcharge = total * 0.15f;
            }

            finalamt = total + surcharge;

            Console.WriteLine(" above 400 incluing 15%  = " + surcharge);
            Console.WriteLine(" Final charge is = " + finalamt);

            Console.ReadKey();
        }
    }
}
