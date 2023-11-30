using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outofmemoryexception__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "lucky";
            string subject = "Mathamatics";

            Console.WriteLine("name = " + name.Length);
            StringBuilder sb = new StringBuilder(name.Length , name.Length);
            try
            {
                sb.Append(subject);
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadKey();  

        }
    }
}
