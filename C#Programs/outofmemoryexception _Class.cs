using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outofmemoryexception__Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "lucky";
            string subject = "Science";
            Console.WriteLine("name : " + name.Length);
            
            StringBuilder sb = new StringBuilder(name.Length , name.Length);
            try
            {
                sb.Append(subject);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
