using System;
using FractionLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fr1 = new Fraction(1, 2);
            var fr2 = new Fraction(3, 5);

            Console.WriteLine("fr1 = " + fr1);
            Console.WriteLine("fr2 = " + fr2);
            Console.WriteLine();

            Console.WriteLine(-fr1);
            Console.WriteLine(fr1++);
            Console.WriteLine(++fr1);
            Console.WriteLine(fr1--);
            Console.WriteLine(--fr1);
            Console.WriteLine();

            Console.WriteLine(fr1 + fr2);
            Console.WriteLine(fr1 + 5);
            Console.WriteLine(5 + fr1);
            Console.WriteLine(fr1 - fr2);
            Console.WriteLine(fr1 - 5);
            Console.WriteLine(5 - fr1);
            Console.WriteLine(fr1 * fr2);
            Console.WriteLine(fr1 * 5);
            Console.WriteLine(5 * fr1);
            Console.WriteLine(fr1 / fr2);
            Console.WriteLine(fr1 / 5);
            Console.WriteLine(5 / fr1);
            Console.WriteLine();

            Console.WriteLine(fr1 > fr2 ? "fr1 > fr2" : "fr1 <= fr2");
            Console.WriteLine(fr1 < fr2 ? "fr1 < fr2" : "fr1 >= fr2");
            Console.WriteLine(fr1 >= fr2 ? "fr1 >= fr2" : "fr1 < fr2");
            Console.WriteLine(fr1 <= fr2 ? "fr1 <= fr2" : "fr1 > fr2");
            Console.WriteLine(fr1 == fr2 ? "fr1 == fr2" : "fr1 != fr2");
            Console.WriteLine(fr1 != fr2 ? "fr1 != fr2" : "fr1 == fr2");
            Console.WriteLine();

            if (fr1)
                Console.WriteLine("fr1 == true");
            if (!fr1)
                Console.WriteLine("fr1 == false");

            if (fr1 & fr2)
                Console.WriteLine("fr1 & fr2 == true");
            else
                Console.WriteLine("fr1 & fr2 == false");
            if (fr1 | fr2)
                Console.WriteLine("fr1 | fr2 == true");
            else
                Console.WriteLine("fr1 | fr2 == false");
            Console.WriteLine();

            double d = (double)fr1;
            // Следующий вариант при explicit-преобразовании работать не будет, но
            // будет при implicit-преобразовании (т.е., если заменить в методе перегрузки
            // преобразования ключевое слово explicit на ключевое слово implicit):
            //
            //double d = fr1;
            //
            Console.WriteLine(d);
        }
    }
}
