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
            Console.WriteLine(Math.Sqrt(144));
            Console.WriteLine(Math.Floor(7.5));
            Console.WriteLine(Math.Exp(9.4));//Bu satır, e’nin 9.4 kuvvetini hesaplar ve sonucu konsola yazar. e, matematikteki ünlü sabittir ve yaklaşık olarak 2.71828 değerindedir.
            Console.WriteLine(Math.Ceiling(8.94787458738));//Bu satır, 8.94787458738’in yukarıya doğru en yakın tam sayısını bulur ve konsola yazar.
            Console.WriteLine(Math.Pow(5.8, 3.9));//Bu satır, 8.94787458738’in yukarıya doğru en yakın tam sayısını bulur ve konsola yazar.
            Console.ReadLine();
        }
    }
}
