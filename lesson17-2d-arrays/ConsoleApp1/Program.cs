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
            int[,] gridNums = //[,] ikiölçülü array yaratmaq 
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            Console.WriteLine(gridNums[2, 1]);// bu o deməkdir ki, gridNums daxilindəki indeksi 2 olan arrayin indeksi 1 olan elementini  gətir

            int[,] newArray = new int[2, 3];// əgər arrayda hansı elementləri yerləşdirmək istədiyimizi bilmiriksə, o zaman belə yaza bilərik, bu o anlama gəlir ki, neçə sətir neçə stüna sahib olmaq istəyirik. yəni array daxilində 2 element var və hər biri 3 element daşıyır daxilində. və sonra elementləri əl ilə daxil edə bilərik.
            Console.ReadLine();
        }
    }
}
