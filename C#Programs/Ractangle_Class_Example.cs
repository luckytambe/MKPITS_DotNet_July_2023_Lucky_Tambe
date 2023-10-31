using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ractangle_Class_Example
{
    internal class Program
    {
        class Rectangle
        {
        
            int height;
            int width;
            int rectangle;
        
            public void getdata( int  height , int width)
            {
                this.height = height;
                this.width = width;
          
            }

            public void displaydata()
            {
                rectangle=height*width;
                Console.WriteLine("Rectangle is = " + rectangle);
            }


        }
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();          
            rec.getdata(10, 5);
            rec.displaydata();
            Console.ReadKey();

        }
    }
}
