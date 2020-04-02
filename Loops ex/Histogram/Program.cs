using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;
            double sumnumone = 0.00;
            double sumnumtwo = 0.00;
            double sumnumthree = 0.00;
            double sumnumfour = 0.00;
            double sumnumfive = 0.00;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    sumnumone += 1;
                    p1 = sumnumone / n * 100;
                }
                else if (200 <= number && number <= 399)
                {
                    sumnumtwo += 1;
                    p2 = sumnumtwo / n * 100;
                }
                else if (400 <= number && number <= 599)
                {
                    sumnumthree += 1;
                    p3 = sumnumthree / n * 100;
                }
                else if (600 <= number && number <= 799)
                {
                    sumnumfour += 1;
                    p4 = sumnumfour / n * 100;
                }
                else if (number >= 800)
                {
                    sumnumfive += 1;
                    p5 = sumnumfive / n * 100;
                }
                
            }
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
