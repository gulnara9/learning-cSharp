using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale= false;
            if (isMale)
            {
                Console.WriteLine("You are male");//əgər isMale true olarsa o zaman bu kod bloku icra olunacaq, əks halda else bloku icra olunacaq
            }
            else {
                Console.WriteLine("You are not male");
            }
             isMale = true;

            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male ");//
            }
            else
            {
                Console.WriteLine("You are either not male or tall or both");
            }
            Console.ReadLine(); 
        }
    }
}
