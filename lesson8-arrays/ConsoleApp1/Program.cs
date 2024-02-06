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
            int[] myArray = new int[5];
            myArray[0] = 10;//y'ni array-in il elementi 10-dur
            int [] newArray = { 12, 45, 64, 3, 6, 1, 97, 53 };
            //array-in elementlərini ekrana yazdırmmaq üçün 2 üsuldan istifadə edə bilərik:
            //foreach metodu ilə
            foreach (int i in newArray)
            {
                Console.WriteLine(i);//alt-alta ekrana çıxaracaq
            }
            //string.Join metodu ilə
            Console.WriteLine(string.Join(", ", myArray));//yan-yana, vergüllə ayrılmış şəkildə ekrana çıxaracaq
            //////////////////
            //array-in hər hansısa elementini update edə bilərik
            newArray[6] = 56;//array-dakı 6-cı elementi yəni 97-ni 56 ilə əvəzləyəcək
            Console.WriteLine(newArray[6]);

            /////string array
            string[] programmingLangs = {"c#","python","java","c++" };





            Console.ReadLine();
        }
    }
}
