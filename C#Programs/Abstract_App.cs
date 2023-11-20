using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_App
{
    abstract class Account
    {
        abstract public void draw();
    }

    class Current : Account
    {
        public override void draw()
        {
            Console.WriteLine("Code To Be Excicuted");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Account S= new Current();
            S.draw();
            Console.ReadKey();
        }
    }
}
