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
            sayHi("gulnara",21);//sayHi funksiyasını çağırıb, ona "gulnara" və 21 dəyərini ötürürük
            Console.ReadLine();

        }
        static void sayHi(string name, int age)// sayHi funksiyası bir string dəyər, bir integer dəyər alacağını söyləyirik
        {
            Console.WriteLine($"hello,{name}, you're {age}");
        }
    }
}
