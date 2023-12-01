using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Overflow_Example_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            try
            {
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                if(age < 18)
                {
                    throw new Exception("Age Should be greater then 18");
                }
                
            }
            catch (OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter smaller number please");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter age more then 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("finally block is executing");
                
            }
            Console.WriteLine("Age = " + age);
            Console.ReadKey();  
        }
    }
}
