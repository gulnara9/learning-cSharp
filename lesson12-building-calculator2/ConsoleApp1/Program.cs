using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a Operator: ");
            string op = Console.ReadLine();
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num2 + num1);
            }
            else if (op == "-")
            {
                Console.WriteLine(num2 - num1);
            }
            else if(op == "*")
            {
                Console.WriteLine(num2 * num1);
            }
            else if (op == "/")
            {
                Console.WriteLine(num2 / num1);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }
            Console.ReadLine(); 
        }
    }
}
