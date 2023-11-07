using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distructor_Called
{
    class Employe
    {
        public Employe()
        
        {
            Console.WriteLine("Constructor Called");
        }
        ~Employe()
        {
            Console.WriteLine("Distructor Called");
        }
    }
    
    internal class Program 
    {
        static void Main(string[] args)
        {
            Employe emp=new Employe();
            Console.ReadKey(); 
            
            Employe emp2=new Employe(); 
            Console.ReadKey();
            
        }
    }
}
