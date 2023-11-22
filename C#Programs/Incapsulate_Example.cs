using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulate_Example
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "test";
            s.Description = "Looo";

            Console.WriteLine("id " + s.Id);
            Console.WriteLine("Name " + s.Name);
            Console.WriteLine("Dscription " + s.Description);

            Console.ReadKey();  
        }
    }
}
