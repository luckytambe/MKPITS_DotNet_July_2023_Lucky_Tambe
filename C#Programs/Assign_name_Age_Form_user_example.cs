using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_name_Age_Form_user_example
{
    internal class Program
    {
        class person
        {
            string Name;
            int age;
            string address;

            public void getdata(string Name, int age, string address)
            {
                this.Name = Name;
                this.age = age;
                this.address = address;
            }
            public void displaydata()
            {
                Console.WriteLine("Name is = " + Name);
                Console.WriteLine("Age is = " + age);
                Console.WriteLine("Address = " + address);

            }
        }
        static void Main(string[] args)
        {
            person per = new person();
            Console.WriteLine("Enter Person Details, Name , age , address");
            string names = Convert.ToString(Console.ReadLine());
            int ages = Convert.ToInt32(Console.ReadLine());
            string address = Convert.ToString(Console.ReadLine());

            per.getdata(names, ages, address);

            per.displaydata();
            Console.ReadKey();

        }
    }
}
