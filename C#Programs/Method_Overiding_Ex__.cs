using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overiding_Ex__
{
    public class sujit 
    { 
      public virtual void speak()
        {
            {
                Console.WriteLine("Chalo Chale");
            }
        }
    }

    public class chetan : sujit
    { 
      public override void speak()
        {
            Console.WriteLine("Sab Chalo");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            chetan c = new chetan();
            c.speak();

            sujit s = new sujit();
            s.speak();  

            Console.ReadKey();
        }
    }
}
