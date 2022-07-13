using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2));
        }
    }
}
