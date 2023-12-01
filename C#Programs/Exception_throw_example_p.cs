using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_throw_example_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter Age ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new Exception(" Age you should Age greater then 18");
                }
            }
            catch
            {
                Console.WriteLine("Enter age");
                Console.WriteLine("Enter greater then 18");
                age = Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine("It is eligble");
             
            }
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Bye");
            Console.ReadKey();



        }

    }
}

 