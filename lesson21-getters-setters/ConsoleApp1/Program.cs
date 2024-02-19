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
            Movie harrypotter = new Movie("aaaaa", "bbbbb", "a");
            Movie askimemnun = new Movie("cccc", "dddd", "b");

            harrypotter.Rating = "v";
            Console.WriteLine(harrypotter.Rating);
            Console.ReadLine();
        }
    }
}
