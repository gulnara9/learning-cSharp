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
            int[] luckyNums = {23,67,45,34,2,37,87,5,44 };

            for (int i = 0; i < luckyNums.Length; i++)//0-dan başlayırıq çünki indeks sıfırdan başlayır
            {
                Console.WriteLine(luckyNums[i]);
            }
            Console.ReadLine(); 
        }
    }
}
