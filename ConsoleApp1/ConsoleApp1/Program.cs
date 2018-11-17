using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Name;
        public int cours;
        public bool stepa;
        public static int count = 0;

        public Student()
        {
            Name = "Nikolay";
            cours = 4;
            stepa = true;

            count++;
            Print();
        }

        public Student(string Name, int cours, bool stepa)
        {
            this.Name = Name;
            this.cours = cours;
            this.stepa = stepa;

            count++;
            Print();
        }

        public void Print ()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Cours: " + cours);
            Console.WriteLine("Stepa: " + stepa);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine();
            Student student2 = new Student("Tanya", 1, false);
            Console.WriteLine();
            Console.WriteLine("Number of students: " + Student.count);
            Console.ReadKey();
        }
    }
}
