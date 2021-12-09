using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array - dizi

            string[] kurslar = new string[] {
                 " Yazılım Geliştirici Yetiştirme Kampı",
                 "Programlamaya başlangıç için temel kurs",
                 "Java",
                 "Python"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
