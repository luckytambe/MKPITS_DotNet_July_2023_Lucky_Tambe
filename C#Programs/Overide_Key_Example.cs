using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overide_Key_Example
{
    public class person
    {
      public virtual void speak()
        {
            Console.WriteLine("Thik hai");
        }
    }

    public class Animal : person
    {
      public override void speak()
        {
            Console.WriteLine("Meu");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new Animal();
            p.speak();

            Animal a = new Animal();    
            a.speak();


            Console.ReadKey();
        }
    }
}
