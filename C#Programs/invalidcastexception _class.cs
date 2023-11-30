using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidcastexception__class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Lucky");
            sb.Append("Chetan");

            //to.string work is multiple values printint at one time 
            Console.WriteLine(" Name = " + sb.ToString());

            object obj = sb;
            Console.WriteLine("Obj : " +  obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadKey();
            
        }
    }
}
