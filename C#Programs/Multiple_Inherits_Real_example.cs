using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inherits_Real_example
{
   public class cat
    { 
       public void cate()
        {
            Console.WriteLine("Mau");
        }
    }
    public class dog : cat
    {
      public void dogie()
        {
            Console.WriteLine("bhow bhow");
        }
    }

    public class tiger:dog
    {
        public void tigerr()
        {
            Console.WriteLine("Wowwwwwwwwwww");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            tiger t = new tiger();
            t.cate();
            t.dogie();
            t.tigerr();
            Console.ReadKey();
        }
    }
}
