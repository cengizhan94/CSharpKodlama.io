using System;

namespace Methots2
{
    class Program
    {
        static void Main(string[] args)
        {
            //out Keywordu ---
            //int number3 = 50; //<< Burada bir değer atamasının out keywordu icin hicbir anlami yok.
            int number3;
            int number4;
            var result3 = Add2(out number3 ,30);



            //ref Keywordu ---
            int number1 = 20;//< ref keyword'u geldiğinde methottaki değer geçerli olur ; yani referans tip gibi davranır.
            int number2 = 30;
            var result2 = Add(ref number1, number2);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
        static int Add2(out int number3, int number4 = 20)
        {
            number3 = 40;
            return number3 + number4;
        }
        static int Add(ref int number1, int number2)
        {
             number1 = 30;
            return number1 + number2;
        }
    }
}
