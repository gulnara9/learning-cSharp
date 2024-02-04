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
            string characterName = "Numi";
            int characterAge = 21;

            Console.WriteLine("There was a girl named " + characterName);
            Console.WriteLine($"She was {characterAge} years old");
            Console.WriteLine($"She really liked the name {characterName}");
            Console.WriteLine("But didtn't like being " + characterAge);

            /*Text-dəki adı, yaşı dəyişmək lazım olduqda hər dəfəsində text-in içinə gedib adı/yaşı silib yenisi ilə əvəzləmək lazımdır,
              ancaq böyük bir text-i, məlumatın detallarrında dəyişiklik lazımdırsa bunu etmək çox zaman alacaq. Bunun üçün adı və
              yaşı bir dəyərə mənimsədirik və beləcə dəyişilməsi lazım olduqda dəyəri dəyişmək yetərli olacaq ki text-dəki ad və yaş dəyişsin.
              Yuxarıda characterName və characterAge adlı dəyişən yaradıb mətndəki ad və yaşı ona mənimsədirik. mətndə olan ad və yaşın yerinə
              characterName və characterAge yazırıq, beləcə yuxarıda dəyərlərə dəyişiklik etdiyimiz zaman avtomatik mətndə də dəyişiklik olacaq*/

            /*C# dilində dəyişənləri mətnlə birləşdirmək üçün bir neçə üsul mövcuddur.C# dilində dəyişənləri mətnlə birləşdirmək üçün bir neçə
              üsul mövcuddur:
              1.String Concatenation: Bu üsulda, +operatoru ilə dəyişənləri və mətnləri birləşdiririk.
              2.String Interpolation: Bu üsulda, $ işarəsi ilə mətnin başlanğıcında və {} işarələri ilə dəyişənləri mətnin içində qeyd edirik.*/
        }
    }
}
