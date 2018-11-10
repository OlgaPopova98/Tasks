using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char choose;
            do
            {
                int oper;
                int a, b, result;
                Console.Write("What do you want to do? Write '1' for +, '2' for -, '3' for *, '4' for / : ");
                oper = Convert.ToInt16(Console.ReadLine());
                if (oper != 1 && oper != 2 && oper != 3 && oper != 4)
                    Console.WriteLine("Warning! Invalid command!");
                else
                {
                    Console.WriteLine("Write the first number:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write the second number:");
                    b = Convert.ToInt32(Console.ReadLine());
                    switch (oper)
                    {
                        case 1:
                            result = summation(a, b);
                            Print(result);
                            break;
                        case 2:
                            result = subtraction(a, b);
                            Print(result);
                            break;
                        case 3:
                            result = multiplication(a, b);
                            Print(result);
                            break;
                        case 4:
                            result = division(a, b);
                            Print(result);
                            break;
                    }
                }
                Console.WriteLine("Do you want to calculate again? Write 'y' or 'n'.");
                choose = Convert.ToChar(Console.ReadLine());
            }
            while (choose == 'y');
            Console.WriteLine("Thanks for using!");
            Console.ReadKey();
        }

        public static void Print(int result)
        {
            Console.WriteLine("The result is " + result);
        }
        public static int summation(int a, int b)
        {
            return a + b;
        }
        public static int subtraction(int a, int b)
        {
            return a - b;
        }
        public static int multiplication(int a, int b)
        {
            return a * b;
        }
        public static int division(int a, int b)
        {
            return a / b;
        }
    }
}
