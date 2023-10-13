using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int date, trainno, km;
            string passname, destination , clas , origin ;

            Console.WriteLine(" Enter passname ");
            passname = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" Enter destination ");
            destination = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter date");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter origin");
            origin = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter clas");
            clas = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter trainno");
            trainno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter km");
            km = Convert.ToInt32(Console.ReadLine());

            if if (km >= 1000)
                {
                Console.WriteLine("Total fair is 1200 Rupiess");
            }
            else if (km >= 500 && km >= 1000)
            {
                Console.WriteLine("Total fair is 800 Rupiess" );
            }
            else if( km>=400)
            {
                Console.WriteLine("Totalfair is 500 " );
            }
            else
            {
                Console.WriteLine("total fair is 100" );
            }

            Console.WriteLine(" Details is : passname{0} , destination{1}, date{2} , origin{3} ,  clas{4} , trainno{5}, km{6} ",
                passname , destination , date , origin , clas , trainno, km);

            Console.WriteLine("km = " + km );

            Console.ReadKey();

        }
    }
}
