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
            int index = 1;
            while (index < 7)//index 7-dən kiçik olduğu müddətcə loop davam edəcək
            {
                Console.WriteLine(index);
                index++;//yazmazsaq infinity loop yaranacaq,because index++ olmadığı üçün index artmayacaq, həmişə 1 olacaq
            }


            int index2 = 8;
            do { Console.WriteLine(index2); } while (index2 < 7);//while-dan fərqi odur ki, burada ilk kod bloku icra olunur sonra şərt yoxlanılır, və şərt doğru olmasa da whilde-dan  fərqli olaraq kod bloku ən az bir dəfə icra olunur
            Console.ReadLine();
        }
    }
}
