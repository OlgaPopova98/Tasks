using System;
using System.Collections;
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
            Dog Dalmatian = new Dog(10.23f, "Perry");
            Dalmatian.Print();
            Console.WriteLine();
            Cat Persian = new Cat(8.5f, "Peach");
            Persian.Print();
            Console.WriteLine();
            Cat Scottish = new Cat(8.5f, "Grant");
            Scottish.Print();

            List<string> animals = new List<string> { };
            animals.Add(Kollie.Name);
            animals.Add(Labrador.Name);
            animals.Add(Dalmatian.Name);
            animals.Add(Persian.Name);
            animals.Add(Scottish.Name);
            Console.WriteLine();
            Console.WriteLine("Number of elements: " + animals.Count);
            foreach (string element in animals)
                Console.WriteLine(element);
            animals.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted elements: ");
            foreach (string element in animals)
                Console.WriteLine(element);



            Console.ReadKey();
        }
    }
}
