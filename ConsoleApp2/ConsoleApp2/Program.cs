using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Furniture
    {
        private string Naming;
        private string Color;
        private int Price;

        public int price
        {
            get; set;
        }

        public Furniture(string Naming, string Color, int Price)
        {
            this.Naming = Naming;
            this.Color = Color;
            this.Price = Price;

            Print();
        }

        public void Print()
        {
            Console.WriteLine("Naming: " + Naming);
            Console.WriteLine("Color: : " + Color);
            Console.WriteLine("Price: : " + Price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Furniture Table = new Furniture("Youruls", "yellow", 5000);
            Table.price = 1000;
            Console.WriteLine(Table.price);

            Console.ReadKey();
        }
    }
}
