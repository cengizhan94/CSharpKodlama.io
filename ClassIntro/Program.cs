using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course kurs1 = new Course();
            kurs1.kursAdi = "C#";
            kurs1.kursEgitmeni = "Engin Demiroğ";
            kurs1.kursIzlenmeOrani = 65;

            Course kurs2 = new Course();
            kurs2.kursAdi = "Java";
            kurs2.kursEgitmeni = "Kerem Varış";
            kurs2.kursIzlenmeOrani = 50;

            Course kurs3 = new Course();
            kurs3.kursAdi = "Python";
            kurs3.kursEgitmeni = "Berkay Bilgin";
            kurs3.kursIzlenmeOrani = 100;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.kursEgitmeni);

            Course[] kurslar = new Course[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + "<> " + kurs.kursEgitmeni);
            }
        }
    }
    class Course
    {
        public string kursAdi { get; set; }
        public string kursEgitmeni { get; set; }
        public int kursIzlenmeOrani { get; set; }
    }
}
