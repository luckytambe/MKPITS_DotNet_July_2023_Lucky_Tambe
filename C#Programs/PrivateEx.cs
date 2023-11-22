using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateEx
{
    namespace AccessSpecifiers
    {
        class Program
        {
            private string name = "rakesh";

            private void Msg(string msg)
            {
                Console.WriteLine("Hello " + msg);
            }
            static void Main(string[] args)
            {
                Program program = new Program();

                Console.WriteLine("Hello " + program.name);

                program.Msg("Vijay malya");

                Console.ReadKey();
            }
        }
    }
}