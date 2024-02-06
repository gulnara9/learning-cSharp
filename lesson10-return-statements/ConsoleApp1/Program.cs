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
            Console.WriteLine(cube(5));//5 dəyəri verərək cube funksiyasını çalışdırırıq
            Console.ReadLine();
        }
        static int cube(int num)//Bu funksiya, bir int parametri alır ve bu parametrin kubunu hesaplayır.
        {
            int result = num * num * num;
            return result;//Hesaplanan nəticə result dəyişənində saxlanır ve return result ifadesi ile geri döndürülür.
        }
    }
}
