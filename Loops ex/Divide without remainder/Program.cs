using System;

namespace Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double devisortwo = 0.00;
            double devisorthree = 0.00;
            double devisorfour = 0.00;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    devisortwo += 1;
                    p1 = devisortwo / n * 100;
                }
                else if (number % 3 == 0)
                {
                    devisorthree += 1;
                    p2 = devisorthree / n * 100;
                }
                else if (number % 4 == 0)
                {
                    devisorfour += 1;
                    p3 = devisorfour / n * 100;
                }
                Console.WriteLine($"{p1:F2}");
                Console.WriteLine($"{p2:F2}");
                Console.WriteLine($"{p3:F2}");
            }
        }
    }
}
