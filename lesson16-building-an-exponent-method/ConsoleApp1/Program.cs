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
            Console.WriteLine(GetPow(6,3));
            Console.ReadLine();

        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)//qüvvətdən kiçik olana qədər davam etsin
            {
                result = result * baseNum;//result qüvvətdən kiçik olduğu halda hər  dövrdə baseNumu özünə vurur və beləcə qüvvətini tapmış oluruq
            }
            return result;
        }
    }
}
