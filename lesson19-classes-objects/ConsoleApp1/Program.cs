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
            Book book1=new Book("HP","Rowling",450);
            //book1.title = "My sweet Orange Tree";
            //book1.author = "José Mauro de Vasconcelos";
            //book1.pages = 345;
            Book book2 = new Book("LotR", "Tolkien", 650);
            Book book3 = new Book("My sweet Orange Tree", "José Mauro de Vasconcelos", 400);

            Console.WriteLine(book1);
            Console.ReadLine(); 
        }
    }
}
