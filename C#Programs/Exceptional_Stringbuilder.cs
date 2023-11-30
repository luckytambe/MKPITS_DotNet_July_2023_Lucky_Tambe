using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptional_Stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Lucky");
            sb.Append("Cheatan");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
