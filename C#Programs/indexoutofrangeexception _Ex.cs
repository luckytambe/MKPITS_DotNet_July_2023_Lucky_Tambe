using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrangeexception__Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            try
            {
                for(int i = 0; i<=3; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException rr)
            {
                Console.WriteLine(rr.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Found input");
            }
            Console.WriteLine();
            Console.ReadKey();  


        }
    }
}
