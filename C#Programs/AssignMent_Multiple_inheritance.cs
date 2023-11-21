using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent_Multiple_inheritance
{
    interface ireadable
    {
        void Readdata();
        void Writedata(string data);
    }

    interface iwritable
    {
        void Readdata();
        void Writedata(string data);
    }

    class fileHandler : ireadable , iwritable
    {
        public void Readdata()
            {
            Console.WriteLine("Data Readed");
            }
        public void Writedata(string data)
        {
            Console.WriteLine(data);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ireadable i = new fileHandler();
            i.Readdata();
            i.Writedata("Write data");
           
            iwritable ii = new fileHandler();
            ii.Readdata();
            i.Writedata("Write data");


            Console.ReadKey();

        }
    }
}
