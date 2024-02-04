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
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();//istifadəçidən adını daxil etməsini istəyirik və daxil etdiyi stringi bir dəyişənə mənimsədirik.
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());//Console.ReadLine() metodu bir string döndürür, Bu yüzden int.Parse(Console.ReadLine()) kullanarak kullanıcının girdiğini bir tam sayıya çevirmeniz gerekiyor.
            if (age <18)
            {
                Console.WriteLine($"Yaşın çatmır, çıx çöle {name}!!!");
            }
            else
            {
                Console.WriteLine($"Xoş gördük, {name}");
            }
            Console.ReadLine();
        }
    }
}
