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
            Students student1 = new Students("Gulnara", "Web Development", 3.6);
            Students student2= new Students("Numi", "Design", 2.9);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.ReadLine();
        }
    }
}
