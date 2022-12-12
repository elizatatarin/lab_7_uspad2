using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_uspad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat(2, "Gray", 13);
            Dog dog1 = new Dog(5, "Black", 10);

            Console.WriteLine(cat1.ToString());
            Console.WriteLine(cat1.MakeSound());
            Console.WriteLine(dog1.ToString());
            Console.WriteLine(dog1.MakeSound());

            Console.ReadKey();
        }
    }
}
