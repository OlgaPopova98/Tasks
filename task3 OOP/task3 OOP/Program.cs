using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Kollie = new Dog(9.33f, "Tom");
            Console.WriteLine(Kollie.Name);
            Console.WriteLine();
            Dog Labrador = new Dog(10.23f, "Prince");
            Labrador.Print();
            Console.WriteLine();
            Cat Persian = new Cat(8.5f, "Peach");
            Persian.Print();


            Console.ReadKey();
        }
    }
}
