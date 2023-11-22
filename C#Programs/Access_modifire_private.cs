using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifire_private
{
  
    internal class Program
    {
        class text
        {
            private int id;
            private int salary;

            public void getdata(int id, int salary)
            {
                this.id = id;
                this.salary = salary;
            }

            public void display()
            {
                Console.WriteLine("id " + id);
                Console.WriteLine("salary " + salary);
            }
        }
        static void Main(string[] args)
        {
            text t = new text();
            t.getdata(1, 5000);
            t.display();

            Console.ReadKey();

        }
    }
}
