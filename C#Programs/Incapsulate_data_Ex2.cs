using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulate_data_Ex2
{
    class EMploye
    {
        public int id;
        public string name;

        public void getdata(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                EMploye E = new EMploye();  
                E.id = 1;
                E.name = "Ch";

                Console.WriteLine("Id " + E.id);
                Console.WriteLine("Name " + E.name);

                Console.ReadKey();

                
        }
    }
}
