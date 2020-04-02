using System;

namespace Odd_or_Even_position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddsum = 0;
            double oddmax = double.MinValue;
            double oddmin = double.MaxValue;
            double evensum = 0;
            double evenmax = double.MinValue;
            double evenmin = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evensum += number;
                    if (number < evenmin) evenmin = number;
                    if (number > evenmax) evenmax = number;
                }
                else if (i % 2 == 1)
                {
                    oddsum += number;
                    if (number > oddmax) oddmax = number;
                    if (number < oddmin) oddmin = number;
                }
            }
            Console.WriteLine($"OddSum={oddsum:F2},");
            if (oddmin == double.MaxValue) Console.WriteLine("OddMin=No,");
            else Console.WriteLine($"OddMin={oddmin:F2},");
            if (oddmax == double.MinValue) Console.WriteLine("OddMax=No,");
            else Console.WriteLine($"OddMax={oddmax:F2},");
            Console.WriteLine($"EvenSum={evensum:F2},");
            if (evenmin == double.MaxValue) Console.WriteLine("EvenMin=No,");
            else Console.WriteLine($"EvenMin={evenmin:F2},");
            if (evenmax == double.MinValue) Console.WriteLine("EvenMax=No");
            else Console.WriteLine($"EvenMax={evenmax:F2}");

        }
    }
}
