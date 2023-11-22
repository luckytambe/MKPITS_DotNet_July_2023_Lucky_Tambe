using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selead_Class_B
{
    sealed public class Animal
    {
        public void eat() { Console.WriteLine("eating..."); }
    }
    public class Dog : Animal
    {
        public void bark() { Console.WriteLine("barking..."); }
    }
    public class TestSealed
    {

        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
            d.bark();

        }
    }
}