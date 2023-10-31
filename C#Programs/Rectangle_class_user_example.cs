using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_class_user_example
{
    internal class Program
    {
        class Rectangle
        {

            int height;
            int width;
            int rectangle;

            public void getdata(int height, int width)
            {
                this.height = height;
                this.width = width;

            }

            public void displaydata()
            {
                rectangle = height * width;
                Console.WriteLine("Rectangle is = " + rectangle);
            }


        }
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Console.WriteLine("Enter Height and Width");
            int hei=Convert.ToInt32(Console.ReadLine());
           int  wei=Convert.ToInt32(Console.ReadLine());

            rec.getdata( hei, wei);
            rec.displaydata();
            Console.ReadKey();

        }
    }
}
