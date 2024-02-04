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
            string meetings = "Hello, i'm Gulnara. I start to learning cSharp. Gulnara. ";
            Console.WriteLine(meetings);
            Console.WriteLine(meetings.Length);
            Console.WriteLine(meetings.ToLower());//kiçik hərfə çevirir
            Console.WriteLine(meetings.ToUpper());//böyük hərfə çevirir
            Console.WriteLine(meetings.Contains("Gulnara"));//tərkibindəə axtardığımız element var mı ona baxır, false və true geri qaytarır
            Console.WriteLine(meetings.IndexOf("Gulnara"));//bu bizə "Gulnara"-nın neçənci indeksdən başladığını qaytarır, yəni 11. əgər "Gulnara" meetings-də mövcud olmazsa, onda -1 qaytarır. 
            Console.WriteLine(meetings.IndexOf("Gulnara", 4));//4-cü indeksdən başlayaraq axtarır
            Console.WriteLine(meetings.Substring(5));//5-ci indeksdən sonra nə varsa onu ekrana çıxarır
            Console.WriteLine(meetings.Substring(5, 7));//5-ci indeksdən başla, 7 simvol ekrana çıxart
            Console.WriteLine(meetings.LastIndexOf("Gulnara"));//sonuncu "Gulnara"-nın indeksini bizə  qaytarır
            Console.ReadLine();

        }
    }
}
