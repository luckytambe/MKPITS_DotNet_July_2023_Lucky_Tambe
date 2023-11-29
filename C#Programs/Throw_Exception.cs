using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            try
            {
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 18)
                {
                    throw new Exception("Age is greater then 18");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
                Console.WriteLine("Enter Age above 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally Excicuted");
                Console.WriteLine("Age : " +  age);
            }

            Console.WriteLine("Bye");
            Console.ReadKey();

          
        }
    }
}
